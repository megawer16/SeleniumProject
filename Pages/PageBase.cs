using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;


namespace NopCommerce_Demo
{
    public class PageBase
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected IJavaScriptExecutor jse;
        protected Actions action;
        protected SelectElement select;

        public PageBase(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            jse = (IJavaScriptExecutor)driver;
            action = new Actions(driver);
            
        }

        public void Click_Element(IWebElement element)
        {
            element.Click();
        }

        public void Enter_Text(IWebElement element, String txt)
        {
            element.SendKeys(txt);
        }
    }
}
