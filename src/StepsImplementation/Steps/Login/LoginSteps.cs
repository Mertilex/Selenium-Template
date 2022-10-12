using Configuration;
using TechTalk.SpecFlow;
using TestBase;

namespace StepsImplementation.Steps.Login
{
    /// <summary>
    /// To jest przykładowa klasa, która ma na celu pokazanie w jaki sposób
    /// wyglądają powiązania (Bindingi) ze stepami z plików *.feature
    /// z projektu Specification.
    /// Te testy nigdy nie będą implementowane do poziomu działających testów.
    /// </summary>
    [Binding]
    public class LoginSteps
    {
        [Given(@"The User has role all privileges assigned")]
        public void GivenTheUserHasRoleAllPrivilegesAssigned()
        {
            //throw new NotImplementedException();
        }

        [Given(@"Login page is displayed")]
        public void GivenLoginPageIsDisplayed()
        {
            var a = DefaultChromeDriver.ChromeDriver;
        }

        [When(@"the User provides login and password")]
        public void TheUserProvidesLoginAndPassword()
        {
            var a = 0;
        }

        [When(@"the User clicks on LogIn button")]
        public void TheUserClicksOnLogInButton()
        {
            var a = 0;
        }

        [Then(@"the User is logged in")]
        public void TheUserIsLoggedIn()
        {
            var a = 0;
        }

        [Then(@"Main page of the application is displayed")]
        public void MainPageOfTheApplicationIsDisplayed()
        {
            var a = 0;
        }
    }
}