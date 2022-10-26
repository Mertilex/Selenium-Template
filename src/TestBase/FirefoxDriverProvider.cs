using Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Drawing;

namespace TestBase;

public class FirefoxDriverProvider
{
    public static IWebDriver GetFireFoxDriver()
    {
        FirefoxDriverService firefoxDriverService;
        FirefoxDriver firefoxDriver;

        CreateFirefoxDriverService(out firefoxDriverService);
        CreateFirefoxDriver(out firefoxDriver, PrepareFirefoxOptions(), firefoxDriverService);
        SetWindowPositionAndSize(firefoxDriver);

        return firefoxDriver;
    }

    private static void CreateFirefoxDriverService(out FirefoxDriverService firefoxDriverService)
    {
        firefoxDriverService = FirefoxDriverService.CreateDefaultService();
    }

    private static void CreateFirefoxDriver(out FirefoxDriver firefoxDriver, FirefoxOptions firefoxOptions, FirefoxDriverService firefoxDriverService)
    {
        firefoxDriver = new FirefoxDriver(
            firefoxDriverService,
            firefoxOptions,
            TimeSpan.FromSeconds(AppSettings.WebDriverTimeout)
        );
    }

    private static FirefoxOptions PrepareFirefoxOptions()
    {
        var firefoxOptions = new FirefoxOptions();

        if (AppSettings.WebDriverFirefoxOptions != null && AppSettings.WebDriverFirefoxOptions.Count > 0)
        {
            firefoxOptions.AddArguments(AppSettings.WebDriverFirefoxOptions);
        }
        //firefoxOptions.BinaryLocation = AppSettings.BrowserExePath;

        return firefoxOptions;
    }

    private static void SetWindowPositionAndSize(FirefoxDriver firefoxDriver)
    {
        firefoxDriver.Manage().Window.Position = new Point(0, 0);
        firefoxDriver.Manage().Window.Size = AppSettings.BrowserWindowSize;
    }
}