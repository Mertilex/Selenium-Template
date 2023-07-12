namespace TestBase.Containers.Map.Attributes;

public class XPathAttribute : Attribute
{
    public string XPath { get; set; }

    public XPathAttribute(string xpath)
    {
        XPath = xpath;
    }
}