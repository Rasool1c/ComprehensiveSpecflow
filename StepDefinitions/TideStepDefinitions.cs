using System;
using TechTalk.SpecFlow;
using ComprehensiveSpecflow.Pages;
using OpenQA.Selenium;


namespace ComprehensiveSpecflow.StepDefinitions
{
    
    
    [Binding]
    public class TideStepDefinitions
    {
        
        Methods Tide = new Methods();
        [Given(@"I open the tide url")]
        public void GivenIOpenTheTideUrl()
        {
            
            Tide.OpenUrl();
        }

        [When(@"I click on register")]
        public void WhenIClickOnRegister()
        {
            Tide.Register();
        }

        [When(@"click on regiser")]
        public void WhenClickOnRegiser()
        {
            Tide.signup();
        }

        [When(@"enter valid first name, email and password")]
        public void WhenEnterValidFirstNameEmailAndPassword()
        {
            Tide.SignupDetails();
        }

        [Then(@"I click in create account")]
        public void ThenIClickInCreateAccount()
        {
            Tide.SignupClick();
            Tide.scr("signup");
        }
        [Given(@"I open the tide url(.*)")]
        public void GivenIOpenTheTideUrl(int p0)
        {
            Tide.OpenUrl();
        }

        [When(@"I click on Register(.*)")]
        public void WhenIClickOnRegister(int p0)
        {
            Tide.Register();
        }

        [When(@"click on signup")]
        public void WhenClickOnSignup()
        {
            Tide.signup();
        }

        [When(@"enter valid first name, email and invalid password")]
        public void WhenEnterValidFirstNameEmailAndInvalidPassword()
        {
            Tide.SignupInvalidPass();
        }

        [Then(@"take error sceenchot")]
        public void ThenTakeErrorSceenchot()
        {
            Tide.scr("signup invalid pass");
        }
        [Given(@"I open tide url")]
        public void GivenIOpenTideUrl()
        {
            Tide.OpenUrl();
        }

        [When(@"I click on the Register")]
        public void WhenIClickOnTheRegister()
        {
            Tide.Register();
        }

        [When(@"click on signup(.*)")]
        public void WhenClickOnSignup(int p0)
        {
            Tide.signup();
        }

        [When(@"enter valid first name, email and invalid/short password")]
        public void WhenEnterValidFirstNameEmailAndInvalidShortPassword()
        {
            Tide.SignUpClickInvalid();
        }

        [Then(@"i cannot able to clck on signup")]
        public void ThenICannotAbleToClckOnSignup()
        {
            Tide.scr("sinupclickinvalid");
        }
        [Given(@"I opened the tide url")]
        public void GivenIOpenedTheTideUrl()
        {
            Tide.OpenUrl();
        }

        [When(@"I click on the registers")]
        public void WhenIClickOnTheRegisters()
        {
            Tide.Register();
        }


        [When(@"click on sign up")]
        public void WhenClickOnSignUp()
        {
            Tide.signup();
        }

        [When(@"enter valid email and password")]
        public void WhenEnterValidEmailAndPassword()
        {
            Tide.Login();
        }

        [Then(@"I click in login")]
        public void ThenIClickInLogin()
        {
            Tide.LoginClick();
            Thread.Sleep(2000);
            Tide.scr("Login");
        }
        [Given(@"I opened  valid tide url")]
        public void GivenIOpenedValidTideUrl()
        {
            Tide.OpenUrl();
        }

        [When(@"I click on the register now")]
        public void WhenIClickOnTheRegisterNow()
        {
            Tide.Register();
        }

        [When(@"i clicked on sign up")]
        public void WhenIClickedOnSignUp()
        {
            Tide.signup();
        }

        [When(@"i enter valid email")]
        public void WhenIEnterValidEmail()
        {
            Tide.ForgotPass();
        }

        [Then(@"I click on submit")]
        public void ThenIClickOnSubmit()
        {
            Tide.ForgotPassClick();
        }

        [Then(@"reset mail sent")]
        public void ThenResetMailSent()
        {
            
            Tide.scr("forgotpassword");
        }
        [Given(@"I opened  homepage of tide")]
        public void GivenIOpenedHomepageOfTide()
        {
            Tide.OpenUrl();
        }

        [When(@"I entered valid search text")]
        public void WhenIEnteredValidSearchText()
        {
            Tide.Search();
        }

        [Then(@"i clicked on Seach icon")]
        public void ThenIClickedOnSeachIcon()
        {
            Tide.SearchClick();
            Tide.scr("Search");
        }
        [Given(@"I opened   tide homepage")]
        public void GivenIOpenedTideHomepage()
        {
            Tide.OpenUrl();
        }

        [When(@"I clicked on contact us")]
        public void WhenIClickedOnContactUs()
        {
            Tide.Contactus();
        }

        [Then(@"i used chat option")]
        public void ThenIUsedChatOption()
        {
            Tide.scr("chat");
            Tide.Chat();
        }
        [Given(@"I opened   valid tide homepage")]
        public void GivenIOpenedValidTideHomepage()
        {
            Tide.OpenUrl();
        }

        [When(@"I clicked on shop products")]
        public void WhenIClickedOnShopProducts()
        {
            Tide.Shop();
        }

        [Then(@"i sorted the results")]
        public void ThenISortedTheResults()
        {
            Tide.Sort();
            Tide.scr("shop products");
        }
        [Given(@"I opened   correct tide url")]
        public void GivenIOpenedCorrectTideUrl()
        {
            Tide.OpenUrl();
        }

        [When(@"I clicked on languages")]
        public void WhenIClickedOnLanguages()
        {
            Tide.Language();
        }

        [Then(@"i selected different language")]
        public void ThenISelectedDifferentLanguage()
        {
            Tide.LanguageSelecion();
            Tide.scr("language");
        }
        [Given(@"I opened the correct tide url")]
        public void GivenIOpenedTheCorrectTideUrl()
        {
            Tide.OpenUrl();
        }

        [When(@"I clicked on how to wash clothes")]
        public void WhenIClickedOnHowToWashClothes()
        {
            Tide.HowToWash();
        }

        [Then(@"verify the text displayed")]
        public void ThenVerifyTheTextDisplayed()
        {
            Tide.VerifyHowToWashText();
            Tide.scr("how to wash");
        }
       
    }
}
