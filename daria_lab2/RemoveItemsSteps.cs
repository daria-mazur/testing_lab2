using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace daria_lab2
{
    [Binding]
    public class RemoveItemsSteps
    {
        private IWebDriver driver;
        private PageMain pageMain;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            pageMain = new PageMain(driver);
        }

        [Given(@"I am logged into the website")]
        public void GivenIAmLoggedIntoTheWebsite()
        {
            const string USERNAME = "problem_user";
            const string PASSWORD = "secret_sauce";
            pageMain.LoginUser(USERNAME, PASSWORD);
        }

        [When(@"I add items to the cart")]
        public void WhenIAddItemsToTheCart()
        {
            pageMain.ClickAddToCartButtons();
        }

        [When(@"I remove all items from the cart")]
        public void WhenIRemoveAllItemsFromTheCart()
        {
            pageMain.ClickRemoveButtons();
        }

        [Then(@"the cart should be empty")]
        public void ThenTheCartShouldBeEmpty()
        {
            Assert.That(pageMain.CheckNumberOfRemoveButtons(), Is.EqualTo(0));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestRemoveItemsFromCart()
        {
            GivenIAmLoggedIntoTheWebsite();
            WhenIAddItemsToTheCart();
            WhenIRemoveAllItemsFromTheCart();
            ThenTheCartShouldBeEmpty();
        }
    }
}
