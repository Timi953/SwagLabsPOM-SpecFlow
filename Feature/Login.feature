Feature: Login
	Check if login functionality works

@standardLogin
Scenario: Login user as standard user
	Given I have navigated to application
	And I enter username and password
		| UserName      | Password     |
		| standard_user | secret_sauce |
	And I click login
	Then I should be logged in the application


