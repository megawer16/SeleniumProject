using NopCommerce_Demo.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace NopCommerce_Demo.Tests
{
    public class UserLoginTest : TestBase
    {
        HomePage homeObject;
        LoginPage loginObject;
        RegisterationPage registerObject;
        public UserLoginTest() : base()
        {
            homeObject = new HomePage(driver);
            loginObject = new LoginPage(driver);
            registerObject = new RegisterationPage(driver);
        }
        [Fact]
        public void LoginTestCase()
        {
            homeObject.UserEnterLoginPage();
            Thread.Sleep(2000);
            loginObject.UserEnterRegisterationPage();
            Thread.Sleep(2000);
            registerObject.NewUserRegisteration("Moha", "Mega", "test0@gmail.com", "12345678");
            Thread.Sleep(2000);
            loginObject.UserNavigateToHomePage();
            Thread.Sleep(500);
            homeObject.Logout();
            Thread.Sleep(500);
            homeObject.UserEnterLoginPage();
            Thread.Sleep(2000);
            loginObject.UserAuthenticatSuccessfully("test0@gmail.com", "12345678");
            Thread.Sleep(500);
            Assert.True(homeObject.LogOutBtn.Displayed);
            TearDown();
        }
    }
}
