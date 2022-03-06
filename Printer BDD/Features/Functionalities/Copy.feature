Feature: Copy
	This file tests the Printer's copy function

@FR003
@FR
@Functionalities
@TC-0005
Scenario Outline: Copy a sheet using different paper sizes
	Given the Printer is ready for use
	And the paper drawer is filled with the paper size <PaperSize>
	When the user makes a copy of an original paper of size <PaperSize>
	Then the sheet should be copied and printed correctly

	Examples:
		| PaperSize |
		| A3        |
		| A4        |
		| A5        |

@FR003
@FR
@Functionalities
@TC-0006
Scenario: Copy a sheet with empty paper drawer
	Given the Printer is ready for use
	And the Printer has no paper in the paper drawer
	When the user makes a copy
	Then the sheet should not be printed
	And the Printer should warn a message that the paper drawer is empty