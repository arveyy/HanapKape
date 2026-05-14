using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HanapKafe
{
    public static class DataService
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shops.csv");

        public static List<CoffeeShop> GetShops()
        {
            List<CoffeeShop> shops = new List<CoffeeShop>();
            if (!File.Exists(filePath))
            {
                // Add some default shops if the file doesn't exist yet
                shops.Add(new CoffeeShop("Starbucks - SM North Edsa", 14.6560, 121.0315, true, "North Ave, Quezon City", "08:00-22:00"));
                shops.Add(new CoffeeShop("The Coffee Bean & Tea Leaf - Trinoma", 14.6534, 121.0337, true, "Trinoma Mall, Quezon City", "09:00-21:00"));
                shops.Add(new CoffeeShop("Bo's Coffee - SM North", 14.6565, 121.0300, true, "Quezon City", "07:00-23:00"));
                SaveShops(shops);
                return shops;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 5)
                    {
                        var shop = new CoffeeShop(
                            parts[0],
                            double.Parse(parts[1]),
                            double.Parse(parts[2]),
                            bool.Parse(parts[3]),
                            parts[4],
                            parts.Length > 5 ? parts[5] : "00:00-23:59"
                        );
                        if (parts.Length > 6) shop.IsFavorite = bool.Parse(parts[6]);
                        shops.Add(shop);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading shops: " + ex.Message);
            }

            return shops;
        }

        public static void SaveShops(List<CoffeeShop> shops)
        {
            try
            {
                var lines = shops.Select(s => $"{s.Name}|{s.Latitude.ToString()}|{s.Longitude.ToString()}|{s.IsOpen.ToString()}|{s.Address}|{s.OperatingHours}|{s.IsFavorite.ToString()}");
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving shops: " + ex.Message);
            }
        }

        public static void ToggleFavorite(string shopName)
        {
            var shops = GetShops();
            var shop = shops.FirstOrDefault(s => s.Name == shopName);
            if (shop != null)
            {
                shop.IsFavorite = !shop.IsFavorite;
                SaveShops(shops);
            }
        }

        public static void AddShop(CoffeeShop shop)
        {
            var shops = GetShops();
            shops.Add(shop);
            SaveShops(shops);
        }

        public static List<CoffeeShop> FindNearbyCoffeeShops(double lat, double lng)
        {
            // Placeholder: In a real app, this would call Google Places API
            // For now, it filters the existing CSV shops within a certain distance
            var allShops = GetShops();
            
            // Mock filtering: just return all shops for now, but log the search
            Console.WriteLine($"Filtering shops for location {lat}, {lng}...");
            
            return allShops;
        }

        // Geocoding Helper
        public static (double lat, double lng) Geocode(string address)
        {
            address = address.ToLower();
            
            // Real-world coordinates for some common areas (Cebu/Manila context)
            if (address.Contains("ayala")) return (10.3175, 123.9050);
            if (address.Contains("it park")) return (10.3297, 123.9061);
            if (address.Contains("sm city")) return (10.3117, 123.9183);
            if (address.Contains("colon")) return (10.2985, 123.8990);
            if (address.Contains("sm north")) return (14.6560, 121.0315);
            if (address.Contains("trinoma")) return (14.6534, 121.0337);
            if (address.Contains("manila")) return (14.5995, 120.9842);
            if (address.Contains("quezon")) return (14.6760, 121.0437);
            
            // Default with randomization to avoid stacking
            Random rnd = new Random();
            double baseLat = 14.5995;
            double baseLng = 120.9842;
            
            // If it seems like Cebu
            if (address.Contains("cebu"))
            {
                baseLat = 10.3157;
                baseLng = 123.8854;
            }

            double lat = baseLat + (rnd.NextDouble() - 0.5) * 0.05;
            double lng = baseLng + (rnd.NextDouble() - 0.5) * 0.05;
            return (lat, lng);
        }
    }
}
