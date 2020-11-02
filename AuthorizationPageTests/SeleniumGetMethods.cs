using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;


namespace AuthorizationPageTests
{
    class SeleniumGetMethods
    {
        public static string GetTeAtt(string element, AttributesType elemenType)
        {
            if (elemenType == AttributesType.Id)
                return AttributesCollect.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elemenType == AttributesType.Name)
                return AttributesCollect.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (elemenType == AttributesType.CssName)
                return AttributesCollect.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            if (elemenType == AttributesType.ClassName)
                return AttributesCollect.driver.FindElement(By.ClassName(element)).GetAttribute("value");

            else return String.Empty;
        }

        public static string GetText(string element, AttributesType elemenType)
        {
            if (elemenType == AttributesType.Id)
                return AttributesCollect.driver.FindElement(By.Id(element)).Text;
            if (elemenType == AttributesType.Name)
                return AttributesCollect.driver.FindElement(By.Name(element)).Text;
            if (elemenType == AttributesType.CssName)
                return AttributesCollect.driver.FindElement(By.CssSelector(element)).Text;
            if (elemenType == AttributesType.ClassName)
                return AttributesCollect.driver.FindElement(By.ClassName(element)).Text;

            else return String.Empty;
        }
        public static string GetTextDBL(string element, AttributesType elemenType)
        {
            if (elemenType == AttributesType.Id)
                return new SelectElement(AttributesCollect.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elemenType == AttributesType.Name)
                return new SelectElement(AttributesCollect.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
