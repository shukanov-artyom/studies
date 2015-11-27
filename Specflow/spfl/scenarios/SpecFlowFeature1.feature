Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@12345
@Cleanup
Scenario: Add two numbers
	Given I create a test class instance 
	And call its doubling method with argument 3
	Then i get 6 

