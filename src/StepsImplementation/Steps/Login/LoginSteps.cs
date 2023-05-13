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
    public class LoginSteps : WebBrowserBase
    {
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
            /*
             *
using System;
using OpenQA.Selenium;

namespace PageObjectModelExample
{
    public class WebElements
    {
        [ID("username")]
        [XPath("//input[@name='username']")]
        public IWebElement Username { get; set; }

        [ID("password")]
        [XPath("//input[@name='password']")]
        public IWebElement Password { get; set; }

        [ID("login")]
        [XPath("//button[text()='Log in']")]
        public IWebElement LoginButton { get; set; }

        public void InitElements(IWebDriver driver)
        {
            var properties = this.GetType().GetProperties();
            foreach (var property in properties)
            {
                var idAttribute = property.GetCustomAttribute<IDAttribute>();
                var xpathAttribute = property.GetCustomAttribute<XPathAttribute>();

                if (idAttribute != null && xpathAttribute != null)
                {
                    throw new Exception($"Property '{property.Name}' cannot have both ID and XPath attributes.");
                }

                if (idAttribute != null)
                {
                    var element = driver.FindElement(By.Id(idAttribute.ID));
                    property.SetValue(this, element);
                }
                else if (xpathAttribute != null)
                {
                    var element = driver.FindElement(By.XPath(xpathAttribute.XPath));
                    property.SetValue(this, element);
                }
            }
        }
    }

    public class IDAttribute : Attribute
    {
        public string ID { get; set; }

        public IDAttribute(string ID)
        {
            this.ID = ID;
        }
    }

    public class XPathAttribute : Attribute
    {
        public string XPath { get; set; }

        public XPathAttribute(string XPath)
        {
            this.XPath = XPath;
        }
    }

    public class LoginPage
    {
        private IWebDriver driver;

        public WebElements Elements { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.Elements = new WebElements();
            this.Elements.InitElements(driver);
        }

        // Actions
        public void EnterUsername(string username)
        {
            this.Elements.Username.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            this.Elements.Password.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            this.Elements.LoginButton.Click();
        }
    }
}

             */
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

        private static void NavigateToLoginPage()
        {
            GoToUrl("http:\\www.google.pl");
        }
    }
}