using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSSSR
{
    class CheckAddres
    {
        public IWebDriver driver { get; set; }
        public string H { get; set; }
        TimeSpan timeout = new TimeSpan(00, 00, 30);

        public CheckAddres(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Action()
        {
            driver.Navigate().GoToUrl("http://blog.csssr.ru/qa-engineer/");
            driver.Manage().Window.Maximize();

            var search = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.LinkText("НАХОДИТЬ НЕСОВЕРШЕНСТВА")));
            search.Click();
            var element = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.LinkText("Софт для быстрого создания скриншотов")));
            element.Click();

            H = driver.SwitchTo().Window(driver.WindowHandles.ToList().Last()).Url;
        }
    }
}
