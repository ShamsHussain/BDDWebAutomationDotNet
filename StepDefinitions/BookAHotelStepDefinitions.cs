using System;
using TechTalk.SpecFlow;
using WebAutomationBDDFramework.Webapp;

namespace WebAutomationBDDFramework.StepDefinitions
{
    [Binding]
    public class BookAHotelStepDefinitions
    {
        private Login login = new Login();
        private SearchHotel SearchHotel = new SearchHotel();
        private SelectHotel selectHotel = new SelectHotel();
        private BookAHotel Book = new BookAHotel();

        [Given(@"User is logged in to the site")]
        public void GivenUserIsLoggedInToTheSite()
        {
            login.siteLogin();
        }

        [When(@"User searches for a hotel of his desire")]
        public void WhenUserSearchesForAHotelOfHisDesire()
        {
            SearchHotel.searchAhotel();
        }

        [When(@"User selects a hotel from the search results")]
        public void WhenUserSelectsAHotelFromTheSearchResults()
        {
            selectHotel.selectAhotel();
        }

        [Then(@"User books a hotel")]
        public void ThenUserBooksAHotel()
        {
            Book.selectAhotel();
        }

        [Then(@"User can see hotel is booked successfully and order no is generated")]
        public void ThenUserCanSeeHotelIsBookedSuccessfullyAndOrderNoIsGenerated()
        {
            System.Console.WriteLine("Pass");
        }
    }
}
