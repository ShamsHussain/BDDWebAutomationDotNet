Feature: Book a hotel using Adactin web app
	In order to verify hotel booking functionality 
    As a user
    I want to see hotel is booked successfully

	Background: Log in to application
        Given User is logged in to the site

@ui @automated @positive
Scenario: Book a Hotel
	When User searches for a hotel of his desire
    And User selects a hotel from the search results
    Then User books a hotel 
    And User can see hotel is booked successfully and order no is generated
