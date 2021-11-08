using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClashRoyelTests.Driver
{
    public static class MyWebDriver
    {
        [ThreadStatic]
        private static IWebDriver _driver;

        public static void Init()
        {
            _driver = new ChromeDriver(Path.GetFullPath(@"../../../../../" + "_drivers"));
            _driver.Url = "https://statsroyale.com/";
        }
        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null.");

        public static IWebElement FindElementBy(By by){
            return Current.FindElement(by);
        }

        public static IList<IWebElement> FindElementsBy(By by){
            return Current.FindElements(by);
        }
        public static string GetTitle(){
            return Current.Title;
        }
    }
}