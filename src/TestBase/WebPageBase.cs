using OpenQA.Selenium;
using System.Reflection;
using TestBase.Containers.Map.Attributes;
using TestBase.Interfaces;

namespace TestBase;

/// <summary>
/// Ensures that attributes are initialized to be used in communication with the page
/// </summary>
public abstract class WebPageBase : WebBrowserBase
{
    protected void InitElements(IPageMap pageMap)
    {
        var pageComponents = GetAllPageComponents(pageMap);
        foreach (var component in pageComponents)
        {
            var idAttribute = component.GetCustomAttribute<IDAttribute>();
            var xpathAttribute = component.GetCustomAttribute<XPathAttribute>();

            ValidateAttributes(idAttribute, xpathAttribute, component.Name);

            if (idAttribute != null)
            {
                var element = WebDriver.FindElement(By.Id(idAttribute.ID));
                component.SetValue(this, element);
                
                continue;
            }
            
            if (xpathAttribute != null)
            {
                var element = WebDriver.FindElement(By.XPath(xpathAttribute.XPath));
                component.SetValue(this, element);

                continue;
            }
        }
    }

    private static void ValidateAttributes(IDAttribute? idAttribute, XPathAttribute? xpathAttribute, string componentName)
    {
        if (idAttribute == null && xpathAttribute == null)
        {
            throw new Exception($"Property related to the following component: '{componentName}' must have at least one attribute.");
        }

        if (idAttribute != null && xpathAttribute != null)
        {
            throw new Exception($"Property related to the following component: '{componentName}' cannot have both ID and XPath attributes.");
        }
    }

    private static IEnumerable<PropertyInfo> GetAllPageComponents(IPageMap pageMap)
    {
        return pageMap.GetType().GetProperties();
    }
}