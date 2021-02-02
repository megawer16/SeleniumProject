using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace NopCommerce_Demo.Pages
{
    public class HomePage : PageBase
    {
        
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.LinkText, Using = "Log in")]
        IWebElement LoginBtn;

        [FindsBy(How = How.LinkText, Using = "Log out")]
        public IWebElement LogOutBtn;

        [FindsBy(How = How.Id, Using = "small-searchterms")]
        IWebElement SearchTxtBox;

        [FindsBy(How = How.Id, Using = "//form[@id='small-search-box-form']/following-sibling::ul/li/a/span")]
        IWebElement SearchedItem;

        public void UserEnterLoginPage()
        {
            LoginBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public void ProductSearch(string productname)
        {
            Enter_Text(SearchTxtBox, productname);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//form[@id='small-search-box-form']/following-sibling::ul/li/a/span")).Click();
        }

        public void Logout()
        {
            LogOutBtn.Click();
        }
        
    }
}
