
Feature: Amazon


@Amazon
Scenario:To Launch an amazon application
		Given I launch an amazon application url 'https://www.amazon.in/'
		When I pass iphone 'iphone' in search box
		And I click the search button
		Then The title should contain 'iphone' keyword


@Amazon
Scenario:To Launch an amazon application url
Given I launch an amazon application url 'https://www.amazon.in/'
		When I pass iphone 'iphone' in search box



