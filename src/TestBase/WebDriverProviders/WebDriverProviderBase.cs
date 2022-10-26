using Configuration;
using OpenQA.Selenium;
using System.Drawing;

namespace TestBase.WebDriverProviders;

public class WebDriverProviderBase
{
    protected void SetWindowPositionAndSize(IWebDriver webDriver)
    {
        webDriver.Manage().Window.Position = new Point(0, 0);
        webDriver.Manage().Window.Size = AppSettings.BrowserWindowSize;
    }
}