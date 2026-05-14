using System;

namespace HanapKafe
{
    public class CoffeeShop
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsOpen { get; set; }
        public string Address { get; set; }
        public string OperatingHours { get; set; } // Format: "08:00-22:00"
        public bool IsFavorite { get; set; }
        public string MondayHours { get; set; }
        public string TuesdayHours { get; set; }
        public string WednesdayHours { get; set; }
        public string ThursdayHours { get; set; }
        public string FridayHours { get; set; }
        public string SaturdayHours { get; set; }
        public string SundayHours { get; set; }

        public CoffeeShop(string name, double lat, double lng, bool isOpen, string address, string operatingHours = "00:00-23:59")
        {
            Name = name;
            Latitude = lat;
            Longitude = lng;
            IsOpen = isOpen;
            Address = address;
            OperatingHours = operatingHours;
            IsFavorite = false;
            // Default weekly hours
            MondayHours = TuesdayHours = WednesdayHours = ThursdayHours = FridayHours = operatingHours;
            SaturdayHours = SundayHours = operatingHours;
        }
    }
}
