using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace NopCommerce_Demo.Pages
{
    public class ShoppingCartPage : PageBase
    {
        public ShoppingCartPage(IWebDriver driver) : base(driver)
        { }

        [FindsBy(How = How.Id, Using = "termsofservice")]
        IWebElement AccpetTermsCheckBox;

        [FindsBy(How = How.Id, Using = "checkout")]
        IWebElement CheckoutBtn;

        [FindsBy(How = How.XPath, Using = "//*[@id='billing-buttons-container']/input")]
        IWebElement ContinueBtn;

        [FindsBy(How = How.Id, Using = "BillingNewAddress_CountryId")]
        IWebElement CountryDropDown;

        [FindsBy(How = How.Id, Using = "BillingNewAddress_City")]
        IWebElement CityTxtBox;

        [FindsBy(How = How.Id, Using = "BillingNewAddress_Address1")]
        IWebElement AddressTxtBox;

        [FindsBy(How = How.Id, Using = "BillingNewAddress_ZipPostalCode")]
        IWebElement PostalCodeTxtBox;

        [FindsBy(How = How.Id, Using = "BillingNewAddress_PhoneNumber")]
        IWebElement PhoneTxtBox;

        public void AcceptTermsAndConditions()
        {
            Click_Element(AccpetTermsCheckBox);
        }

        public void UserCheckout()
        {
            Click_Element(CheckoutBtn);
            Thread.Sleep(1000);
        }

        public void AddShippingData()
        {
            select = new SelectElement(CountryDropDown);
            select.SelectByValue("123");
            Thread.Sleep(500);
            Enter_Text(CityTxtBox, "Cairo");
            Enter_Text(AddressTxtBox, "Cairo");
            Enter_Text(PostalCodeTxtBox, "12354");
            Enter_Text(PhoneTxtBox, "123456789");
            Click_Element(ContinueBtn);
        }
    }
}
