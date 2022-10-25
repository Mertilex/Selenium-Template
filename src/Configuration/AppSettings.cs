using System.Drawing;
using Microsoft.Extensions.Configuration;
using Tools;
using Tools.Converters;

namespace Configuration
{
    public static class AppSettings
    {
        private static readonly IConfigurationRoot Config;

        public static bool EnableWebDriverLogging => Config["EnableWebDriverLogging"].ToBool();

        public static string ScreenshotsDirectory => Config["ScreenshotsDirectory"];

        public static bool EnableVerboseLogging => Config["EnableVerboseLogging"].ToBool();

        public static int WebDriverTimeout => Config["WebDriverTimeout"].ToInt();

        public static List<string> WebDriverChromeOptions =>
            Config.GetSection("WebDriverChromeOptions").Get<List<string>>();

        public static Size BrowserWindowSize => Config["BrowserWindowSize"].ToSize();

        public static string WebDriverType => Config["WebDriverType"];

        static AppSettings()
        {
            Config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                .Build();
        }
    }
}
