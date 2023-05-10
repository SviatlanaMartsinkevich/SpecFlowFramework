Feature: SpecFlowTests

A short summary of the feature

@smoke
Scenario Outline: Clicking menu option from the main menu should search necessary data and open corresponding page
	Given Open official SpecFlow web site
	When Hover the '<menuItem>' menu item from the main menu
	And Click '<subMenuItem>' option from the main menu
	And Click on the ‘search docs’ field 
	And Enter the text '<inputText>' in the popup window
	And Select the '<result>' in result window
	Then Page with '<title>' title should be opened

	Examples: 
	| menuItem | subMenuItem | inputText    | result       | title        |
	| Docs     | SpecFlow    | Installation | Installation | Installation |
