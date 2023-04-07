using Configuration;
using OpenQA.Selenium;
using TestBase.WebDriverProviders;

namespace TestBase;

public class WebBrowserController
{
    private IWebDriver? _webDriver;

    public void InitializeWebDriver()
    {
        IWebDriverProvider provider;

        switch (AppSettings.WebDriverType)
        {
            case "Chrome":
                provider = new ChromeDriverProvider();
                break;

            case "Firefox":
                provider = new FirefoxDriverProvider();
                break;

            default:
                throw new ArgumentException($"Unsupported Web Driver type: {AppSettings.WebDriverType}.");
        }

        _webDriver = provider.GetDriver();
    }

    public void GoToUrl()
    {
        _webDriver.Navigate().GoToUrl("http:\\www.google.pl");
        var a = 0;
    }

    public void TerminateWebDriver()
    {
        if (_webDriver == null)
        {
            throw new ArgumentNullException("Web Driver cannot be null here.");
        }

        _webDriver.Close();
        _webDriver.Quit();
    }
}