Feature:  BugZilla

Background: Pre-Condition
	Given User is at Bugzilla MainPage
	And File a Bug should be visible

@bugzillaTest
Scenario Outline: Login and log a bug
	When I click on a "<flink>" link to navigate login page
	Then user should be at login page with title "<lTitle>"
	When I provide the "<user>","<pass>" and click on login button
	Then user should be at enter bug page with title "<eTitle>"
	When I provide the "<Severity>" , "<Harware>" , "<Platform>" and "<Summary>" 
	And I click on submit button in page
	Then Bug should get created 
	When i click on logout button on bug detail page
	Then user should be logged out and should be at homepage
	Examples: 
	#Scenarios:
	| TestCase | flink      | lTitle             | user              | pass   | eTitle					|	Severity | Harware   | Platform | Summary     | Desc     |
	| A        | File a Bug | Log in to Bugzilla | yemi@bugzilla.com | jesuss | Enter Bug: TestProduct	| critical | Macintosh | Other    | Summary - 1 | Desc - 1 |
	| B        | File a Bug | Log in to Bugzilla | yemi@bugzilla.com | jesuss | Enter Bug: TestProduct	| major    | Other     | Linux    | Summary - 2 | Desc - 2 |