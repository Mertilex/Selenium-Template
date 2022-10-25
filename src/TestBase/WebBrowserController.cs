using Configuration;
using OpenQA.Selenium;

namespace TestBase;

public class WebBrowserController
{
    private IWebDriver? _webDriver;

    public void InitializeWebDriver()
    {
        switch (AppSettings.WebDriverType)
        {
            case "Chrome":
                _webDriver = ChromeDriverProvider.GetChromeDriver();
                break;

            default:
                throw new ArgumentException($"Unsupported Web Driver type: {AppSettings.WebDriverType}.");
        }
    }

    public void TerminateWebDriver()
    {
        if (_webDriver == null)
        {
            throw new ArgumentNullException($"Web Driver cannot be null here.");
        }

        _webDriver.Close();
        _webDriver.Quit();
    }
}