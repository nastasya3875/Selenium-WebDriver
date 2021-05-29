Feature: Login to the system
To use the system
As a user 
I want to log in system

Scenario: Login to the system
	Given I open "http://localhost:5000/Account/Login?ReturnUrl=%2F" url
	And I enter login
	And I enter password
	When I click on submit button
	Then The browser redirects me to the Home page