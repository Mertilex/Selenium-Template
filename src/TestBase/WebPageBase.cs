using OpenQA.Selenium;
using StepsImplementation.Containers.Map.Attributes;
using System.Reflection;
using StepsImplementation.Containers;
using TestBase.Interfaces;

namespace TestBase;

/// <summary>
/// Służy do dostarczenia funkcjonalności które pozowolą na inicjalizację elementów na stronie.
/// </summary>
public abstract class WebPageBase : WebBrowserBase
{
    protected void InitElements(IPageMap pageMap)
    {
        var properties = pageMap.GetType().GetProperties(); //TODO: fix this
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
                var element = WebDriver.FindElement(By.Id(idAttribute.ID));
                property.SetValue(this, element);
                //continue;
            }
            else if (xpathAttribute != null)
            {
                var element = WebDriver.FindElement(By.XPath(xpathAttribute.XPath));
                property.SetValue(this, element);
            }
        }
    }

}