Feature: IfNotFileExistCreateIt
	As a log File owner
	If not exist, create it
	A message is put at end of log file

@IfNotFileExistCreateIt
Scenario: If file not exist, create it
	Given I have a log file
	When File not exist
	Then I create file
	And I write message at the end of it

@IfFileExist
Scenario: If file exist, add message at end of file
	Given I have a log file
	When File exist
	Then I write message at the end of it
