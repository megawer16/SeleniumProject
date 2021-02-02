using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NopCommerce_Demo.Pages
{
    public class RegisterationPage : PageBase
    {
        public RegisterationPage(IWebDriver driver): base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "gender-male")]
        IWebElement MaleRadioBtn;

        [FindsBy(How = How.Id, Using = "FirstName")]
        IWebElement FirstNameTxtBox;

        [FindsBy(How = How.Id, Using = "LastName")]
        IWebElement LastNameTxtBox;

        [FindsBy(How = How.Id, Using = "Email")]
        IWebElement EmailTxtBox;

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement PasswordTxtBox;

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        IWebElement ConfPasswordTxtBox;

        [FindsBy(How = How.Id, Using = "register-button")]
        IWebElement RegisterBtn;

        public void NewUserRegisteration(string fname, string lname, string email, string password)
        {
            MaleRadioBtn.Click();
            FirstNameTxtBox.SendKeys(fname);
            LastNameTxtBox.SendKeys(lname);
            EmailTxtBox.SendKeys(email);
            PasswordTxtBox.SendKeys(password);
            ConfPasswordTxtBox.SendKeys(password);
            RegisterBtn.Click();

        }
    }
}
