using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProjectMars1.Pages;
using ProjectMars1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars1.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            //open brower

            driver = new ChromeDriver();

            //Login Page object initialization and definition


            loginPageObj.LoginSteps(driver);
        }

        [When(@"I add name in the profile")]
        public void WhenIAddNameInTheProfile()
        {
            profilePageObj.AddProfileName(driver);
        }

        [Then(@"The name should be added successfully")]
        public void ThenTheNameShouldBeAddedSuccessfully()
        {

            string newName = profilePageObj.NewName(driver);

            Assert.That(newName == "Roshi Vibes", "Adding Name failed");
        }

        [When(@"I add '([^']*)' in the profile")]



        [When(@"I add description in the profile")]
        public void WhenIAddDescriptionInTheProfile()
        {
            profilePageObj.AddDescription(driver);
        }

        [Then(@"The description should be added successfully")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully()
        {
            profilePageObj.NewDescription(driver);

        }

        [When(@"I add '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddAndToTheProfile(string languages, string level)
        {
            profilePageObj.AddLanguages(driver, languages, level);
        }


        [Then(@"The '([^']*)' and '([^']*)' should be added successfully")]

        public void ThenTheAndShouldBeAddedSuccessfully(string languages, string level)
        {
            profilePageObj.NewLang(driver, languages, level);

        }

    }
}
