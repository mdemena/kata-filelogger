Feature: LogMessageAtEndOfFile
	As a log File owner
	I write message to log file
	A message is put at end of log file

@LogMessageAtEndOfFile
Scenario: Log message at end of log file
	Given I have a log file
	When I put a message to it
	Then I write message at the end of it
