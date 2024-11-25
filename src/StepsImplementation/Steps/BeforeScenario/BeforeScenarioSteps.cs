using TechTalk.SpecFlow;
using TestBase;

namespace StepsImplementation.Steps.BeforeScenario;

/// <summary>
/// Binding class that contains methods that should 
/// be executed before each test in given conditions
/// </summary>
[Binding]
public class BeforeScenarioSteps : WebBrowserBase
{
    public BeforeScenarioSteps() //: base(container)
    {
    }

    [BeforeScenario(tags: "openBrowser", Order = 1)]
    public void BeforeScenarioOpenBrowser()
    {
    }

    [BeforeScenario(tags: "standardDataSet", Order = 2)]
    public void BeforeScenarioStandardDataSetTag()
    {
        /*
         This is a place where setup action should take place. 
         E.g.: populate empty DB with test data.
         */
    }

    //TODO: move this to separate class
    [AfterScenario]
    public void AfterScenarioTag()
    {
        TerminateWebDriver();
    }
}