using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProjectMars1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMars1.Utilities;

namespace ProjectMars1.Tests
{
    [TestFixture]
    public class Profile_Tests : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {

            //open brower

            driver = new ChromeDriver();

            //Login Page object initialization and definition

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [Test, Order(1)]
        public void AddNameTest()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddProfileName(driver);
        }
        [Test, Order(2)]
        public void AddDescriptionTest()
        {
            ProfilePage profilePageObj = new ProfilePage();
           // profilePageObj.AddDescription(driver);
        }

        [Test, Order(3)]

        public void AddLanguageTest()
        {
            ProfilePage profilePageObj = new ProfilePage();
            //profilePageObj.AddLanguages(driver);
        }



    }
}
