using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class NUnit
    {
        public IWebDriver driver;
       
      
        [Test]
        public void Url()
        {
            driver = new ChromeDriver();
            driver.Url = ("https://www.ebay.co.uk/");
        }
        [TearDown]
        public void Browser()
        {
            driver.Close();
        }
    }
}
