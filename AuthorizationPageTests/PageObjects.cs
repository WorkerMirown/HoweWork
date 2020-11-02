using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;


namespace AuthorizationPageTests
{
    class PageObjects
    {


        public IWebElement firstname => AttributesCollect.driver.FindElement(By.Name("data[firstname]"));
        public IWebElement lastname => AttributesCollect.driver.FindElement(By.Name("data[lastname]"));
        public IWebElement email => AttributesCollect.driver.FindElement(By.Name("data[email]"));
        public IWebElement password => AttributesCollect.driver.FindElement(By.Name("data[password]"));
        public IWebElement password_confirm => AttributesCollect.driver.FindElement(By.Name("data[password_confirm]"));
        public IWebElement checkBox => AttributesCollect.driver.FindElement(By.Name("data[terms_accepted]"));
                public IWebElement checkBttn => AttributesCollect.driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/form/div[7]/div/input"));

    }
    
  }
