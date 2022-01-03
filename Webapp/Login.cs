using System;
using NUnit.Framework;
using System.Configuration;
using WebAutomationBDDFramework.UI.Web;

namespace WebAutomationBDDFramework.Webapp
{
    class Login
    {
        /*
         * This class contains the method for website login and logout
         */

        public static string Url = "http://adactinhotelapp.com/HotelAppBuild2/index.php";
        public static string UserName = "AmirTester";
        public static string Password = "AmirTester";
       

        BusinessUtil businessUtil;
        UtilLocators utilLocators;

        public Login() 
        {
            businessUtil = new BusinessUtil();
            utilLocators = new UtilLocators();
        }

        public void siteLogin() 
        {
            try
            {
                businessUtil.OpenUrl(Url);
                businessUtil.Write(utilLocators.usernameTxt, UserName);
                businessUtil.Write(utilLocators.passwordTxt, Password);
                businessUtil.Click(utilLocators.loginBtn);

                Assert.IsTrue(businessUtil.IsElementVisible(utilLocators.welcomeNote));
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error in site login method -->" + ex.Message);
                throw;
            
            }
        }

      
    }
}
