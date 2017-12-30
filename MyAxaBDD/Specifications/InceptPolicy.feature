Feature: InceptPolicy

Background: Pre-Condition
		Given user is at ROI Motor DS
		And motor DS Your Detail section is displayed

Scenario Outline: Incept a comprehensive motor policy 
#Your details section
		 When I input name "<Title>" "<firstName>" "<lastName>"
		 And date of birth"<dayOfBirth>" "<birthMonth>" "<birthYear>"
		 And I enter gender "<gender>" and email"<email>"
		 And I input phone number"<areaCode>" "<phoneNumber>"
		 And I enter adress with eircode "<eircode>"
		 And I selected "<household>" "<employmentStatus>" "<occupation>"

#Your car section		   
		 And I complete Your car section "<carRegNum>" "<kilometersDriven>"

#Your driving history 		 
		 And I complete driving history "<drivingLicence>"	"<licenceAge>" "<recentInsurance>" "<numOfClaimFreeYears>"

#Additional drivers	and claim section	 
		And I added NO additional driver and claims

#Your cover section		 
		 And I complete Your cover section
		 	   
#step 2
		And Step two is displayed	
		And I click Buy Now Button

#step 3
		And Step three is displayed	 
		And I Complete licence details "<dayLicenceIssue>" "<monthLicenceIssue>" "<yearLicenceIssue>"
		And I Complete Insurance details section "<existingPolicyExpirationDate>"
		And I input car value "<carValue>" and date "<dayCarWasPurchased>" "<monthCarWasPurchased>" "<yearCarWasPurchased>" to complete Car details section 
		And I proceed to pay in full
		And I enter my credit card details"<cardNumber>" "<cardExpMonth>" "<cardExpYear>" "<cvv>" "<cardholderName>"
		Then Policy is successfully incepted 	

		


		 
Scenarios:		 
		| Title | firstName | lastName | dayOfBirth | birthMonth | birthYear | gender | email            | areaCode | phoneNumber | eircodeYes/No | eircode | household            | employmentStatus | occupation | carRegNum | kilometersDriven | drivingLicence | licenceAge | recentInsurance     | numOfClaimFreeYears          | methodOfPayment | startDate | residency         | dayLicenceIssue | monthLicenceIssue | yearLicenceIssue | currentInsurer | existingPolicyExpirationDate | carValue			| dayCarWasPurchased | monthCarWasPurchased | yearCarWasPurchased	| cardNumber		| cardExpMonth | cardExpYear | cvv	| cardholderName|
		| Mr    | Test      | Ptester  | 12         | 05 - May   | 1970      | Female | tesst@axa-uat.ie | 087      | 0879567812  | Yes           | K32VP28 | Rented Accommodation | Employed         | Accountant | 10D262    | Up to 5,000 km   | ROI (Full)     | 9 years    | Insured in own name | 6+ Years Claims Free Driving | Pay in full     | 29        | More than 3 years | 02              | 05 - May          | 2010             | AA Insurance   | 30/12/2017                   | €5,001 to €7,000  | 05                 |12 - Dec 				|2017					|4263971921001307	|02			   |22			 |123	|Test			|
			