using OpenQA.Selenium;

namespace ClashRoyelTests.Pages
{
    public abstract class BasePage
    {
        IWebDriver driver;
        public Navigation navigation;
        public BasePage(IWebDriver driver)
        {
            navigation = new Navigation(driver);
            this.driver = driver;
        }

        public string getPageTitle(){
            return driver.Title;
        }

    }
}