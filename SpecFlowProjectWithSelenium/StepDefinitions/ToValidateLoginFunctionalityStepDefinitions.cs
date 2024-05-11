using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowProjectWithSelenium.StepDefinitions
{
    [Binding]
    public class ToValidateLoginFunctionalityStepDefinitions
    {
        ChromeDriver driver = new ChromeDriver();
        public string actuall = "Products";
        [Given(@"Go to the URL")]
        public void GivenGoToTheURL() {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https:/www.saucedemo.com/");

            

           // throw new PendingStepException();
        }

        [Given(@"Enter username")]
        public void GivenEnterUsername()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");


            //throw new PendingStepException();
        }

        [Given(@"Enter password")]
        public void GivenEnterPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            //throw new PendingStepException();
        }

        [When(@"click  on Login button")]
        public void WhenClickOnLoginButton()
        {

            driver.FindElement(By.Id("login-button")).Click();
            //throw new PendingStepException();
        }

        [Then(@"Validate the user is logged in")]
        public void ThenValidateTheUserIsLoggedIn()
        {


            string expected = driver.FindElement(By.XPath("//span[@class='title']")).Text;
            //Thread.Sleep(10000);
            Assert.AreEqual(expected, actuall);
            driver.Dispose();
            //throw new PendingStepException();
        }


    }
}
