using OpenQA.Selenium;

namespace ClashRoyelTests.Pages
{
    
    public class Navigation
    {
        IWebDriver myDriver;
        public Navigation(IWebDriver driver)
        {
            myDriver = driver;
        }

        public void gotoPage(string navName){
            myDriver.FindElement(By.XPath("(//a[contains(text(),'"+ navName +"')])[1]")).Click();
        }
    }
}