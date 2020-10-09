using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;

namespace seleniumAudio
{
    class selenium
    {
        private string Url;
        private IWebDriver Driver;

        public selenium()
        {
              Driver = new EdgeDriver();
            // Driver = new ChromeDriver();
            Driver = new InternetExplorerDriver();
        }

        public selenium(string url)
        {
            // Driver = new ChromeDriver();
             Driver = new EdgeDriver();
          // Driver = new InternetExplorerDriver();
            Driver.Navigate().GoToUrl(url);
        }

        public string NextAudio()
        {
            By audio = By.XPath("//audio[@controls ='controls']");
           By istochnic = By.XPath("//source");
           try
           {
               IWebElement AudioSrc = Driver.FindElement(istochnic);
               string src = AudioSrc.GetAttribute("src");
               return src;
            }
           catch (Exception e)
           {
              // MessageBox.Show("Нет элемента на странице");
               return "";

           }
          
            
        }

        public bool ProblemNet()
        {
          By pn =  By.CssSelector(".typo-tts-group:nth-child(3) .custom-control-label");

          try
          {
              Driver.FindElement(pn).Click();
              By next = By.CssSelector(".btn-primary");
              Thread.Sleep(100);
                Driver.FindElement(next).Click();
              return true;
            }
          catch (Exception e)
          {
              return false;
                //MessageBox.Show("Нет элемента");
          }
           


        }

        public int Kolochestvo()
        {
            By kolich = By.XPath("//div[@class='thematics-counter']/span");
            IWebElement kol = Driver.FindElement(kolich);
            char sl = '/';
            string k = kol.Text;
            string k1 = k.TrimStart(sl);
            int koli = Convert.ToInt32(k1);
            return koli;
        }

        public bool Shum()
        {
            By sh = By.CssSelector(".typo-tts-variant:nth-child(4) > .custom-control-label");

            try
            {
                Driver.FindElement(sh).Click();
                By next = By.CssSelector(".btn-primary");
                Thread.Sleep(100);
                Driver.FindElement(next).Click();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            


        }

        public bool NextBlock()
        {
            By nextb  = By.LinkText("Перейти к следующему блоку");

            try
            {
                Driver.FindElement(nextb).Click();
                return true;
            }
            catch (Exception e)
            {
                return false;
               // MessageBox.Show("Нет элемента");
            }

        }


    }
}
