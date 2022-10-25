using Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Tools.Converters;
using System.Drawing;

namespace TestBase
{
    public static class DefaultChromeDriver
    {
        private static IWebDriver _chromeDriver;
        private static ChromeDriverService _chromeDriverService;

        static DefaultChromeDriver()
        {
            if (_chromeDriver != null)
            {
                return; 
            }
            
            _chromeDriverService = ChromeDriverService.CreateDefaultService();
            if (AppSettings.EnableWebDriverLogging)
            {
                _chromeDriverService.LogPath = WebDriverLogFileFullPath();
                _chromeDriverService.EnableVerboseLogging = AppSettings.EnableVerboseLogging;
            }

            CreateChromeDriver();
        }

        public static IWebDriver ChromeDriver
        {
            get
            {
                return _chromeDriver;
            }
        }

        private static string WebDriverLogFileFullPath()
        {
            var logFile = $"WebDriver_{DateTime.Now.ToFileDateTimeString()}.log";
            var logFullPath = Path.Combine(AppSettings.ScreenshotsDirectory, logFile);

            CreateScreenshotDirectory(logFullPath);

            Console.WriteLine($"[WebDriver] Logs will be stored here: {logFullPath}");

            return logFullPath;
        }

        private static void CreateScreenshotDirectory(string logPath)
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
        }

        private static void CreateChromeDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(AppSettings.WebDriverChromeOptions);
            //chromeOptions.BinaryLocation = AppSettings.BrowserExePath;

            _chromeDriver = new ChromeDriver(
                _chromeDriverService,
                chromeOptions,
                TimeSpan.FromSeconds(AppSettings.WebDriverTimeout)
                );

            _chromeDriver.Manage().Window.Position = new Point(0, 0);
            _chromeDriver.Manage().Window.Size = AppSettings.BrowserWindowSize;
        }
    }
}