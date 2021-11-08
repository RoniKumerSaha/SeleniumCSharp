using ClashRoyelTests.Driver;
using ClashRoyelTests.Pages;
using NUnit.Framework;

namespace ClashRoyelTests
{
    public class CardTests
    {
        static string[] cards = { "Balloon", "Hunter"};
        [SetUp]
        public void BeforeEach()
        {
            MyWebDriver.Init();
            Page.Init();
            Page.CardsPage.navigation.gotoPage("Cards");
        }
        [TearDown]
        public void StopDriver(){
            MyWebDriver.Current.Close();
        }

        [Test]
        public void CardPageTitleVisibleTest()
        {
            Assert.AreEqual("Clash Royale Cards", Page.CardsPage.getPageTitle());
        }

        [Test]
        // provide test data
        [TestCase("Balloon")]
        [TestCase("Witch")]
        [TestCase("Rage")]
        public void CardPageCardDetailsTest1(string card)
        {
            Assert.AreEqual("Clash Royale Cards", Page.CardsPage.getPageTitle());
            Page.CardsPage.selectCardsByName(card);
            Assert.AreEqual(card, Page.CardsPage.getCardName());            
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
            Assert.AreEqual("Clash Royale Cards", Page.CardsPage.getPageTitle());
            Page.CardsPage.selectCardsByName(card);
            Assert.AreEqual(card, Page.CardsPage.getCardName());            
        }
    }
}