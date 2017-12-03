Feature: MyAxaLoginAndOut
	

@Regression
Scenario Outline: login and logout
	Given I navigate to myAxa homepage
	And I enter username "<username>" and password "<password>"
	When I Click signIn
	Then the overview page is displayed
	When I click signOut
	Then the myAxa homepage is displayed

Scenarios: 
	|username			 |password|
	|yemibakare@yahoo.com|Yemi1978|