using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Collections.Specialized.BitVector32;
using System.Security.Principal;
using OpenQA.Selenium.DevTools.V105.Runtime;

//open brower

IWebDriver driver = new ChromeDriver();

//navigate to URL
driver.Navigate().GoToUrl("http://localhost:5000/");
driver.Manage().Window.Maximize();

//Enter valid username and valid password
IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
signIn.Click();

IWebElement emailId = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
emailId.SendKeys("testingroro5@gmail.com");

IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
passwordTextbox.SendKeys("Podidonkey");

//Click login button

IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginButton.Click();
Thread.Sleep(3000);

//validate if user is logged in successfully

IWebElement profileButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));


if (profileButton.Text == "Profile")
{
    Console.WriteLine("Logged in Successfully");

}
else
{
    Console.WriteLine("Unsuccessful Login");
}

// add Description

IWebElement profileButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
profileButton1.Click();
Thread.Sleep(3000);

IWebElement descrptionIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));
descrptionIcon.Click();
Thread.Sleep(2000);

IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
descriptionTextBox.SendKeys("I love travelling and exploring different cultures");

IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
saveButton.Click();
Thread.Sleep(2000);

//validate user is able to add description

IWebElement descText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));

if(descText.Text == "oI love travelling and exploring different cultures")
{
    Console.WriteLine("Description added successfully");
}
else
{
    Console.WriteLine("Adding Description failed");
}

// Add languages

IWebElement langAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
langAddNew.Click();


IWebElement langTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
langTextBox.SendKeys("English");

IWebElement langLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
langLevelDropDown.Click();

IWebElement langLevelFluent = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
langLevelFluent.Click();

IWebElement langLevelAdd = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
langLevelAdd.Click();

// add skills

IWebElement skillsPage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
skillsPage.Click();
Thread.Sleep(3000);

IWebElement skillsAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
skillsAddNew.Click();

IWebElement skillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
skillTextBox.SendKeys("Cooking");

IWebElement skillLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
skillLevelDropDown.Click();

IWebElement skillIntermediate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
skillIntermediate.Click();

IWebElement skillAdd = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
skillAdd.Click();
Thread.Sleep(3000);

//validate skill is added to profile

IWebElement skilltab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));

if (skilltab.Text == "Cooking")
{
    Console.WriteLine("Skills added successfully");
}
else
{
    Console.WriteLine("Adding skills failed");
}

