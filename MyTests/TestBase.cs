using NopCommerce_Demo.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NopCommerce_Demo.Tests
{
    public class TestBase
    {
        string HomeURL = "https://demo.nopcommerce.com/";
        HomePage homeObject;
        protected IWebDriver driver;
        ChromeOptions options;
        public TestBase()
        {
            options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(HomeURL);
            driver.Manage().Window.Maximize();
            homeObject = new HomePage(driver);
        }

        
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
