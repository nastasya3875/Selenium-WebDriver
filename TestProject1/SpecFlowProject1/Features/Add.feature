Feature: Adding a product
	As a user 
	I want to add a new product

    Scenario: Adding a product
	Given I Open "http://localhost:5000/Account/Login?ReturnUrl=%2F" url
	And I Enter login and password 
	And I Click on submit button
	And I Click on All Products
	And I Click on Create New 
	And I Enter values into fields
	When I click on submit Button
	Then The Create/edit form has closed
