using System.Drawing;
using Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestBase.WebDriverProviders
{
    public class ChromeDriverProvider : WebDriverProviderBase, IWebDriverProvider
    {
        public IWebDriver GetDriver()
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
        
        private static void CreateScreenshotDirectory(string logPath)
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
        }
    }
}