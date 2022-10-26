using Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Drawing;

namespace TestBase
{
    public static class ChromeDriverProvider
    {
        public static IWebDriver GetChromeDriver()
        {
            ChromeDriverService chromeDriverService;
            ChromeDriver chromeDriver;

            CreateChromeDriverService(out chromeDriverService);
            SetWebDriverLogging(chromeDriverService);
            CreateChromeDriver(out chromeDriver, PrepareChromeOptions(), chromeDriverService);
            SetWindowPositionAndSize(chromeDriver);

            return chromeDriver;
        }

        private static void CreateChromeDriverService(out ChromeDriverService chromeDriverService)
        {
            chromeDriverService = ChromeDriverService.CreateDefaultService();
        }

        private static void SetWebDriverLogging(ChromeDriverService chromeDriverService)
        {
            if (!AppSettings.EnableWebDriverLogging)
            {
                return;
            }

            CreateScreenshotDirectory(AppSettings.ScreenshotsDirectory);

            chromeDriverService.LogPath = Path.Combine(AppSettings.ScreenshotsDirectory, AppSettings.WebDriverLogFileWithExtension);//WebDriverLogFileFullPath();
            chromeDriverService.EnableVerboseLogging = AppSettings.EnableVerboseLogging;
        }

        private static ChromeOptions PrepareChromeOptions()
        {
            var chromeOptions = new ChromeOptions();

            if (AppSettings.WebDriverChromeOptions != null && AppSettings.WebDriverChromeOptions.Count > 0)
            {
                chromeOptions.AddArguments(AppSettings.WebDriverChromeOptions);
            }
            //chromeOptions.BinaryLocation = AppSettings.BrowserExePath;

            return chromeOptions;
        }

        private static void CreateChromeDriver(out ChromeDriver chromeDriver, ChromeOptions chromeOptions, ChromeDriverService chromeDriverService)
        {
            chromeDriver = new ChromeDriver(
                chromeDriverService,
                chromeOptions,
                TimeSpan.FromSeconds(AppSettings.WebDriverTimeout)
            );
        }

        private static void SetWindowPositionAndSize(ChromeDriver chromeDriver)
        {
            chromeDriver.Manage().Window.Position = new Point(0, 0);
            chromeDriver.Manage().Window.Size = AppSettings.BrowserWindowSize;
        }

        private static void CreateScreenshotDirectory(string logPath)
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
        }
    }
}