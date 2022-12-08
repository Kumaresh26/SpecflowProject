Feature: LoginTest

A short summary of the feature

@tag1
Scenario Outline:To launch an Login Test application
	Given I launch an Login Test application url 'https://practicetestautomation.com/practice-test-login/'
	When I pass the username '<username>' and password '<password>'
	And I click the login button
	Then I get the message 
	Examples: 
	| username        | password          |
	| student         | Password123       |
	| invalidusername | Password123       |
	| student         | incorrectPassword |
	
