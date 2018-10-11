using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TaxiServiceOne
{
    class TaxiServiceSetMethods
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        public static void SelectDropDowns(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
