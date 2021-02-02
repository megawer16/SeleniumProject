using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NopCommerce_Demo.Pages
{
    public class ProductPage : PageBase
    {
        public ProductPage(IWebDriver driver) : base(driver)
        { 
        }

        [FindsBy(How = How.Id, Using = "add-to-cart-button-4")]
        IWebElement AddToCartBtn;

        [FindsBy(How = How.CssSelector, Using = "span.cart-label")]
        IWebElement ShoppingCartLink;

        public void UserAddProductToCart()
        {
            Click_Element(AddToCartBtn);
        }

        public void OpenShoppingCartPage()
        {
            Click_Element(ShoppingCartLink);
        }
    }
}
