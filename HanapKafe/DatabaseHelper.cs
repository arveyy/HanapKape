using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HanapKafe
{
    public class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["HanapKapeDB"]?.ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // 1. SHOP REGISTRATION
        public static void InsertShop(int ownerId, string name, string address, string mapLink, string hoursJson)
        {
            string query = "INSERT INTO Shops (OwnerID, ShopName, Address, MapLink, OperatingHoursJSON) " +
                           "VALUES (@OwnerID, @Name, @Address, @MapLink, @HoursJSON)";
            
            SqlParameter[] parameters = {
                new SqlParameter("@OwnerID", ownerId),
                new SqlParameter("@Name", name),
                new SqlParameter("@Address", address),
                new SqlParameter("@MapLink", mapLink),
                new SqlParameter("@HoursJSON", hoursJson)
            };

            ExecuteNonQuery(query, parameters);
        }

        public static DataTable FetchAllShops()
        {
            return ExecuteQuery("SELECT * FROM Shops");
        }

        public static DataTable FetchShopsByOwner(int ownerId)
        {
            string query = "SELECT * FROM Shops WHERE OwnerID = @OwnerID";
            SqlParameter[] parameters = { new SqlParameter("@OwnerID", ownerId) };
            return ExecuteQuery(query, parameters);
        }

        // 2. COFFEE ITEMS (PRICE CHECKER)
        public static void InsertCoffeeItem(int shopId, string name, decimal price, string size, string category)
        {
            string query = "INSERT INTO CoffeeItems (ShopID, CoffeeName, Price, Size, Category) " +
                           "VALUES (@ShopID, @Name, @Price, @Size, @Category)";
            
            SqlParameter[] parameters = {
                new SqlParameter("@ShopID", shopId),
                new SqlParameter("@Name", name),
                new SqlParameter("@Price", price),
                new SqlParameter("@Size", (object)size ?? DBNull.Value),
                new SqlParameter("@Category", (object)category ?? DBNull.Value)
            };

            ExecuteNonQuery(query, parameters);
        }

        public static DataTable SearchCoffeeItems(int shopId, string keyword)
        {
            string query = "SELECT * FROM CoffeeItems WHERE ShopID = @ShopID AND CoffeeName LIKE @Search";
            SqlParameter[] parameters = {
                new SqlParameter("@ShopID", shopId),
                new SqlParameter("@Search", "%" + keyword + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        public static DataTable FetchCoffeeItemsByShop(int shopId)
        {
            string query = "SELECT * FROM CoffeeItems WHERE ShopID = @ShopID";
            SqlParameter[] parameters = { new SqlParameter("@ShopID", shopId) };
            return ExecuteQuery(query, parameters);
        }

        // 3. MAP DISPLAY - EXACT PIN LOCATION
        public static async Task<Tuple<double, double>> ExtractCoordinatesAsync(string url)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url)) return null;

                // Step 1: Resolve redirects using HEAD request
                using (var handler = new HttpClientHandler { AllowAutoRedirect = true })
                using (var client = new HttpClient(handler))
                {
                    client.Timeout = TimeSpan.FromSeconds(10);
                    // Use GetAsync if HEAD isn't sufficient for resolving full Maps URL with coordinates
                    var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    url = response.RequestMessage.RequestUri.ToString();
                }

                // Step 2: Extract from resolved URL
                // Pattern: @14.6123,121.0321
                var match = Regex.Match(url, @"@(-?\d+\.\d+),(-?\d+\.\d+)");
                if (match.Success)
                {
                    return new Tuple<double, double>(
                        double.Parse(match.Groups[1].Value),
                        double.Parse(match.Groups[2].Value)
                    );
                }

                // Fallback Pattern 2: !3dLAT!4dLNG
                var placeMatch = Regex.Match(url, @"!3d(-?\d+\.\d+)!4d(-?\d+\.\d+)");
                if (placeMatch.Success)
                {
                    return new Tuple<double, double>(
                        double.Parse(placeMatch.Groups[1].Value),
                        double.Parse(placeMatch.Groups[2].Value)
                    );
                }

                throw new Exception("Unable to fetch coordinates for this map link.");
            }
            catch (Exception ex)
            {
                LogError("Extraction error: " + ex.Message);
                throw new Exception("Unable to fetch coordinates for this map link.");
            }
        }

        // 4. UNIFIED SEARCH (NEARBY FORM)
        public static DataTable UnifiedSearch(string keyword)
        {
            string query = @"SELECT DISTINCT S.* 
                            FROM Shops S 
                            LEFT JOIN CoffeeItems C ON S.ShopID = C.ShopID 
                            WHERE S.ShopName LIKE @K 
                            OR S.Address LIKE @K 
                            OR C.CoffeeName LIKE @K 
                            OR C.Category LIKE @K";
            
            SqlParameter[] parameters = { new SqlParameter("@K", "%" + keyword + "%") };
            return ExecuteQuery(query, parameters);
        }

        // Helpers
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { LogError(ex.Message); throw; }
            return dt;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { LogError(ex.Message); throw; }
        }

        public static void LogError(string message)
        {
            try
            {
                string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
                if (!Directory.Exists(logDir)) Directory.CreateDirectory(logDir);
                File.AppendAllText(Path.Combine(logDir, "errors.txt"), $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch { }
        }
    }
}
