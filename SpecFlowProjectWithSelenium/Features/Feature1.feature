Feature: to validate invalid login functionality

A short summary of the feature

@tag2
Scenario: invalidate Functionality with invalid user name and passwords
	Given Go tothe URL
	And Enter invalid username
	And Enter invalid password
	When click on Login button
	Then check the error message