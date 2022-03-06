Feature: Admin
	This file tests the Admin functions of the printer

Background:
	Given the Printer is ready for use

@FR005
@FR
@Functionalities
@TC-0008
Scenario: Secure print password requirement
	When the user sends a print job using the secure print function
	Then the printer should ask for his password on the printer

@FR005
@FR
@Functionalities
@TC-0009
Scenario Outline: Print a document using the secure print function
	And the user's password is <password>
	When the user sends a print job using the secure print function
	And the user enters <EnteredPassword> as his password on the printer
	Then the printer <result> print the job

	Examples:
		| password | EnteredPassword | result     |
		| Pass123  | Pass123         | should     |
		| Pass123  | Pass456         | should not |

@FR005
@FR
@Functionalities
@TC-0010
Scenario: Print a document that was send using the secure print function without entering a password
	When the user sends a print job using the secure print function
	Then the user should not be able to print the job without entering the password

@FR006
@FR
@Functionalities
@TC-0011
Scenario: Consult the Print History function
	And the user has printed some jobs
	When the user accesses the Print History function
	Then the user should not be able to see the last printed jobs
	And the report should display the IP addresses
	And the report should display the printed file name
	And the report should display the date and time the job was executed

@FR007
@FR
@Functionalities
@TC-0012
Scenario: Consult the Print Display
	When the user looks at the printer's display
	Then the user should see the printer's selected function
	And the user should see the printer's job status
	And the user should see the printer's time
	And the user should see the printer's cartridge status