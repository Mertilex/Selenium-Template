using TechTalk.SpecFlow;
using TestBase;
using TestBase.Containers;

namespace StepsImplementation.Steps.Login
{
    /// <summary>
    /// Example class that shows correlation between [Binding] and steps in *.feature files.
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
            var lp = new LoginPage();
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