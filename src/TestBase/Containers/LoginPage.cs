using System.Reflection;
using BoDi;
using OpenQA.Selenium;
using StepsImplementation.Containers.Map.Attributes;
using TestBase;
using TestBase.Interfaces;

namespace StepsImplementation.Containers;

public partial class LoginPage : WebBrowserBase
    //TODO: czy to jest właściwa klasa która powinna byćtutaj dziedziczona? Zobacz w QS plik: C:\North\Quaystone.v2\test\integration\QuaystoneV2.Underwriting.Web.Automation\Containers\UnderwritingPage.cs
{
    public void SetLoginTextBox(string value)
    {
        SearchTextBox.SendKeys("TEST STRING");
    }

    public LoginPage() //: base(objectContainer)
    {
        this.InitElements(WebDriver);
    }

    private void InitElements(IWebDriver driver) //TODO: to powinno być przeniesione gdzieś wyżej bo teraz każda klasa musi to implementować
    {
        var properties = this.GetType().GetProperties();
        foreach (var property in properties)
        {
            var idAttribute = property.GetCustomAttribute<IDAttribute>();
            var xpathAttribute = property.GetCustomAttribute<XPathAttribute>();

            if (idAttribute != null && xpathAttribute != null)
            {
                throw new Exception($"Property '{property.Name}' cannot have both ID and XPath attributes.");
            }

            if (idAttribute != null)
            {
                var element = driver.FindElement(By.Id(idAttribute.ID));
                property.SetValue(this, element);
                //continue;
            }
            else if (xpathAttribute != null)
            {
                var element = driver.FindElement(By.XPath(xpathAttribute.XPath));
                property.SetValue(this, element);
            }
        }
    }
}