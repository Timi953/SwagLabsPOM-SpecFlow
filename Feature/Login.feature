Feature: Login
	Check if login functionality works

Background: 
	Given User has navigated to the application

Scenario Outline: Login user as diferent user types
	
	When User enters <username> and <password>		
	And User clicks login
	Then User should be logged in the application

	Examples: 
	| username                | password     |
	| standard_user           | secret_sauce |
	| locked_out_user         | secret_sauce |
	| problem_user            | secret_sauce |
	| performance_glitch_user | secret_sauce |


