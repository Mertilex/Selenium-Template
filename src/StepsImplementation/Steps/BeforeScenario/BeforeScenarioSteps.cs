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
    public BeforeScenarioSteps()
    {
        WebBrowserController wbc = new WebBrowserController(); //TODO: should it start driver implicitly?
    }

    [BeforeScenario(tags: "openBrowser", Order = 1)]
    public void BeforeScenarioOpenBrowser()
    {
        var a = 0;
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
}