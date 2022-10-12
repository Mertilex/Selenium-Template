using Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Tools.Converters;
using System.Drawing;

namespace TestBase
{
    public static class DefaultChromeDriver
    {
        private static IWebDriver chromeDriver;
        private static ChromeDriverService chromeDriverService;

        public static IWebDriver ChromeDriver
        {
            get
            {
                if (chromeDriver == null)
                {
                    chromeDriverService = ChromeDriverService.CreateDefaultService();
                    if (AppSettings.EnableWebDriverLogging)
                    {
                        chromeDriverService.LogPath = WebDriverLogFileFullPath();
                        chromeDriverService.EnableVerboseLogging = AppSettings.EnableVerboseLogging;
                    }

                    CreateChromeDriver();
                }

                return chromeDriver;
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
            chromeOptions.AddArguments(AppSettings.WebDriverChromeOptions);//"disable-popup-blocking", "disable-infobars");
            //chromeOptions.BinaryLocation = AppSettings.BrowserExePath;

            //chromeDriver = new ChromeDriver(
            //    chromeDriverService, 
            //    chromeOptions, 
            //    TimeSpan.FromSeconds(AppSettings.WebDriverTimeout)
            //    );

            //chromeDriver.Manage().Window.Position = new Point(0, 0);
            //chromeDriver.Manage().Window.Size = AppSettings.BrowserWindowSize;

            //if (!string.IsNullOrEmpty(AppSettings.BrowserExePath))
            //    Console.WriteLine($"[WebDriver] Using browser at path: {AppSettings.BrowserExePath}");
            //Console.WriteLine($"[WebDriver] Setting browser's window to: {AppSettings.BrowserWindowSize.Width}x{AppSettings.BrowserWindowSize.Height}");
        }
    }
}