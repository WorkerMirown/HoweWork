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





namespace AuthorizationPageTests
{
    public class Tests
    {
        string firstPageUrl = "https://voenzakaz-spb.ru/signup/";
       
        [SetUp]
        public void Setup()
        {
            
            AttributesCollect.driver = new ChromeDriver();
            //Go to Crome
            AttributesCollect.driver.Navigate().GoToUrl(firstPageUrl);
            AttributesCollect.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
            
        }

        [Test]
        public void GreenTest()
        {

            PageObjects page = new PageObjects();
            WebDriverWait wait = new WebDriverWait(AttributesCollect.driver, TimeSpan.FromSeconds(2.5));
            Random rnd = new Random();
            int rndValue = rnd.Next(100, 999);

            page.firstname.SendKeys($"CheckThisPage{rndValue}");
            page.lastname.SendKeys("Иванов");
            rndValue = rnd.Next(100, 999);
            page.email.SendKeys($"SomeLog{rndValue}@asd.com");
            page.password.SendKeys("1q2w3e4r5t1");
            page.password_confirm.SendKeys("1q2w3e4r5t1");
            page.checkBox.Click();
            page.checkBttn.Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[1]/span")));
            Console.WriteLine("GreenTestComplited");
            AttributesCollect.driver.Close();
        }

        [Test]
        public void EmptyRedTest()
        {
            PageObjects page = new PageObjects();
            WebDriverWait wait = new WebDriverWait(AttributesCollect.driver, TimeSpan.FromSeconds(2.5));

            AttributesCollect.driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/form/div[7]/div/input")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("[class=\"wa-error-msg\"]")));
            string MsgErrorText = SeleniumGetMethods.GetText("wa-error-msg", AttributesType.ClassName);
            Assert.AreEqual(MsgErrorText, "Поле «Email» является обязательным");
            Console.WriteLine($"Email.Текст Ошибки: {MsgErrorText}");

            MsgErrorText = SeleniumGetMethods.GetText("div.wa-field.wa-field-password_confirm > div.wa-value > em", AttributesType.CssName);
            Assert.AreEqual(MsgErrorText, "Пароль не может быть пустым");
            Console.WriteLine($"Пароль.Текст Ошибки: {MsgErrorText}");

            MsgErrorText = SeleniumGetMethods.GetText("div:nth-child(6) > div > em", AttributesType.CssName);
            Assert.AreEqual(MsgErrorText, "Подтвердите согласие");
            Console.WriteLine($"Галка.Email.Текст Ошибки: {MsgErrorText}");


            Console.WriteLine("RedTestComplited");
           
            
        }


        [TearDown]

        public void TearDown()
        {
            AttributesCollect.driver.Quit();
        }

        [Test]
        public void FoxGreenTest()
        {
            AttributesCollect.driver = new FirefoxDriver();

            PageObjects page = new PageObjects();
            WebDriverWait wait = new WebDriverWait(AttributesCollect.driver, TimeSpan.FromSeconds(2.5));
            Random rnd = new Random();
            int rndValue = rnd.Next(100, 999);

            page.firstname.SendKeys($"CheckThisPage{rndValue}");
            page.lastname.SendKeys("Иванов");
            rndValue = rnd.Next(100, 999);
            page.email.SendKeys($"SomeLog{rndValue}@asd.com");
            page.password.SendKeys("1q2w3e4r5t1");
            page.password_confirm.SendKeys("1q2w3e4r5t1");
            page.checkBox.Click();
            page.checkBttn.Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[1]/span")));
            Console.WriteLine("GreenTestComplited");
            AttributesCollect.driver.Close();
        }

        [Test]
        public void FoxEmptyRedTest()
        {
            AttributesCollect.driver = new FirefoxDriver();

            PageObjects page = new PageObjects();
            WebDriverWait wait = new WebDriverWait(AttributesCollect.driver, TimeSpan.FromSeconds(2.5));

            AttributesCollect.driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/form/div[7]/div/input")).Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("[class=\"wa-error-msg\"]")));
            string MsgErrorText = SeleniumGetMethods.GetText("wa-error-msg", AttributesType.ClassName);
            Assert.AreEqual(MsgErrorText, "Поле «Email» является обязательным");
            Console.WriteLine($"Email.Текст Ошибки: {MsgErrorText}");

            MsgErrorText = SeleniumGetMethods.GetText("div.wa-field.wa-field-password_confirm > div.wa-value > em", AttributesType.CssName);
            Assert.AreEqual(MsgErrorText, "Пароль не может быть пустым");
            Console.WriteLine($"Пароль.Текст Ошибки: {MsgErrorText}");

            MsgErrorText = SeleniumGetMethods.GetText("div:nth-child(6) > div > em", AttributesType.CssName);
            Assert.AreEqual(MsgErrorText, "Подтвердите согласие");
            Console.WriteLine($"Галка.Email.Текст Ошибки: {MsgErrorText}");


            Console.WriteLine("RedTestComplited");


        }

    }
}