using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using ComprehensiveSpecflow.Hooks;
using AventStack.ExtentReports.Model;
using Serilog;
using Log = Serilog.Log;
using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NPOI.XSSF.UserModel;

namespace ComprehensiveSpecflow.Pages
{
    public class Methods
    {
        public static ExtentReports extents;
        ExcelRead ExlOp = new ExcelRead();
        public void OpenUrl()
        {
            TideHooks.driver.Navigate().GoToUrl("https://tide.com/en-us");
            TideHooks.driver.Manage().Window.Maximize();
            Log.Information("tide web application opened");


        }
        public void Register()
        {
            
            Thread.Sleep(7000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Thread.Sleep(1000);
            TideHooks.driver.FindElement(By.XPath("//*[@href='/en-us/sign-in']")).Click();
            
        }
        public void signup()
        {
            Thread.Sleep(3000);
            TideHooks.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();
            Log.Information("Click on Signup");
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = TideHooks.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                TideHooks.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(5000);
        }
        public void SignupDetails()
        {
            Log.Information("opened signup page");
            TideHooks.driver.FindElement(By.XPath("//*[@aria-label='text']")).SendKeys(ExlOp.ReadExcelData(0,1));
            Log.Debug("Entering first name");
            TideHooks.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(ExlOp.ReadExcelData(1,1));
            Log.Debug("Entering email");
            TideHooks.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys(ExlOp.ReadExcelData(2,1));
            Log.Warning("Enter password with given requirements");            
            Log.Debug("Entering password");
            
        }
        public void SignupClick()
        {
            TideHooks.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            Log.Information("signup completed successfully");
        }
        public void scr(string name)
        {

            ((ITakesScreenshot)TideHooks.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may214\source\repos\ComprehensiveSpecflow\Screenshot" + name + ".png");
        }
        public void SignupInvalidPass()
        {
            Thread.Sleep(3000);
            TideHooks.driver.FindElement(By.XPath("//*[@aria-label='text']")).SendKeys(ExlOp.ReadExcelData(0,1));
            Log.Debug("Entering first name");
            TideHooks.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(ExlOp.ReadExcelData(1,1));
            Log.Debug("Entering email");
            TideHooks.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Abcd");
            Log.Warning("Enter password with given requirements");
            Log.Debug("Entering invalid password");
            Log.Error("Invalid password entered");
            Thread.Sleep(2000);
        }
        public void SignUpClickInvalid()
        {
            try
            {
                //signup invalid and click

                TideHooks.driver.FindElement(By.XPath("//*[@aria-label='text']")).SendKeys(ExlOp.ReadExcelData(0,1));
                Log.Debug("Entering first name");
                TideHooks.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(ExlOp.ReadExcelData(1,1));
                Log.Debug("Entering email");
                TideHooks.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Ab");
                Log.Warning("Enter password with given requirements");
                Log.Debug("Entering invalid password");
                Log.Error("Invalid password entered");
                TideHooks.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
                Log.Information("cannot click on login");
                Thread.Sleep(2000);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log.Information(ex.Message);
            }
        }
        public void Login()
        {
            Thread.Sleep(3000);
            TideHooks.driver.FindElement(By.XPath("//button[normalize-space()='Log in']")).Click();
            Thread.Sleep(3000);
            Log.Information("login page opened");
            TideHooks.driver.FindElement(By.XPath("//*[@id='login-email']")).SendKeys(ExlOp.ReadExcelData(1,1));
            Log.Debug("Entering email");
            TideHooks.driver.FindElement(By.XPath("//*[@id='login-password']")).SendKeys(ExlOp.ReadExcelData(2,1));
            Log.Warning("Enter password with given requirements");
            Log.Debug("Entering password");
        }
        public void LoginClick()
        {
            Thread.Sleep(1000);
            TideHooks.driver.FindElement(By.XPath("//input[@value='LOG IN']")).Click();
            Log.Information("login completed successfully");
        }
        public void ForgotPass()
        {
            Thread.Sleep(3000);
            TideHooks.driver.FindElement(By.XPath("//button[normalize-space()='Log in']")).Click();
            Log.Information("login page opened");
            Thread.Sleep(3000);
            TideHooks.driver.FindElement(By.XPath("//*[@href='/forgot-password/']")).Click();
            Log.Information("forgot password page opened");
            Thread.Sleep(5000);
            TideHooks.driver.FindElement(By.XPath("//*[@id='form-input']")).SendKeys(ExlOp.ReadExcelData(1,1));
            Log.Debug("Entering email");
        }
        public void ForgotPassClick()
        {
            TideHooks.driver.FindElement(By.XPath("//*[@value='Submit']")).Click();
            Log.Information("resest link sent to mail successfully");
            Thread.Sleep(2000);
        }
        public void Search()
        {
            Thread.Sleep(7000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Log.Information("clicked on search");
            TideHooks.driver.FindElement(By.XPath("//input[@placeholder='Search']")).SendKeys("Detergent");
            Log.Debug("Entering search text");
        }
        public void SearchClick()
        {
            TideHooks.driver.FindElement(By.XPath("//*[@aria-label='Sumbit Search']")).Click();
            Log.Information("search results displayed");
            Thread.Sleep(4000);
        }
        public void Contactus()
        {
            Thread.Sleep(10000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Log.Information("clicked on contact us");
            TideHooks.driver.FindElement(By.XPath("//a[contains(text(),'Contact Us')]")).Click();
            Thread.Sleep(15000);
        }
        public void Chat()
        {
            try
            {               
                TideHooks.driver.FindElement(By.XPath("//*[@placeholder='Type here to search for answers']")).SendKeys("Detergent");
                Log.Debug("entering text");
                Thread.Sleep(2000);
                TideHooks.driver.FindElement(By.XPath("//span[@class='fa fa-search']")).Click();
                Thread.Sleep(7000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log.Information(ex.Message);
            }
        }
        public void Shop()
        {
            Thread.Sleep(7000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            TideHooks.driver.FindElement(By.XPath("//*[@href='/en-us/shop']")).Click();
            Log.Information("clicked on shop products");
            Thread.Sleep(6000);
        }
        public void Sort()
        {
            

            new SelectElement(TideHooks.driver.FindElement(By.XPath("//*[@name='sortBy']"))).SelectByValue("title_az");
            Log.Debug("sorted the search results");
            Thread.Sleep(2000);
        }
        public void Language()
        {
            Thread.Sleep(7000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            TideHooks.driver.FindElement(By.XPath("//button[normalize-space()='US - English']")).Click();
            Log.Information("clicked on language and location");
            Thread.Sleep(3000);
        }
        public void LanguageSelecion()
        {
            TideHooks.driver.FindElement(By.XPath("//a[normalize-space()='US - Spanish']")).Click();
            Log.Debug("selected on different language");
            Log.Information("page is reloaded with seleted language");
            Thread.Sleep(10000);
        }
        public void HowToWash()
        {
            Thread.Sleep(7000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            TideHooks.driver.FindElement(By.XPath("//a[normalize-space()='How to Wash Clothes']")).Click();
            Log.Information("clicked on How to Wash Clothes");
            Thread.Sleep(3000);
        }
        public void VerifyHowToWashText()
        {
            string text = TideHooks.driver.FindElement(By.XPath("//strong[normalize-space()='How to Wash Clothes']")).Text;
            Log.Debug("extracing the text from the page to verify");
            Assert.IsTrue(text.Contains("How to Wash Clothes"));
            Log.Information("Text veified successfully");
            Console.WriteLine(text);
            Log.Information("Text printed to console");
        }
        public void SearchUsingExcel(string search)
        {
            Thread.Sleep(7000);
            TideHooks.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Log.Information("clicked on search");
            TideHooks.driver.FindElement(By.XPath("//input[@placeholder='Search']")).SendKeys(search);
            Log.Debug("Entering search text");
        }

    }
}
