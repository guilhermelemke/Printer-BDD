Feature: Copy
	This file tests the Printer's copy function

@FR003
@FR
@Functionalities
@TC-0005
Scenario Outline: Copy a sheet using different paper sizes
	Given the Printer is ready for use
	And the Printer has paper in size <PaperSize> in the paper drawer
	When the user sends a print job
	Then the sheet should be printed

	Examples:
		| PaperSize |
		| A3        |
		| A4        |
		| A5        |

@FR001
@FR
@Functionalities
@TC-0006
Scenario: Print a sheet with empty paper drawer
	Given the Printer is ready for use
	And the Printer has no paper in the paper drawer
	When the user sends a print job
	Then the sheet should not be printed
	And the Printer should warn a message that the paper drawer is empty