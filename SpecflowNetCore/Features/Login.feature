Feature: Login
	Login to EA Demo application, feature text

# Always make scenarios independant
@smock
Scenario: Perform login of EA application site
	#These are steps
	Given I launch the application
	And I click login link
	And I enter the following details
		| Username | Password |
		| admin    | password |
	And I click login button
	Then I should see Employee details link

# Scenario Outline is like a loop
Scenario Outline: Run application in two urls
	Given I launch the application with <url>
	And I click login link
	And I enter the following details
		| Username | Password |
		| admin    | password |
	And I click login button
	Then I should see Employee details link

	Examples: 
		| url                 |
		| https://contoso.com |
		| https://contoso.net |
