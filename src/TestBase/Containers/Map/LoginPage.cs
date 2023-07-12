using OpenQA.Selenium;
using TestBase.Containers.Map.Attributes;
using TestBase.Interfaces;

namespace TestBase.Containers; //It has to be the same namespace as for other partial classes

public partial class LoginPage : IPageMap
{
    [ID("searchbox_input")]
    //[XPath("/html/body/div[1]/main/article/div[1]/div[1]/section[1]/img")]
    public IWebElement SearchTextBox { get; set; }
}