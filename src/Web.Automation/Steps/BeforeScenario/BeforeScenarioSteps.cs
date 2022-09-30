using TechTalk.SpecFlow;

namespace Web.Automation.Steps.BeforeScenario;

/// <summary>
/// W tej klasie umieszczaj metody, które mają zostać wywołane
/// przed każdym testem, który odpalasz.
/// </summary>
[Binding]
public class BeforeScenarioSteps
{
    [BeforeScenario(tags: "standardDataSet", Order = 1)]
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