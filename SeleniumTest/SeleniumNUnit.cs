using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V122.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

   

            // navigate to chrome
            driver.Navigate().GoToUrl("https://www.google.com");

            // optional to make the web browser full screen:
            driver.Manage().Window.Maximize();
            //find element on the page element has to be specific like a name or id
            IWebElement searchBox = driver.FindElement(By.Id("APjFqb"));
            // type something in the search bar
            searchBox.SendKeys("this is the best automation course ever!");




        }
    }
}
