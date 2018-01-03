Feature: QuotesAndRetrieval

Background: Pre-Condition
		Given user is at ROI Motor DS
		And motor DS Your Detail section is displayed
#TC 1
Scenario Outline: Save And Retrieve Motor DS Quote

		 Given user is at ROI Motor DS
		 And motor DS Your Detail section is displayed
		 When I input name "<Title>" "<firstName>" "<lastName>"
		 And date of birth"<dayOfBirth>" "<birthMonth>" "<birthYear>"
		 And I enter gender "<gender>" and email"<email>"
		 And I input phone number"<areaCode>" "<phoneNumber>"
		 And I enter adress with eircode "<eircode>"
		 And I selected "<household>" "<employmentStatus>" "<occupation>"		   
		 And I complete Your car section "<carRegNum>" "<kilometersDriven>"		 
		 And I complete driving history "<drivingLicence>"	"<licenceAge>" "<recentInsurance>" "<numOfClaimFreeYears>"	 
		 And I added NO additional driver and claims	 
		 And I complete Your cover section		 	   
#step 2
		And Step two is displayed	
		And I proceed to save the quote
		Then The quote is saved successfully
		When I navigate to the quote retrieval page
		And I choose "<MethodforQuoteretrieval>" method for retrieving the quote
		And I input the quote details
		Then The quote is retrieved successfully

		Scenarios:		 
		| Title | firstName | lastName | dayOfBirth | birthMonth | birthYear | gender | email             | areaCode | phoneNumber | eircodeYes/No | eircode | household            | employmentStatus | occupation | carRegNum | kilometersDriven | drivingLicence | licenceAge | recentInsurance     | numOfClaimFreeYears          | MethodforQuoteretrieval                       |
		| Mr    | quote     | saved    | 12         | 05 - May   | 1980      | Female | quote1@axa-uat.ie | 087      | 0879567812  | Yes           | K32VP28 | Rented Accommodation | Employed         | Accountant | 10D262    | Up to 5,000 km   | ROI (Full)     | 9 years    | Insured in own name | 6+ Years Claims Free Driving | Email, date of birth & quote reference number |

#TC2
#retrieve solus quote