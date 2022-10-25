using Configuration;
using OpenQA.Selenium;

namespace TestBase;

public class WebBrowserController
{
    private IWebDriver _webDriver;

    public WebBrowserController()
    {
        switch (AppSettings.WebDriverType)
        {
            case "Chrome":
                _webDriver = DefaultChromeDriver.ChromeDriver;
                break;

            default:
                throw new ArgumentException($"Unsupported Web Driver type: {AppSettings.WebDriverType}.");
        }
    }
}