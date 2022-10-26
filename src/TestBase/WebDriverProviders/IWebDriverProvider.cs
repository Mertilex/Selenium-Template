using OpenQA.Selenium;

namespace TestBase.WebDriverProviders;

public interface IWebDriverProvider
{
    IWebDriver GetDriver();
}