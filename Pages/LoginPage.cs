using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace NopCommerce_Demo.Pages
{
    public class LoginPage : PageBase
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "Email")]
        IWebElement EmailTxtBox;

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement PasswordTxtBox;

        [FindsBy(How = How.CssSelector, Using = "input.button-1.login-button")]
        IWebElement LoginBtn;

        [FindsBy(How = How.CssSelector, Using = "input.button-1.register-button")]
        IWebElement RegisterBtn;

        [FindsBy(How = How.XPath, Using = "//*[@alt='nopCommerce demo store']")]
        IWebElement HomePageBtn;

        public void UserAuthenticatSuccessfully(string email, string password)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("Email")));
            EmailTxtBox.SendKeys(email); 
            Console.WriteLine(email);
            PasswordTxtBox.SendKeys(password);
            LoginBtn.Click();
        }

        public void UserEnterRegisterationPage()
        {
            RegisterBtn.Click();
        }

        public void UserNavigateToHomePage()
        {
            HomePageBtn.Click();
        }

    }
}
