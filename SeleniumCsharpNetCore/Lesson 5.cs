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
    class Lesson5 : DriverHelper
    {

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
            Driver.Manage().Window.Maximize();
            //Remove cookies
            Driver.FindElement(By.Id("btnCookie")).Click();

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //Lesson 5 code
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","Almond");


            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}
