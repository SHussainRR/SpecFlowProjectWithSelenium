using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowProjectWithSelenium.StepDefinitions
{
    [Binding]
    public class ToValidateInvalidLoginFunctionalityStepDefinitions
    {
        ChromeDriver driver = new ChromeDriver();
        public string actuall = "";
        [Given(@"Go tothe URL")]
       
        public void GivenGoTotheURL()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https:/www.saucedemo.com/");
        }

        [Given(@"Enter invalid username")]
        public void GivenEnterInvalidUsername()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("");
        }

        [Given(@"Enter invalid password")]
        public void GivenEnterInvalidPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("");
        }

        [When(@"click on Login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.Id("login-button")).Click();
        }

        [Then(@"check the error message")]
        public void ThenCheckTheErrorMessage()
        {
            string expected = driver.FindElement(By.XPath("//body/div[@id='root']/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[3]/h3[1]")).Text;
            //Thread.Sleep(10000);
            Assert.AreEqual(expected, "Epic sadface: Username is required");
            driver.Dispose();
        }
    }
}
