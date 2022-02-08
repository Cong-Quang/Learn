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
        bool QuitCH = true;
        int Cif1;
        int Cif2;

        public string Usename { get => usename; set => usename = value; }
        public string Password { get => password; set => password = value; }
        public int Cif11 { get => Cif1; set => Cif1 = value; }
        public int Cif21 { get => Cif2; set => Cif2 = value; }
        public bool QuitCH1 { get => QuitCH; set => QuitCH = value; }
        // driver.find_element_by_xpath("//div[@aria-label='Any time']
        //input[@class ='']
        public void login()
        {
            //open chrome
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, new ChromeOptions());
            //set size and set position
            driver.Manage().Window.Size = new Size(220, 800);
            try
            {   //login
                driver.Navigate().GoToUrl("https://www.facebook.com/");
                driver.FindElement(By.Id("email")).SendKeys(usename);
                driver.FindElement(By.Id("pass")).SendKeys(password + Keys.Return);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Lỗi kết nối tới Facebook");
            }
        }
        public void AcctionChrom()
        {
           Actions actions = new Actions(driver);
            try
            {
                switch (Cif1)
                {
                    /*
                     * if1 |     |
                     *     | if2 |     |
                     *     |     | if3 |
                     *           |     |
                     *                 |
                     */
                    case 1:
                        if (Cif1 == 1)
                        {
                            actions.SendKeys(Keys.Escape);
                            do
                            {
                                try
                                {
                                    actions
                                    .KeyDown(Keys.Down)
                                    .Build()
                                    .Perform();
                                    RND(1);
                                    RND(2);
                                }
                                catch (Exception)
                                {
                                    QuitCH = true;
                                    QuitChrom();
                                }
                            } while (QuitCH == true);
                        }
                        break;
                    //////////////////////////////////////////////////
                    case 2: // updateing 
                        switch (Cif2)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            default:
                                break;
                        }
                        break;
                    /////////////////////////////////////////////////
                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập đúng");
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
            }
        }
        public void QuitChrom() // check close
        {
            //announcement
            if (QuitCH == false)
            {
                driver.Close();
            }
        }
        private void RND(int tSl) // random
        {
            Random rnd = new Random();
            if (tSl == 1)
            {
                int trd1 = rnd.Next(500, 8000);
                int trd2 = rnd.Next(500, 2000);
                int rd = (trd1 + trd2) / 2;
                if (rd < 500)
                {
                    rd += 500;
                }
                Thread.Sleep(rd);
            }
            if (tSl == 2)
            {
                int trd1 = rnd.Next(1, 4);
                var a = driver.FindElement(By.XPath("//div[@aria-label='Thích']"));
                if (a != null)
                {
                    if (trd1 == 1)
                    {
                        a.Click();
                    }
                }
                a.Clear();
            }
        }
    }
}
