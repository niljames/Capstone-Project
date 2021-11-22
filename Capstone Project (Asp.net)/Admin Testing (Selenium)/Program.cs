using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Admin_Testing__Selenium_
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = null;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver = new ChromeDriver(@"C:\DoverCorp");
            Thread.Sleep(1000);

            string url = "http://localhost:4200/home";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);


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
            element2.SendKeys("Cors");
            Thread.Sleep(2000);

            element3 = driver.FindElement(By.Name("update"));
            element3.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            driver.Close();

            /*driver.SwitchTo().Window(AdminUsersWindowHandle);
             element1 = driver.FindElement(By.Id("addUser"));
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
            String AddUserWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(AddUserWindowHandle);
            element1 = driver.FindElement(By.Name("deleteRoald"));
            element1.Click();
            driver.SwitchTo().Alert().Accept();


            element1 = driver.FindElement(By.Name("back"));
            element1.Click();

            driver.SwitchTo().Window(AdminMainWindowHandle);
            element1 = driver.FindElement(By.Name("Category"));
            element1.Click();
            Thread.Sleep(2000);*/


        }
    }
}
