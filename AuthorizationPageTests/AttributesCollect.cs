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
    enum AttributesType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName

    }
    class AttributesCollect
    {
        public static IWebDriver driver { get; set; }
       
    }

   
}
