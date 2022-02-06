using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;


namespace Tools

{
    internal class SystemChrom
    {
        int if1;
        int if2;

        public int If1 { get => if1; set => if1 = value; }
        public int If2 { get => if2; set => if2 = value; }

        public void kq(string usename, string password)
        {

            /*var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var driver = new ChromeDriver(driverService, new ChromeOptions());
            driver.Manage().Window.Size = new Size(220, 480);
            driver.Manage().Window.Position = new Point(0, 0);
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.FindElement(By.Id("email")).SendKeys(usename);
            driver.FindElement(By.Id("pass")).SendKeys(password + Keys.Return);*/
            switch (if1)
            {
                case 1:
                    System.Console.WriteLine("1");
                    break;
                case 2:
                    switch (if2)
                    {
                        case 1:
                            System.Console.WriteLine("2");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            System.Console.WriteLine(usename);
            System.Console.WriteLine(password);
        }

    }
}