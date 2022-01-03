using System;
using NUnit.Framework;
using WebAutomationBDDFramework.UI.Web;


namespace WebAutomationBDDFramework.Webapp
{
    class BookAHotel
    {
        /*
         This class contains methods for search hotel
         */
        //public static string locationame = "Sydney";
        BusinessUtil businessUtil;
        UtilLocators utilLocators;

        public BookAHotel()
        {
            businessUtil = new BusinessUtil();
            utilLocators = new UtilLocators();
        }
        public void selectAhotel()
        {
            try
            {
                businessUtil.Write(utilLocators.firstnameTextfield, "Same");
                businessUtil.Write(utilLocators.lastnameTextfield, "Hales");
                businessUtil.Write(utilLocators.addressTextfield, "NJ Eleventh Street");
                businessUtil.Write(utilLocators.ccTextfield, "1234567898765654");
                businessUtil.Write(utilLocators.cctypeDropDown, "Visa");
                businessUtil.Write(utilLocators.expirymonthDropDown, "January");
                businessUtil.Write(utilLocators.expiryyearDropDown, "2022");
                businessUtil.Write(utilLocators.cvvTextfield, "231");
                businessUtil.Click(utilLocators.booknowButton);
            }
            catch (Exception ex) 
            {

             Console.WriteLine("Error appeared in select hotel method-->" + ex.Message);

            }

        }
        public void GetOrderNumber() 
        {
            try
            {
                string GetorderNo = businessUtil.GetElementAttributeText(utilLocators.ordernumberField);
                Assert.IsNotNull(GetorderNo);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error in Get ordernumber method-->" + ex.Message);
            }
        }

    }
}
