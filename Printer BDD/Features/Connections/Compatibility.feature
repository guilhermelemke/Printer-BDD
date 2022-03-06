Feature: Compatibility
	This file tests the Printer's compatibility with different Operational Systems

@NF005
@NF
@Connections
@TC-0015
Scenario Outline: Print a sheet using different Operational Systems
	Given the Printer is ready for use
	And the user sends a printing job from a machine using <OperationalSystem>
	When the user sends a print job
	Then the sheet should be printed correctly

	Examples:
		| OperationalSystem  |
		| Windows 7          |
		| Windows 10         |
		| Windows 11         |
		| Ubuntu Linux 20.04 |
		| Debian Linux 11.2  |
		| macOS 11 Big Sur   |
		| macOS 12 Monterey  |