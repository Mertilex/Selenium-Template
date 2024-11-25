using Configuration;
using OpenQA.Selenium;
using TestBase.WebDriverProviders;

namespace TestBase;

/// <summary>
/// Dostarcza podstawowe funkcjonalności do obsługi przeglądarki.
/// </summary>
public abstract class WebBrowserBase
{
    //TODO: Chyba to może być protected lub nawet private
    public static IWebDriver WebDriver;

    protected WebBrowserBase()
    {
        InitializeWebDriver();
    }

    public static void GoToUrl(string url)
    {
        WebDriver.Navigate().GoToUrl(url);
        //NavigateWithRetry(targetUri);
        //HandleUnsavedChanges(handleUnsavedChanges);
        //DisableCssAnimations();
        //etc.
    }

    public static void TerminateWebDriver()
    {
        if (WebDriver == null)
        {
            throw new ArgumentNullException("Web Driver cannot be null here.");
        }

        WebDriver.Close();
        WebDriver.Quit();
    }

    private void InitializeWebDriver()
    {
        if (WebDriver != null)
            return;

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

        WebDriver = provider.GetDriver();
    }
}