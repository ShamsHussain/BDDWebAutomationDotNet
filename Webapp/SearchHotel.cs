using System;
using NUnit.Framework;
using WebAutomationBDDFramework.UI.Web;


namespace WebAutomationBDDFramework.Webapp
{
    class SearchHotel
    {
        /*
         This class contains methods for search hotel
         */
        //public static string locationame = "Sydney";
        BusinessUtil businessUtil;
        UtilLocators utilLocators;

        public SearchHotel()
        {
            businessUtil = new BusinessUtil();
            utilLocators = new UtilLocators();
        }
        public void searchAhotel()
        {
            try
            {

                businessUtil.Write(utilLocators.locationDropDown, "Sydney");
                businessUtil.Write(utilLocators.hotelDropDown, "Hotel Hervey");
                businessUtil.Write(utilLocators.roomTypeDropDown, "Standard");
                businessUtil.Write(utilLocators.noOfRoomDropDown, "2 - Two");
                businessUtil.Write(utilLocators.checkInDateTxt, "08/07/2021");
                businessUtil.Write(utilLocators.checkOutDateTxt, "09/07/2021");
                businessUtil.Write(utilLocators.adultPerRoomDropDown, "2 - Two");
                businessUtil.Write(utilLocators.childrenPerRoomDropDown, "2 - Two");
                businessUtil.Click(utilLocators.searchBtn);
            }
            catch (Exception ex) 
            {

                Console.WriteLine("Error in search hotel method-->" + ex.Message);
                throw;
            
            }
        }

    }
}
