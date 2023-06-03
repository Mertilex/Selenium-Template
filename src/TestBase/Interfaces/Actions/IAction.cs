using OpenQA.Selenium;

namespace TestBase.Interfaces.Actions;

public interface IAction
{
    /// <summary>Set Web Element.</summary>
    /// <param name="webElement">The Web Element.</param>
    void SetWebElement(IWebElement webElement);

    /// <summary>Set Web Driver.</summary>
    /// <param name="webDriver">The Web Driver.</param>
    void SetWebDriver(IWebDriver webDriver);
}