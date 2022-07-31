Feature: Tide

checking the functionalities for the Tide web application


Scenario: Signup to web application
	Given I open the tide url
	When I click on register
	And click on regiser
	And enter valid first name, email and password
	Then I click in create account

Scenario: Signup to web application With invalid password
	Given I open the tide url1
	When I click on Register1
	And click on signup
	And enter valid first name, email and invalid password
	Then take error sceenchot

Scenario: Signup to web application click with invalid password
	Given I open tide url
	When I click on the Register
	And click on signup1
	And enter valid first name, email and invalid/short password
	Then i cannot able to clck on signup

Scenario: login to web application
	Given I opened the tide url
	When I click on the registers
	And click on sign up
	And enter valid email and password
	Then I click in login

	Scenario: changing the password of web application
	Given I opened  valid tide url
	When I click on the register now
	And i clicked on sign up
	And i enter valid email 
	Then I click on submit
	And reset mail sent

Scenario: search in the web application
	Given I opened  homepage of tide
	When I entered valid search text
	Then i clicked on Seach icon

Scenario: contact us option in the web application
	Given I opened   tide homepage
	When I clicked on contact us
	Then i used chat option

Scenario: shop products in the web application
	Given I opened   valid tide homepage
	When I clicked on shop products
	Then i sorted the results

Scenario: language in the web application
	Given I opened   correct tide url
	When I clicked on languages
	Then i selected different language


Scenario: browsing in the web application
	Given I opened the correct tide url
	When I clicked on how to wash clothes
	Then verify the text displayed

