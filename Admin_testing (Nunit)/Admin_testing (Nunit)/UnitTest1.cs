using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Admin_testing__Nunit_
{
    public class Tests
    {

        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver(@"C:\DoverCorp");
            Thread.Sleep(1000);

            string url = "http://localhost:4200/home";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

        }

        //For updating the users from the admin dashboard.
        [Test]
        public void Test1()
        {
            String currentWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(currentWindowHandle);
            IWebElement element1 = driver.FindElement(By.Id("login"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            String LoginWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(LoginWindowHandle);
            Thread.Sleep(2000);
            IWebElement element2 = driver.FindElement(By.Id("email"));
            IWebElement element3 = driver.FindElement(By.Id("password"));
            element1 = driver.FindElement(By.Name("login"));
            element2.SendKeys("admin@gmail.com");
            Thread.Sleep(2000);
            element3.SendKeys("admin");
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            String AdminMainWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AdminMainWindowHandle);
            element1 = driver.FindElement(By.Name("Users"));
            element1.Click();
            Thread.Sleep(2000);


            String AdminUsersWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AdminUsersWindowHandle);
            element1 = driver.FindElement(By.Name("editCorelia"));
            element1.Click();
            Thread.Sleep(2000);

            String EditUserWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(EditUserWindowHandle);
            Thread.Sleep(2000);
            element2 = driver.FindElement(By.Id("exampleInputPassword"));
            element2.Clear();
            element2.SendKeys("Cors@123");
            Thread.Sleep(2000);

            element3 = driver.FindElement(By.Name("update"));
            element3.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Close();
        }

        //For adding the new users from the admin dashboard.
        [Test]
        public void Test2()
        {
            String currentWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(currentWindowHandle);
            IWebElement element1 = driver.FindElement(By.Id("login"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            String LoginWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(LoginWindowHandle);
            Thread.Sleep(2000);
            IWebElement element2 = driver.FindElement(By.Id("email"));
            IWebElement element3 = driver.FindElement(By.Id("password"));
            element1 = driver.FindElement(By.Name("login"));
            element2.SendKeys("admin@gmail.com");
            Thread.Sleep(2000);
            element3.SendKeys("admin");
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            String AdminMainWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AdminMainWindowHandle);
            element1 = driver.FindElement(By.Name("Users"));
            element1.Click();
            Thread.Sleep(2000);


            String AdminUsersWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AdminUsersWindowHandle);
            element1 = driver.FindElement(By.Name("addUser"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            String AddUserWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AddUserWindowHandle);
            element2 = driver.FindElement(By.Id("exampleInputName"));
            element2.SendKeys("Roald");
            Thread.Sleep(2000);
            element2 = driver.FindElement(By.Id("exampleInputEmail"));
            element2.Clear();
            element2.SendKeys("RoaldD@gmail.com");
            Thread.Sleep(2000);
            element2 = driver.FindElement(By.Id("exampleInputPassword"));
            element2.Clear();
            element2.SendKeys("Roald@Dahl");
            Thread.Sleep(2000);
            element3 = driver.FindElement(By.Name("add"));
            element3.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Close();
        }

        //For deleting the users from the admin dashboard.
        [Test]
        public void Test3()
        {
            String currentWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(currentWindowHandle);
            IWebElement element1 = driver.FindElement(By.Id("login"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            String LoginWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(LoginWindowHandle);
            Thread.Sleep(2000);
            IWebElement element2 = driver.FindElement(By.Id("email"));
            IWebElement element3 = driver.FindElement(By.Id("password"));
            element1 = driver.FindElement(By.Name("login"));
            element2.SendKeys("admin@gmail.com");
            Thread.Sleep(2000);
            element3.SendKeys("admin");
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            String AdminMainWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AdminMainWindowHandle);
            element1 = driver.FindElement(By.Name("Users"));
            element1.Click();
            Thread.Sleep(2000);


            String AddUserWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AddUserWindowHandle);
            element1 = driver.FindElement(By.Name("deleteRoald"));
            element1.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}