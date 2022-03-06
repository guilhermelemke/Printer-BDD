Feature: Scan
	This file tests the Printer's scan function

@FR004
@FR
@Functionalities
@TC-0007
Scenario Outline: Scan a sheet using different paper sizes
	Given the Printer is ready for use
	When the user scans an original paper of size <PaperSize>
	Then the sheet should be scanned and saved to the users pc

	Examples:
		| PaperSize |
		| A3        |
		| A4        |
		| A5        |
