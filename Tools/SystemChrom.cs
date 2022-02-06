using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;
using System;

namespace Tools

{
    internal class SystemChrom
    {
        IWebDriver driver;
        string usename;
        string password;
       
        public string Usename { get => usename; set => usename = value; }
        public string Password { get => password; set => password = value; }

        public void kq(int if1,int if2)
        {
            try
            {
                
            }
            catch (Exception)
            {
                Program program = new Program();
            }       
        }

        public void login()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, new ChromeOptions());
            driver.Manage().Window.Size = new Size(220, 480);
            driver.Manage().Window.Position = new Point(0, 0);
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                driver.FindElement(By.Id("email")).SendKeys(usename);
                driver.FindElement(By.Id("pass")).SendKeys(password + Keys.Return);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Lỗi kết nối");
            }
        }

        public void AcctionChrom()
        {

           /* Actions actions = new Actions(driver);
            try
            {
                actions.SendKeys(Keys.Escape);
                actions
                    .KeyDown(Keys.Down)
                    .Build()
                    .Perform();
                sleept();
            }
            catch (Exception)
            {

                throw;
            }*/
        }
        public void QuitChrom()
        {
           // driver.Quit();
        }

        private void sleept()
        {
             Random rnd = new Random();
            int trd1 = rnd.Next(500,8000);
            int trd2 = rnd.Next(500,2000);
            int rd = (trd1 + trd2) /2; 
            if (rd  < 500)
            {
                 rd += 500;
            }
            Thread.Sleep(rd);
        }

    }
}
