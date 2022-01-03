using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace WebAutomationBDDFramework.UI.Web
{
    class BusinessUtil
    {
        // this class contain methods for actions performed on WebElement

        public static IWebDriver driver = new ChromeDriver(@"C:\Users\shams.hussain\Downloads\chromedriverf");
        public UtilLocators utilLocators;

        public BusinessUtil() 
        {
            //driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            utilLocators = new UtilLocators();
        }

        public void OpenUrl(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public void Write(By by, String setValues)
        {
            var element = driver.FindElement(by);
            element.SendKeys(setValues);
        }

        public void Click(By by) 
        {
             var element = driver.FindElement(by);
                element.Click();
            
        }

        public void SelectDropDownVal(By by, String setValues) 
        {
            var option = driver.FindElement(by);
                option.Click();
            //driver.FindElement(by).SendKeys(setValues);
                var selectElement = new SelectElement(option);
                selectElement.SelectByValue(setValues);
              
        }

        public bool IsElementVisible(By by)
        {
            if(driver.FindElement(by).Displayed || driver.FindElement(by).Enabled)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string GetElementAttributeText(By by)
        {
            string actualValue = String.Empty;
            Thread.Sleep(10);
            actualValue = driver.FindElement(by).GetAttribute("value");
            return actualValue;
        }

    }
}
