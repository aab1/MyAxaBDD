Feature: MyAxaLoginAndOut
	

@Regression
Scenario: login and logout
	Given I navigate to myAxa homepage
	And I enter correct login details
	When I Click signIn
	Then the overview page is displayed
	When I click signOut
	Then the myAxa homepage is displayed
