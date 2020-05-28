using GiftreteProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace GiftreteProject.PageObjects
{
    class PostItemPage
    {
        IWebDriver driver;
        IWebElement postItem => driver.FindElement(By.XPath(" //text()[contains(.,'Post Item')]/ancestor::a[1]"));
        IWebElement itemName => driver.FindElement(By.Id("title"));
        IWebElement itemDescription => driver.FindElement(By.XPath("//html/body"));
        IWebElement itemCategory => driver.FindElement(By.XPath("//*[@id='categoryone']"));
        public void SelectItemCategory()
        {
           // SelectElement select = new SelectElement(itemCategory);
            //select.SelectByValue("gadget");
            itemCategory.Click();
        }
        public void EnterItemDescription()
        {
            itemDescription.SendKeys("this item is in good condition");
        }
        public void EnterItemName()
        {
            itemName.SendKeys("Ipad");
        }
        public void ClickPostItem()
        {
            
            postItem.Click();
        }
        public PostItemPage()
        {
            driver = Hook.driver;
        }
        public void NavigateToPage()
        {
            driver.Navigate().GoToUrl("Http://www.qa.giftrete.com");
        }
    }
}
