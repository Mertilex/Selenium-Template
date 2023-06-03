using System.Runtime.CompilerServices;
using BoDi;
using OpenQA.Selenium;
using StepsImplementation.Containers.Map.Attributes;
using TestBase.Interfaces;

namespace StepsImplementation.Containers;

public partial class LoginPage
{
    [ID("searchbox_input")]
    //[XPath("/html/body/div[1]/main/article/div[1]/div[1]/section[1]/img")]
    public IWebElement SearchTextBox { get; set; }
}