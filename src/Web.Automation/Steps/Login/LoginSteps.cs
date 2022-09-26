using TechTalk.SpecFlow;

namespace Web.Automation.Steps.Login
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"Login page is displayed")]
        public void GivenLoginPageIsDisplayed()
        {
            throw new PendingStepException();
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