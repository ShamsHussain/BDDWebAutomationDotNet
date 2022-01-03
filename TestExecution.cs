using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomationBDDFramework.UI.Web;

namespace WebAutomationBDDFramework
{
    [Binding]
    public class TestExecution
    {
        /*
         * Description:
            |  This class contains the Initialization settings before and after the test cases are run
         */

        #region Setups and Cleanups
        //public TestContext instance;
        //public TestContext TestContext
        //{
        //    set { instance = value; }
        //    get { return instance; }
        //}

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            //Initialization.ExecutionBrowser = ConfigurationManager.AppSettings["ExecutionBrowser"].ToString();
            //Initialization.SeleniumInit();
            //BusinessUtil businessUtil = new BusinessUtil();
            //driver = new ChromeDriver(@"C:\Users\shams.hussain\Downloads\chromedriverf");

        }

        [AfterScenario]
        public void RunAfterScenario()
        {
            //Initialization.TestCleanup();
        }

        #endregion
    }
}
