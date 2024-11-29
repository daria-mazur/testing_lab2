using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace daria_lab2
{
    public abstract class PageBase
    {
        public IWebDriver Driver;

        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement Element(By by)
        {
            return Driver.FindElement(by);
        }

        public void Click(By by)
        {
            Element(by).Click();
        }

        public IReadOnlyCollection<IWebElement> Elements(By by)
        {
            return Driver.FindElements(by);
        }

        public void SendKeys(By by, string text)
        {
            Element(by).SendKeys(text);
        }

        public void ClickButtons(By by)
        {
            foreach (var button in Elements(by))
            {
                button.Click();
                Thread.Sleep(1000);
            }
        }
    }
}
