using System.Drawing;

namespace HanapKafe
{
    public static class ThemeSettings
    {
        public static bool IsDarkMode { get; set; } = false;

        public static Color BackColor => IsDarkMode ? Color.FromArgb(32, 32, 32) : Color.White;
        public static Color TextColor => IsDarkMode ? Color.White : Color.Black;
        public static Color PanelColor => IsDarkMode ? Color.FromArgb(45, 45, 45) : Color.White;
        public static Color ButtonColor => IsDarkMode ? Color.FromArgb(70, 70, 70) : Color.Silver;
        public static Color TextBoxBgColor => IsDarkMode ? Color.FromArgb(45, 45, 45) : Color.White;
        public static Color BorderColor => IsDarkMode ? Color.FromArgb(80, 80, 80) : Color.Gray;
    }
}
