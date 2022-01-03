# BDDWebAutomationDotNet
Open opportunities and helps to adopt test automation best practices.

# About Project
The purpose of this project is to Automate [http://adactinhotelapp.com/] website through BDD Framework and using POM design pattern. Major tools and technologies are .Net, Selenium, C# and Cucumber. 
Please see below for the Test Cases that are automated and instructions to run these test cases

# Install
Download and Install VS community edition

Install all the required packages in VS
Selenium
Cucumber
Spacflow
Selenium Support
NUnit

Open project folder (WebAutomationBDDFramework) in VS Code

Build the project and run test cases

Run tests
On VS Test explorer window, click any feature file and select scenario to run tests inside it 



Following test cases are automated
Test Cases:
** Login/Search/Select/Book Hotel Test Case - Automate E2E functionality **
** Steps Automated **

Open link [http://adactinhotelapp.com/]
Login to the website
Make sure that User is logged in successfully or throw Authentication failed message in case of invalid user
On Search page, enter data for all required fields and hit search button
Verify that search results are returned successfully
Select any row from the list on select page and hit continue button
On Book Hotel page, enter user data for all required fields and hit Book now button
Verify that hotel is booked successfully and order number is generated
