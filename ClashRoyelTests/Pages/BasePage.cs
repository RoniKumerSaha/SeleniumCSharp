using ClashRoyelTests.Driver;
using OpenQA.Selenium;

namespace ClashRoyelTests.Pages
{
    public abstract class BasePage
    {
        public Navigation navigation;
        public BasePage()
        {
            navigation = new Navigation();
        }

        public string getPageTitle(){
            return MyWebDriver.GetTitle();
        }

    }
}