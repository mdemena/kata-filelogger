Feature: EveryDayFileName
	As a log File owner
	We save file every day
	Format file name will be logYYYYMMDD.txt

@EveryDayFileName
Scenario: Every Day File Name
	Given I have a log file
	When File not exist
	Then I create file
	And And formalfile name will be logYYYYMMDD.txt
