using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaxiServiceOne
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://68.183.18.145/");
            Console.WriteLine("Opened browser");
        }

        [Test]
        public void ExecuteTest()
        {
            //Set the taxi owner mobile numbr
            TaxiServiceSetMethods.EnterText(driver, "ownerMobileNumber", "0813996357", "Id");

            //Set the taxi driver name
            TaxiServiceSetMethods.EnterText(driver, "driverName", "Zethembiso Msomi", "Id");

            //Set the taxi registration Number
            TaxiServiceSetMethods.EnterText(driver, "registrationNumber", "ND 345 678", "Id");


            //Get the values in each element
            Console.WriteLine("The value of the taxi owner mobile number is: " + TaxiServiceGetMethods.GetText(driver, "ownerMobileNumber", "Id"));

            Console.WriteLine("The value of the taxi registration number is: " + TaxiServiceGetMethods.GetText(driver, "driverName", "Id"));

            Console.WriteLine("The value of the taxi driver name: " + TaxiServiceGetMethods.GetText(driver, "registrationNumber", "Id"));
            //Click the Save button
            TaxiServiceSetMethods.Click(driver, "btnTransportOwner", "Id");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close browser");
        }
    }
}
