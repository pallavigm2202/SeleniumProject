using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); 
            //  driver.Navigate().GoToUrl("https://www.guru99.com/selenium-csharp-tutorial.html");
            
            //Registering
          /*  driver.Url = "http://www.newtours.demoaut.com/";

            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("REGISTER")).Click();
            driver.FindElement(By.XPath("//*[@name='firstName']")).SendKeys("Pallavi");
            driver.FindElement(By.XPath("//*[@name='lastName']")).SendKeys("GM");
            driver.FindElement(By.XPath("//*[@name='phone']")).SendKeys("123456");
            driver.FindElement(By.XPath("//*[@name='userName']")).SendKeys("pallavigm22@gmail.com");
            driver.FindElement(By.XPath("//*[@name='email']")).SendKeys("pallavigm22");
            driver.FindElement(By.XPath("//*[@name='password']")).SendKeys("pallavigm22");
            driver.FindElement(By.XPath("//*[@name='confirmPassword']")).SendKeys("pallavigm22");
            driver.FindElement(By.XPath("//*[@name='register']")).Click();
            driver.Quit();*/

            driver.Url = "http://www.newtours.demoaut.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@name='userName']")).SendKeys("pallavigm22");
            driver.FindElement(By.XPath("//*[@name='password']")).SendKeys("pallavigm22");
            driver.FindElement(By.XPath("//*[@name='login']")).Click();
            
            //Find Flights
            driver.FindElement(By.LinkText("Flights")).Click();
            IWebElement radio = driver.FindElement(By.XPath("//input[@value='oneway']"));
            radio.Click();
            IWebElement drp = driver.FindElement(By.XPath("//select[@name='passCount']"));
            SelectElement ele = new SelectElement(drp);
            ele.SelectByText("4");
            IWebElement place = driver.FindElement(By.XPath("//select[@name='fromPort']"));
            SelectElement ele2 = new SelectElement(place);
            ele2.SelectByText("London");
            IWebElement FromMonth = driver.FindElement(By.XPath("//select[@name='fromMonth']"));
            SelectElement ele3 = new SelectElement(FromMonth);
            ele3.SelectByText("April");
            IWebElement FromDay = driver.FindElement(By.XPath("//select[@name='fromDay']"));
            SelectElement ele4 = new SelectElement(FromDay);
            ele4.SelectByText("28");
           
            IWebElement radio1 = driver.FindElement(By.XPath("//input[@value='Business']"));
            radio1.Click();
            IWebElement Airline = driver.FindElement(By.XPath("//select[@name='airline']"));
            SelectElement ele5 = new SelectElement(Airline);
            ele5.SelectByText("No Preference");
            driver.FindElement(By.XPath("//*[@name='findFlights']")).Click();


            // IWebElement drp = driver.FindElement(By.XPath("//select[@name='country']"));

            //SelectElement ele = new SelectElement(drp);

            //ele.SelectByText("INDIA ");




            // Console.WriteLine("Elements present are"+total);

        }


        /*// driver.Navigate().Back();
         string str = driver.Url;
         string str1 = driver.Title;

        // string str2 = driver.PageSource;

         Console.WriteLine("CurrentURL:"+str+","+"PageTitle:"+ str1);
         // driver.FindElement(By.Id("gh-ac")).SendKeys("Chocolates");
         // driver.FindElement(By.Id("gh-btn")).Click();

         driver.FindElement(By.XPath("(//a[text()='Consultancy'])[1]")).Click();

         driver.Navigate().Back();

         driver.FindElement(By.XPath("(//a[text()='Performance Testing'])[1]")).Click();*/



        //driver.Close();

    }
    }

