using System;
using NUnit.Framework;
using WebAutomationBDDFramework.UI.Web;


namespace WebAutomationBDDFramework.Webapp
{
    class SelectHotel
    {
        /*
         This class contains methods for select hotel
         */
       
        BusinessUtil businessUtil;
        UtilLocators utilLocators;

        public SelectHotel()
        {
            businessUtil = new BusinessUtil();
            utilLocators = new UtilLocators();
        }
        public void selectAhotel()
        {
            try
            {
                businessUtil.Click(utilLocators.selectradioButton);
                businessUtil.Click(utilLocators.continueButton);

                Assert.IsTrue(businessUtil.IsElementVisible(utilLocators.booknowButton));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in select Hotel method -->" + ex.Message);
                throw;
            }
        }

    }
}
