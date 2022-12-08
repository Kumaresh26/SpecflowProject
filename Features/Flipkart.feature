Feature: Flipkart

A short summary of the feature

Background: To launch an application
Given I launch an flipkart application url 'https://www.flipkart.com/'
When I close the login popup


@tag1
Scenario: To Launch an flipkart application
	When I pass redmi 'redmi' in search box
	And I click  search button
	Then The title should be contain 'redmi' keyword

@tag1
Scenario: To Launch an flipkart app
	When I pass redmi 'Iphone' in search box
	And I click  search button
	Then The title should be contain 'Iphone' keyword


