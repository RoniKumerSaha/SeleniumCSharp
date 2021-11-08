using System.IO;
using ClashRoyelTests.Driver;
using ClashRoyelTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClashRoyelTests
{
    public class CardTests
    {
        static string[] cards = { "Balloon", "Hunter", "Mortar", "Fireball"};
        [SetUp]
        public void BeforeEach()
        {
            DriverSetup.Init();
            DriverSetup.Current.Url = "https://statsroyale.com/";
            new CardsPage(DriverSetup.Current).navigation.gotoPage("Cards");
        }
        [TearDown]
        public void StopDriver(){
            DriverSetup.Current.Close();
        }

        [Test]
        public void CardPageTitleVisibleTest()
        {
            Assert.AreEqual("Clash Royale Cards", new CardsPage(DriverSetup.Current).getPageTitle());
        }

        [Test]
        // provide test data
        [TestCase("Balloon")]
        [TestCase("Witch")]
        [TestCase("Rage")]
        public void CardPageCardDetailsTest1(string card)
        {
            CardsPage cardsPage = new CardsPage(DriverSetup.Current);
            Assert.AreEqual("Clash Royale Cards", cardsPage.getPageTitle());
            cardsPage.selectCardsByName(card);
            Assert.AreEqual(card, cardsPage.getCardName());            
        }

        // category is like tags
        [Test, Category("Cards")]
        // run command for category: dotnet test --filter testcategory=Cards
        // use a single data source
        [TestCaseSource("cards")]
        // run tests parallel
        [Parallelizable(ParallelScope.Children)]
        public void CardPageCardDetailsTest2(string card)
        {
            CardsPage cardsPage = new CardsPage(DriverSetup.Current);
            Assert.AreEqual("Clash Royale Cards", cardsPage.getPageTitle());
            cardsPage.selectCardsByName(card);
            Assert.AreEqual(card, cardsPage.getCardName());            
        }
    }
}