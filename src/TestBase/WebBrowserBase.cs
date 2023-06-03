﻿using Configuration;
using OpenQA.Selenium;
using TestBase.WebDriverProviders;

namespace TestBase;

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
        /*
         * Ta sama metoda jest w klasach które dziedziczą po tej klasie. W tym miejscu powinna być dokładna implementacja akcji navigate z uwzględnieniem Retry, SaveUnhandledChanges, ClosePopups, itd. W miejscach gdzie dziedziczysz po klasie powinno być proste nvigate i tyle. Bez dbania o szczegóły.
         *
         */
        WebDriver.Navigate().GoToUrl(url);
        //NavigateWithRetry(targetUri);
        //HandleUnsavedChanges(handleUnsavedChanges);
        //DisableCssAnimations();
        //itd.
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