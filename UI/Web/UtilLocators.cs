using System;
using OpenQA.Selenium;

namespace WebAutomationBDDFramework.UI.Web
{
    internal class UtilLocators
    {
        // This class contains locators for web automation
        #region Login page Locators

        public By usernameTxt = By.Id("username");
        public By passwordTxt = By.Id("password");
        public By loginBtn = By.Id("login");
        public By welcomeNote = By.XPath("/html/body/table[2]/tbody/tr[1]/td[1]");

        #endregion Login page Locator

        #region search hotel Locators

        public By locationDropDown = By.Name("location");
        public By hotelDropDown = By.XPath("//*[@id='hotels']");
        public By roomTypeDropDown = By.XPath("//*[@id='room_type']");
        public By noOfRoomDropDown = By.XPath("//*[@id='room_nos']");
        public By checkInDateTxt = By.XPath("//*[@id='datepick_in']");
        public By checkOutDateTxt = By.XPath("//*[@id='datepick_out']");
        public By adultPerRoomDropDown = By.XPath("//*[@id='adult_room']");
        public By childrenPerRoomDropDown = By.XPath("//*[@id='child_room']");
        public By searchBtn = By.Id("Submit");
        public By resetBtn = By.Id("Reset");

        #endregion

        #region Select Hotel Locators

        public By selectradioButton = By.Id("radiobutton_0");
        public By continueButton = By.Id("continue");
        public By cancelButton = By.Id("cancel");

        #endregion

        #region Book a Hotel Locators 

        public By firstnameTextfield = By.Id("first_name");
        public By lastnameTextfield = By.Id("last_name");
        public By addressTextfield = By.Id("address");
        public By ccTextfield = By.Id("cc_num");
        public By cctypeDropDown = By.XPath("//*[@id='cc_type']");
        public By expirymonthDropDown = By.XPath("//*[@id='cc_exp_month']");
        public By expiryyearDropDown = By.XPath("//*[@id='cc_exp_year']");
        public By cvvTextfield = By.Id("cc_cvv");
        public By booknowButton = By.Id("book_now");
        public By cancelbookButton = By.Id("cancel");

        #endregion

        #region Booking Confirmation

        public By ordernumberField = By.Id("order_no");


        #endregion

    }
}
