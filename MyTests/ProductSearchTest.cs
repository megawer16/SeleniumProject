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
    public class ProductSearchTest : TestBase
    {
        HomePage homeObject;
        LoginPage loginObject;
        RegisterationPage registerObject;
        public ProductSearchTest() : base()
        {
            homeObject = new HomePage(driver);
            loginObject = new LoginPage(driver);
            registerObject = new RegisterationPage(driver);
        }

        [Fact]
        public void ProductSearchSuccessfully()
        {
            homeObject.UserEnterLoginPage();
            Thread.Sleep(2000);
            loginObject.UserAuthenticatSuccessfully("test0@gmail.com", "12345678");
            Thread.Sleep(500);
            loginObject.UserNavigateToHomePage();
            homeObject.ProductSearch("mac");
            TearDown();
        }
    }
}
