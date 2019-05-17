using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace MarsFramework.Pages
{
    class SignUp
    {
        private RemoteWebDriver _driver;
        public SignUp(RemoteWebDriver driver) => _driver = driver;

    

        #region  Initialize Web Elements
        //Finding the Join 
        private IWebElement Join => _driver.FindElementByXPath("//*[@id='home']/div/div/div[1]/div/button");

        //Identify FirstName Textbox
        private IWebElement FirstName => _driver.FindElementByXPath("/html/body/div[2]/div/div/div/form/div[1]/input");

        //Identify LastName Textbox
        private IWebElement LastName => _driver.FindElementByXPath("/html/body/div[2]/div/div/div/form/div[2]/input");

        //Identify Email Textbox
        private IWebElement Email => _driver.FindElementByXPath("/html/body/div[2]/div/div/div/form/div[3]/input");

        //Identify Password Textbox
        private IWebElement Password => _driver.FindElementByXPath("/html/body/div[2]/div/div/div/form/div[4]/input");

        //Identify Confirm Password Textbox
        private IWebElement ConfirmPassword => _driver.FindElementByXPath("/html/body/div[2]/div/div/div/form/div[5]/input");

        //Identify Term and Conditions Checkbox
        private IWebElement Checkbox => _driver.FindElementByXPath("/html/body/div[2]/div/div/div/form/div[6]/div/div/input");

        //Identify join button
        private IWebElement JoinBtn => _driver.FindElementByXPath("//*[@id='submit-btn']");
        #endregion
        #region SignUp 
        internal void register()
        {
            
            //Click on Join button
            Join.Click();

            //Enter FirstName
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"FirstName"));

            //Enter LastName
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            Checkbox.Click();

            //Click on join button to Sign Up
            JoinBtn.Click();

            
        }
        #endregion
    }
}
