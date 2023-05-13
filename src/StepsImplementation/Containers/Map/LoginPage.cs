using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using StepsImplementation.Containers.Map.Attributes;

namespace StepsImplementation.Containers;

public partial class LoginPage
{
    [ID("logintextbox")]
    [XPath("//xpath")]
    public IWebComponent LoginTextBox { get; set; }
}