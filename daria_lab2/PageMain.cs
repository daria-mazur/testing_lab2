using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace daria_lab2
{
    public class PageMain : PageBase
    {
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");


        private By removeButton = By.XPath("//button[contains(text(), 'Remove')]");
        private By addToCartButton = By.XPath("//button[contains(text(), 'Add to cart')]");

        public PageMain(IWebDriver driver) : base(driver) { }

        public void LoginUser(string username, string password)
        {
            SendKeys(usernameField, username);
            SendKeys(passwordField, password);
            Click(loginButton);
        }

        public void ClickAddToCartButtons()
        {
            ClickButtons(addToCartButton);
        }

        public void ClickRemoveButtons()
        {
            ClickButtons(removeButton);
        }

        public int CheckNumberOfRemoveButtons()
        {
            return Elements(removeButton).Count;
        }
    }
}
