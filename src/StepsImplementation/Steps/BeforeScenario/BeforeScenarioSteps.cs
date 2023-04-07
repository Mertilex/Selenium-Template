using TechTalk.SpecFlow;
using TestBase;

namespace StepsImplementation.Steps.BeforeScenario;

/// <summary>
/// W tej klasie umieszczaj metody, które mają zostać wywołane
/// przed każdym testem, który odpalasz.
/// </summary>
[Binding]
public class BeforeScenarioSteps
{
    private readonly WebBrowserController _wbc;

    public BeforeScenarioSteps()
    {
        _wbc = new WebBrowserController();
    }

    [BeforeScenario(tags: "openBrowser", Order = 1)]
    public void BeforeScenarioOpenBrowser()
    {
        _wbc.InitializeWebDriver();

        _wbc.GoToUrl();
    }

    [BeforeScenario(tags: "standardDataSet", Order = 2)]
    public void BeforeScenarioStandardDataSetTag()
    {
        /*
         * To jest dobre miejsce żeby dodać takie akcjie jak wypełnianie
         * bazy danych danymi niezbędnymi na potrzeby każdego testu.
         * Jest to niezmiernie istotne jeśli za każdym razem deployujesz
         * pustą bazę i musisz każdorazowo dodać do niej niezbędne dane.
         * Zrób to tutaj.
         */
    }

    //TODO: move this to separate class
    [AfterScenario]
    public void AfterScenarioTag()
    {
        _wbc.TerminateWebDriver();
    }
}