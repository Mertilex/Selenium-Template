namespace TestBase.Containers;

public partial class LoginPage : WebPageBase
{
    public void SetLoginTextBox(string value)
    {
        SearchTextBox.SendKeys(value);
    }

    public LoginPage()
    {
        InitElements(this);
    }
}