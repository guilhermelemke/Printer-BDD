Feature: Jobs
	This file tests the Printer's performance regarding printing, scanning and copying

@NF001
@NF
@Performance
@TC-0013
Scenario Outline: Printers performance for job execution
	Given the Printer is ready for use
	And the paper drawer is filled with paper
	When the user starts a <action> job
	Then the sheet should be <result>
	And the job should be finished in less than <time> seconds

	Examples:
		| action   | result  | time |
		| copying  | copied  | 5    |
		| scanning | scanned | 8    |
		| printing | printed | 3    |

@NF006
@NF
@Performance
@TC-0014
Scenario: Printers performance for printed page quantity
	Given the Printer is ready for use
	And the paper drawer is filled with paper
	And the ink cartridge is full
	When the user prints many jobs
	Then the Printer should print at least 1000 with the same ink cartridge