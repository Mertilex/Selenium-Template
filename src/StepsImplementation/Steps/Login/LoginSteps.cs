using StepsImplementation.Containers;
using TechTalk.SpecFlow;
using TestBase;

namespace StepsImplementation.Steps.Login
{
    /// <summary>
    /// To jest przykładowa klasa, która ma na celu pokazanie w jaki sposób
    /// wyglądają powiązania (Bindingi) ze stepami z plików *.feature
    /// z projektu Specification.
    /// Trzymaj tutaj tylko wysokopoziomowe implementacje bindingów, np.: SetUserPassword()
    /// Implementację właściwą trzymaj w folderze Containers
    /// </summary>
    [Binding]
    public class LoginSteps : WebBrowserBase
    {
        public LoginSteps() //: base(container)
        {
        }

        [Given(@"The User has role all privileges assigned")]
        public void GivenTheUserHasRoleAllPrivilegesAssigned()
        {
            //throw new NotImplementedException();
        }

        [Given(@"Login page is displayed")]
        public void GivenLoginPageIsDisplayed()
        {
            NavigateToLoginPage();
        }

        [When(@"the User provides login and password")]
        public void TheUserProvidesLoginAndPassword()
        {
            LoginPage lp = new LoginPage();
            lp.SetLoginTextBox("random value");
            
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

        private static void NavigateToLoginPage()
        {
            GoToUrl("https://duckduckgo.com/"); //TODO: move it to settings
        }
    }
}