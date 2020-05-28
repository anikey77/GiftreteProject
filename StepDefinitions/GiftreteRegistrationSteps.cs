using GiftreteProject.PageObjects;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GiftreteProject.StepDefinitions
{
    [Binding]
    public class GiftreteRegistrationSteps
    {
        GiftretePage giftretePage;
        public GiftreteRegistrationSteps()
        {
             giftretePage = new GiftretePage();

        }

        [When(@"I click on the public community of interest")]
        public void WhenIClickOnThePublicCommunityOfInterest()
        {
            giftretePage.ClickPublicCommunityOfInterest();
        }

        [When(@"I click on publish")]
        public void WhenIClickOnPublish()
        {
            giftretePage.ClickOnPublish();
        }


        //[When(@"I did not upload discussion image")]
        //public void WhenIDidNotUploadDiscussionImage()
        //{
        // giftretePage.CheckErrorMessageIsDisplayed();
        //}

        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string p0)
        { 

        Assert.IsTrue(giftretePage.CheckErrorMessageIsDisplayed());
        }
        


        [When(@"I click my communities")]
        public void WhenIClickMyCommunities()
        {
            Thread.Sleep(5000);
            giftretePage.ClickMyCommunities();
        }
        [When(@"I click on the  community of interest")]
        public void WhenIClickOnTheCommunityOfInterest()
        {
            giftretePage.ClickCommmunityOfInterest();
        }
        [When(@"I click on discussion")]
        public void WhenIClickOnDiscussion()
        {
            giftretePage.ClickDiscussion();
        }
        [When(@"I click on create discussion")]
        public void WhenIClickOnCreateDiscussion()
        {
            giftretePage.ClickCreateDisscussion();
        }
        [When(@"I enter a title")]
        public void WhenIEnterATitle()
        {
            giftretePage.EnterATitle();
        }
        [When(@"I write a message")]
        public void WhenIWriteAMessage()
        {
            giftretePage.EnterMessage();
        }
        [When(@"I upload discussion image")]
        public void WhenIUploadDiscussionImage()
        {
            giftretePage.UploadDiscussionImage();
        }
        [Then(@"I click on publish")]
        public void ThenIClickOnPublish()
        {
            giftretePage.ClickPublish();
        }
        [When(@"I click on community")]
        public void WhenIClickOnCommunity()
        

        {
            Thread.Sleep(3000);
            giftretePage.ClickCommunity();
        }

        [When(@"I click on  Create")]
        public void WhenIClickOnCreate()
        {
            Thread.Sleep(5000);
            giftretePage.ClickCreateCommunity();
        }

        [When(@"I enter community name")]
        public void WhenIEnterCommunityName()
        {

            giftretePage.EnterCommunityName();
        }

        [When(@"I click on community type")]
        public void WhenIClickOnCommunityType()
        {
            giftretePage.ClickCommunityType();

        }
        [When(@"I enter comunity Handle")]
        public void WhenIEnterComunityHandle()
        {
            giftretePage.EnterCommunityHandle();
        }

        [When(@"Ienter community description")]
        public void WhenIenterCommunityDescription()
        {
            giftretePage.EnterCommunityDescription();
        }

        [When(@"I select community category")]
        public void WhenISelectCommunityCategory()
        {
            giftretePage.SelectEducationFromCommunityCategory();
        }

        [When(@"I enter  location")]
        public void WhenIEnterLocation()
        {
            giftretePage.EnterLocation();
        }



        [When(@"i enter community website")]
        public void WhenIEnterCommunityWebsite()
        {
            //ScenarioContext.Current.Pending();
        }


        [When(@"I Upload Community Image")]
        public void WhenIUploadCommunityImage()
        {
            Thread.Sleep(5000);
            giftretePage.UploadCommunityImage();

        }


        [When(@"I click create community")]
        public void WhenIClickCreateCommunity()
        {
            giftretePage.ClickCreateCommunityButton();
        }


        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            giftretePage.ClickSignInButton();
        }
         [When(@"enter valid email Addresss")]
        public void WhenEnterValidEmailAddresss()
        {
            giftretePage.EnterEmailAddress();
        }
        [When(@"I enter Valid password")]
        public void WhenIEnterValidPassword()
        {
            giftretePage.EnterPasswordText();
        }
        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            giftretePage.ClickSignIn();
        }
        

        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            giftretePage.NavigateToPage();
        }
        
        [When(@"I click on Create account")]
        public void WhenIClickOnCreateAccount()
        {
            giftretePage.ClickCreateAccount();
        }
        
        [When(@"I Fill in the registration form")]
        public void WhenIFillInTheRegistrationForm()
        {
            giftretePage.EnterFirstName();
            giftretePage.EnterLastName();
            giftretePage.EnterEmail();
            giftretePage.EnterMobileNumber();
            giftretePage.EnterPassword();
            giftretePage.EnterConfirmPassword();
            
        }
        [Then(@"I click register")]
        public void ThenIClickRegister()
        {
            giftretePage.ClickRegisterButton();
        }
      //[Then(@"the error message""(.*)""")]
      //public void ThenTheErrorMessage(string p0)
     // {
      //    ScenarioContext.Current.Pending();
      //}


        /// [Then(@"Iam registered\.")] 

        //public void ThenIamRegistered_()
        //{
        //ScenarioContext.Current.Pending();
        //}
    }
}
