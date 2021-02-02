using NopCommerce_Demo.Pages;
using NopCommerce_Demo.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace NopCommerce_Demo.MyTests
{
    public class AddProducttoCartTest : TestBase
    {
        HomePage homeObject;
        LoginPage loginObject;
        RegisterationPage registerObject;
        ProductPage productObject;

        public AddProducttoCartTest() : base()
        {
            homeObject = new HomePage(driver);
            loginObject = new LoginPage(driver);
            registerObject = new RegisterationPage(driver);
            productObject = new ProductPage(driver);
        }


        [Fact]
        public void UserAddProductToCart()
        {
            homeObject.UserEnterLoginPage();
            Thread.Sleep(2000);
            loginObject.UserAuthenticatSuccessfully("test0@gmail.com", "12345678");
            Thread.Sleep(500);
            homeObject.ProductSearch("mac");
            Thread.Sleep(500);
            productObject.UserAddProductToCart();
        }
    }
}
