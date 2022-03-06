Feature: Connections
	This file tests the Printer's connections

@NF004
@NF
@Connections
@TC-0001
Scenario Outline: Print a sheet using different connections
	Given the Printer is ready for use
	And the Printer is connected through <connection>
	When the user sends a print job
	Then the sheet <action> be printed

	Examples:
		| connection    | action     |
		| USB           | should     |
		| Network       | should     |
		| Wireless      | should     |
		| no connection | should not |

@RF002
@RF
@Connections
@TC-0004
Scenario Outline: Print a sheet using pcs connected in a wired network
	Given the Printer is ready for use
	And the Printer is connected through <connection>
	When the user1 sends a print job from pc1
	And the user2 sends a print job from pc2
	Then both jobs should be printed

	Examples:
		| connection |
		| Network    |
		| Wireless   |