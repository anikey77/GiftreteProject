using GiftreteProject.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteProject.PageObjects
{
   
    class GiftretePage
    {
        IWebDriver driver;

        IWebElement errorMessage => driver.FindElement(By.CssSelector("#dng_msg_t"));
        IWebElement myCommunities => driver.FindElement(By.CssSelector("#content :nth-child(2)"));
        
        IWebElement communityOfInterest => driver.FindElement(By.XPath("//*[@id='2438']/div[1]/img"));
        IWebElement publicCommunityOfInterest => driver.FindElement(By.XPath(".//*[@id='2505']/div[1]/img"));

        IWebElement clickPublish => driver.FindElement(By.XPath(""));
        IWebElement discussion => driver.FindElement(By.CssSelector("#content ul > a:nth-child(6)"));
        IWebElement createDiscussion => driver.FindElement(By.CssSelector("#toggle-create-post > a"));
        IWebElement enterATitle => driver.FindElement(By.Id("subject"));
        IWebElement message => driver.FindElement(By.Id("description"));
        IWebElement discussionImage => driver.FindElement(By.Id("files"));
        IWebElement publish => driver.FindElement(By.Id("btn_create"));
        IWebElement community => driver.FindElement(By.XPath("(//span[@class='mm-text'])[2]"));
        IWebElement create => driver.FindElement(By.CssSelector("#content > div > div > div > div > div > ul > a:nth-child(1)"));
        IWebElement CommunityName => driver.FindElement(By.XPath("//*[@id='name']"));
        IWebElement communityType => driver.FindElement(By.CssSelector(" label:nth-child(4)"));
        IWebElement communityHandle => driver.FindElement(By.Id("cleanname"));
        IWebElement communityDescription => driver.FindElement(By.CssSelector("#cke_1_contents > iframe"));
        IWebElement selectommunityCategory => driver.FindElement(By.Id("group_type_id"));
        IWebElement location => driver.FindElement(By.Id("autocomplete"));
        IWebElement communityImage => driver.FindElement(By.Id("files"));

        IWebElement createCommunity => driver.FindElement(By.Id("btn_create"));
        IWebElement signInButton => driver.FindElement(By.CssSelector(" a.sb-btn2"));
        IWebElement emailAddress => driver.FindElement(By.Id("user_email"));
        IWebElement passwordText => driver.FindElement(By.Id("user_password"));
        IWebElement signIn => driver.FindElement(By.Id("btn_signin"));
        

        

        IWebElement createAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement firstName => driver.FindElement(By.Id("first_name"));
        IWebElement lastname => driver.FindElement(By.Id("last_name"));
        IWebElement email => driver.FindElement(By.Id("email"));
   
        IWebElement mobileNumber => driver.FindElement(By.Id("mobile"));
        IWebElement password => driver.FindElement(By.Id("password"));
        IWebElement confirmPassword => driver.FindElement(By.Id("confirm_password"));
        IWebElement register => driver.FindElement(By.Id("btn_register"));
        //ebElement ErrorMessage => driver.FindElement(By.Id("dng_msg_t"));
        
        public void ClickPublicCommunityOfInterest()
        {
            communityOfInterest.Click();          
        }
        public void ClickOnPublish()
        {
            clickPublish.Click();
        }
        public bool CheckErrorMessageIsDisplayed()
        {
            return errorMessage.Displayed;
        }
        public void ClickPublish()
        {
            publish.Click();
        }
        public void UploadDiscussionImage()
        {
            discussionImage.SendKeys("C:\\Users\\abc\\Documents\\art work");
            
        }
        public void EnterMessage()
        {
            message.SendKeys("this platfom is to discuss about testing assignment");
        }
        public void EnterATitle()
        {
            enterATitle.SendKeys("manualTesting");
        }
        public void ClickCreateDisscussion()
        {
            createDiscussion.Click();
        }
        public void ClickDiscussion()
        {
            discussion.Click();
        }
        public void ClickCommmunityOfInterest()
        {
            communityOfInterest.Click();
        }
        public void ClickMyCommunities()
        {
            myCommunities.Click();
        }
        public void ClickCreateCommunityButton()
        {
            createCommunity.Click();
        }
        public void UploadCommunityImage()
        {
            communityImage.SendKeys("C:\\Users\\abc\\source\\repos\\GiftreteProject\\GiftreteProject\\TextFile\\Images.txt");

        }
        public void EnterLocation()
        {
            location.SendKeys("London");
        }
        public void SelectEducationFromCommunityCategory()
        {
            //SelectElement select = new SelectElement(selectCommunityCategory);
            //select.SelectByValue("education");
            selectommunityCategory.Click();
        }

        public void EnterCommunityDescription()
        {
            communityDescription.SendKeys("The community is about testing team");
        }
        public void EnterCommunityHandle()
        {
            communityHandle.SendKeys("http://giftrete.com/testingteam");
        }
        public void ClickCommunityType()
        {
            communityType.Click();
        }

        
        public void EnterCommunityName()
        {
            CommunityName.SendKeys("testingTeam");
            
            
        }
        public void ClickCreateCommunity()
        {
            create.Click();
        }
        public void ClickCommunity()
        {
           community.Click();
        }

       
        public void ClickSignIn()
        {
            signIn.Click();
        }
        public void EnterPasswordText()
        {
            passwordText.SendKeys("korede");
        }
        public void EnterEmailAddress()
        {
            emailAddress.SendKeys("kudidebay@yahoo.com");
        }
        public void ClickSignInButton()
        {
            signInButton.Click();
        }

       //ublic bool ErrorMessageIsDiplayed()
       //
           //eturn ErrorMessage.Displayed;
       //
        public void ClickRegisterButton()
        {
            register.Click();
        }
        
        public void EnterConfirmPassword()
        {
            confirmPassword.SendKeys("korede06");
        }

        public void EnterPassword()
        {
            password.SendKeys("korede06");
        }
        public void EnterMobileNumber()
        {
            mobileNumber.SendKeys("07578446563");
        }
       
        public void EnterEmail()
        {
            email.SendKeys("samuelsina2002@yahoo.com");
        }
        public void EnterLastName()
        {
            lastname.SendKeys("Adebayo");
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("Kudy");
        }
        public void ClickCreateAccount()
        {
            createAccount.Click();
        }
        public GiftretePage()
        {
            driver = Hook.driver;
        }
        public void NavigateToPage()
        {
            driver.Navigate().GoToUrl("Http://www.qa.giftrete.com");
            //driver.Navigate().GoToUrl("https://www.qa.giftrete.com/account/profile");
            
            
        }
            



    }
}
