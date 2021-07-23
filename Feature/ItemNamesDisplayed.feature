Feature: ItemNamesDisplayed
	Check if the item names are displayed

@item_names_displayed
Scenario: Verify if item names are diplayed
	Given I navigate to the app
	And i login 
	When i look at the item names
	Then the names should be displayed