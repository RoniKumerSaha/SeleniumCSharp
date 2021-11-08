using ClashRoyelTests.Driver;
using OpenQA.Selenium;

namespace ClashRoyelTests.Pages
{
    
    public class Navigation
    {
        public void gotoPage(string navName){
            MyWebDriver.FindElementBy(By.XPath("(//a[contains(text(),'"+ navName +"')])[1]")).Click();
        }
    }
}