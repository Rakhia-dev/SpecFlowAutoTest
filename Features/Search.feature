Feature: Search
search for dynamic 365 on google

@mysearch
Scenario: search dynamic365 on google page
	Given I enter the url 'https:\\www.google.com'
	When I search for 'Dynamic 365'
	And navigate to dynamic details page
	Then dynamic page is displayed successfully
