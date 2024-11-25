namespace TestBase;

public class MainPageSteps : WebBrowserBase
{
    public static void NavigateToUrl()
    {
        GoToUrl("https://duckduckgo.com/"); //TODO: This should be obtained from the settings
    }

    public MainPageSteps() //: base(objectContainer)
    {
    }
}