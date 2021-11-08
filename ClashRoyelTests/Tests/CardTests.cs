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
        CardsPage cardsPage;
        [SetUp]
        public void BeforeEach()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../../" + "_drivers"));
            driver.Url = "https://statsroyale.com/";
            cardsPage = new CardsPage(driver);
            cardsPage.navigation.gotoPage("Cards");
        }
        [TearDown]
        public void StopDriver(){
            driver.Close();
        }

        [Test]
        public void CardPageTitleVisibleTest()
        {
            Assert.AreEqual("Clash Royale Cards", cardsPage.getPageTitle());
        }
        [Test]
        public void CardPageCardDetailsTest()
        {
            Assert.AreEqual("Clash Royale Cards", cardsPage.getPageTitle());
            cardsPage.selectCardsByName("Balloon");
            Assert.AreEqual("Balloon", cardsPage.getCardName());
        }
    }
}