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
        public void kq(string usename, string password,int if1,int if2)
        {
            try
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                var driver = new ChromeDriver(driverService, new ChromeOptions());
                driver.Manage().Window.Size = new Size(220, 480);
                driver.Manage().Window.Position = new Point(0, 0);

                driver.Navigate().GoToUrl("https://www.facebook.com/");
                driver.FindElement(By.Id("email")).SendKeys(usename);
                driver.FindElement(By.Id("pass")).SendKeys(password + Keys.Return);

                Actions actions = new Actions(driver);
                Thread.Sleep(TimeSpan.FromSeconds(1));
                actions.SendKeys(Keys.Escape);

                switch (if1)
                {
                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Running");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("-> Enter để thoát");
                        while (true)
                        {
                           actions
                                .KeyDown(Keys.Down)
                                .Build()
                                .Perform();
                            sleept();
                        }
                    case 2:
                        switch (if2)
                        {
                            case 1:
                                while (true)
                                {
                                    sleept();
                                }

                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Program program = new Program();
            }       
        }
        private void sleept()
        {
            Random rnd = new Random();
            int trd1 = rnd.Next(5100);
            int trd2 = rnd.Next(1200);
            Console.WriteLine((trd1 + trd2) / 2);
            Thread.Sleep((trd1+trd2)/2);
        }

    }
}