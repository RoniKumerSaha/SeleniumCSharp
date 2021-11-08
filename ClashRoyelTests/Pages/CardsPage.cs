using OpenQA.Selenium;

namespace ClashRoyelTests.Pages
{
    public class CardsPage : BasePage
    {
        IWebElement cardTitle => driver.FindElement(By.XPath("//div[@class='ui__headerMedium card__cardName']"));
        public CardsPage(IWebDriver driver) : base(driver)
        {
            
        }

        public void selectCardsByName(string cardName){
            driver.FindElement(By.XPath("//div[contains(text(),'"+ cardName +"')]/preceding-sibling::a")).Click();
        }

        public string getCardName(){
            return cardTitle.Text;
        }
    }
}