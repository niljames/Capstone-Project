using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Selenium_Testing
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
            element2.SendKeys("nileena@gmail.com");
            Thread.Sleep(2000);
            element3.SendKeys("Nileena@123");
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

            driver.SwitchTo().Window(currentWindowHandle);
            element1 = driver.FindElement(By.Name("Category"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            String categoryWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(categoryWindowHandle);
            element1 = driver.FindElement(By.Name("Liquid Medicines"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            String medicineWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(medicineWindowHandle);
            element1 = driver.FindElement(By.Name("Cefalexina"));
            element1.SendKeys(Keys.Enter);
            Thread.Sleep(3000);

            element2 = driver.FindElement(By.Name("closeCefalexina"));
            element2.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            element3 = driver.FindElement(By.Name("addCefalexina"));
            element3.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            String cartWindowHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(cartWindowHandle);
            element1 = driver.FindElement(By.Id("option"));
            element1.SendKeys(Keys.Enter);
            element2 = driver.FindElement(By.Name("2"));
            element2.Click();
            Thread.Sleep(1000);

            element1 = driver.FindElement(By.Name("Pay"));
            element1.Click();



            driver.SwitchTo().Frame(0);
            Thread.Sleep(1000);



            element1 = driver.FindElement(By.Id("email"));
            element1.SendKeys("nileena@gmail.com");
            Thread.Sleep(1000);
            element1 = driver.FindElement(By.Id("card_number"));
            for (int i = 0; i < 4; i++)
                element1.SendKeys("4242");
            Thread.Sleep(1000);
            element1 = driver.FindElement(By.Id("cc-exp"));
            element1.SendKeys("09");
            element1.SendKeys("24");
            Thread.Sleep(1000);
            element1 = driver.FindElement(By.Id("cc-csc"));
            element1.SendKeys("123");
            Thread.Sleep(1000);
            element1 = driver.FindElement(By.Id("submitButton"));
            element1.Click();

            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
