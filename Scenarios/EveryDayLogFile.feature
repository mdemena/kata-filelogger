Feature: EveryDayLogFile
	As a log File owner
	If not exist, create it
	A message is put at end of log file

@EveryDayLogFile
Scenario: Every day Log file
	Given I have a log file
	When File not exist
	Then I create file
	And I write message at the end of it
