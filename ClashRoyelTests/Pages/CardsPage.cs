using ClashRoyelTests.Driver;
using OpenQA.Selenium;

namespace ClashRoyelTests.Pages
{
    public class CardsPage : BasePage
    {
        IWebElement cardTitle => MyWebDriver.FindElementBy(By.XPath("//div[@class='ui__headerMedium card__cardName']"));

        public void selectCardsByName(string cardName){
            MyWebDriver.FindElementBy(By.XPath("//div[contains(text(),'"+ cardName +"')]/preceding-sibling::a")).Click();
        }

        public string getCardName(){
            return cardTitle.Text;
        }
    }
}