using GiftreteProject.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GiftreteProject.StepDefinitions
{
    [Binding]
    public class PostItemSteps
    {
        PostItemPage postItemPage;
       public PostItemSteps()
       {
            postItemPage = new PostItemPage();
       }

    
    
    
        [When(@"I click on Post item")]
        public void WhenIClickOnPostItem()
        {
            Thread.Sleep(5000);
            postItemPage.ClickPostItem();
        }
        
        [When(@"I enter item name")]
        public void WhenIEnterItemName()
        {
            postItemPage.EnterItemName();
        }
        
        [When(@"i enter item Description")]
        public void WhenIEnterItemDescription()
        {
            Thread.Sleep(5000);
            postItemPage.EnterItemDescription();
        }

        [When(@"I select item Category")]
        public void WhenISelectItemCategory()

        {
            
            

            postItemPage.SelectItemCategory();
        }
        
        [When(@"I select Item type")]
        public void WhenISelectItemType()
        {
     
        }
        
        [When(@"I enter Item weight")]
        public void WhenIEnterItemWeight()
        {
           //cenarioContext.Current.Pending();
        }
        
        [When(@"I upload item image")]
        public void WhenIUploadItemImage()
        {
           //cenarioContext.Current.Pending();
        }
        
        [Then(@"i click add item")]
        public void ThenIClickAddItem()
        {
          //ScenarioContext.Current.Pending();
        }
    }
}
