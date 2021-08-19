using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpNetCore
{
    class Lesson_4
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver("C:\\Users\\rben2311\\Downloads\\Chrome download");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            //Remove cookies
            Driver.FindElement(By.Id("btnCookie")).Click();

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //New Lesson 4 code
            //Clear the combo box and send Almond 
            IWebElement comboControl = Driver.FindElement(By.XPath("//input[@Id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");
            //To click the Almond entry, we need to execute the click function
            Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}
