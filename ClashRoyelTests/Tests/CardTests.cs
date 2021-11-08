using System.IO;
using ClashRoyelTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClashRoyelTests
{
    public class CardTests
    {
        IWebDriver driver;
        [SetUp]
        public void BeforeEach()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../../" + "_drivers"));
            driver.Url = "https://statsroyale.com/";
        }
        [TearDown]
        public void StopDriver(){
            driver.Close();
        }

        [Test]
        public void CardVisibleTest()
        {
            CardsPage cardsPage = new CardsPage(driver);
            cardsPage.navigation.gotoPage("Cards");
            Assert.AreEqual("Clash Royale Cards", cardsPage.getPageTitle());
        }
    }
}