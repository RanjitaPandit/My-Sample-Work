using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;


namespace MarsFramework.Pages
{
    internal class ShareSkills
    {

        private RemoteWebDriver _driver;
        public ShareSkills(RemoteWebDriver driver) => _driver = driver;

        #region Initialize Web Elements 

        // ShareSkills button
        IWebElement ShareSkill => _driver.FindElementByCssSelector("div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button");

        // Title
        IWebElement Title => _driver.FindElementByName("title");

        // Description
        IWebElement Description => _driver.FindElementByName("description");

        // Select Category
        IWebElement Category => _driver.FindElementByName("categoryId");

        // Select Graphics & Design
        IWebElement GraphicsDesign => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)");

        //Select SubCategory - Logo Design
        IWebElement SubCategory => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown");

        //Select SubCategory - Logo Design
        IWebElement LogoDesign => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)");

        //Select Tag Names
        IWebElement Tag => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Select Service Type -Hourly Basis
        IWebElement ServiceTypeHourly => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Service Type -One-off
        IWebElement ServiceTypeOnOff => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");
        //Select Location Type - Onsite

        //Select Location Type - Onsite
        IWebElement LocationTypeOnsite => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Location Type - Onsite
        IWebElement LocationTypeOnline => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)");

        //Avilable Days -Start Date
        IWebElement StartDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)");

        //Avilable Days -End Date
        IWebElement EndDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)");

        //Skill Trade - Skill Exchange
        IWebElement SkillExchange => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Skill Exchange - Required Skills
        IWebElement RequiredSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Skill Trade - Credit
        IWebElement Credit => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");


        //Credit - Enter Amount
        IWebElement CreditAmount => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)");

        // Status Active 
        IWebElement StatusActive => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Status Hidden 
        IWebElement StatusHidden => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");

        // Work Sample 
        IWebElement WorkSample => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25");

        // Save Share Skills
        IWebElement SaveShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");

        // Cancel Share Skills
        IWebElement CancelShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");
        #endregion
       

        #region Add new Skill
        public void AddNewSkill()
        {

            #region Navigate to Share Skills Page
            // Click on Share Skills Page
            ShareSkill.WaitForElementClickable(_driver, 60);
            ShareSkill.Click();
            //Populate the excel data            
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");

            #endregion


            #region Enter Title 
            Title.WaitForElementClickable(_driver, 60);
            //Enter the data in Title textbox
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "title"));

            #endregion

            #region Enter Description

            //Enter the data in Description textbox
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterDescription"));


            #endregion

            #region Category Drop Down

            // Click on Category Dropdown
            Category.Click();


            // Select Category from Category Drop Down
            var SelectElement = new SelectElement(Category);
            SelectElement.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "category")));

            // Click on Sub-Category Dropdown
            SubCategory.Click();

            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "subcategory")));
            #endregion

            #region Tags
            // Eneter Tag
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TagName"));
            Tag.SendKeys(Keys.Enter);

            #endregion

            #region Service Type Selection

            // Service Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date
            StartDate.Click();
            // Select End Date
            EndDate.Click();
            #endregion


            #region Select Skill Trade
            // Select Skill Trade

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {

                RequiredSkills.Click();
                RequiredSkills.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);

            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Credit")
            {

                CreditAmount.Click();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AmountInExchange"));
                CreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status

            if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion


            #region Add Work Sample

            //Work Sample upload button path
            IWebElement upload = _driver.FindElement(By.XPath("//*[@id='selectFile']"));

            // Uploading File path
            var GetCurrentDirectory = Directory.GetCurrentDirectory();
            String path = GetCurrentDirectory + @"\MarsFramework\Upload Files\Samplework.txt";
            upload.SendKeys(path);




            #endregion

            #region Save / Cancel Skill
            // Save or Cancel New Skill

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
            {
                SaveShareSkills.Click();
            }
            else if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Cancel")
            {
                CancelShareSkills.Click();
            }
            #endregion


            #region Check whether New  skill created sucessfully 

            string ShareSkillSucess = _driver.FindElement(By.LinkText("Manage Listings")).Text;

            if (ShareSkillSucess == "Manage Listings")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Shared Skill Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Share Skill Unsuccessful");
            }
            #endregion
        }
        #endregion
    }
}
