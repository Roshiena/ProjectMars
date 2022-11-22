using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars1.Pages
{
    public class ProfilePage
    {
        public void AddProfileName(IWebDriver driver)
        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i", 5);

            IWebElement nameIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            nameIcon.Click();
            //Wait.WaitToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]", 5);

            IWebElement firstNameTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            firstNameTextbox.Clear();
            firstNameTextbox.SendKeys("Roshi");

            IWebElement secondNameTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            secondNameTextbox.Clear();
            secondNameTextbox.SendKeys("Vibes");
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button", 5);

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            saveButton.Click();
            //Wait.WaitToExist(driver, "XPath", "//*[@id=\\\"account - profile - section\\\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/text()", 5);


        }

        public string NewName(IWebDriver driver) 
        {
            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            return newName.Text;
        }

        public void AddDescription(IWebDriver driver)
        {


            IWebElement descriptionIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionIcon.Click();
            //Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 10);


            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("I love travelling and exploring different cultures");

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span", 3);


        }

        public void NewDescription(IWebDriver driver)

        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span", 5);

            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.That(newDescription.Text == "I love travelling and exploring different cultures", "Adding Description failed");
        }





        public void AddLanguages(IWebDriver driver, string languages, string level)
            
        {
            IWebElement langAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            langAddNew.Click();


            IWebElement langTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            langTextbox.SendKeys(languages);

            SelectElement chooseLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
            chooseLanguageLevel.SelectByValue(level);

            IWebElement langAddbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            langAddbutton.Click();
            

        }

        public void NewLang(IWebDriver driver, string languages, string level)
        {
            IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 7);

            IWebElement newLang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            Assert.That(newLang.Text == languages, "Actual Language and expected language do not match");
            Assert.That(newLevel.Text == level, "Actual Level and expected level do not match");

        }

        
    }
}
