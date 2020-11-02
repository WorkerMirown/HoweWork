using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;




namespace AuthorizationPageTests
{
    class SeleniumSetMethods
    {

        //EnterText
        public static void EnterText(string element, string value, AttributesType elemenType)
        {
            if (elemenType == AttributesType.Id)
                AttributesCollect.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elemenType == AttributesType.Name)
                AttributesCollect.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        //Button,CheckBox, anybox = Click

        public static void Click(string element, AttributesType elemenType)
        {
            if (elemenType == AttributesType.Id)
                AttributesCollect.driver.FindElement(By.Id(element)).Click();
            if (elemenType == AttributesType.Name)
                AttributesCollect.driver.FindElement(By.Name(element)).Click();
        }
        //Drop down control
        public static void DropDown(string element, string value, AttributesType elemenType)
        { 
            if (elemenType == AttributesType.Id)
               new SelectElement(AttributesCollect.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elemenType == AttributesType.Name)
               new SelectElement(AttributesCollect.driver.FindElement(By.Name(element))).SelectByText(value);
        }
       
    }
}
