Feature: BrowseProfiles
	In order to ensure Profiles accuracy
	As a HeckYaBaby Administrator
	I want to be create, read, update and delete Profiles 

@mytag
Scenario: Browse Profile 
	Given an existing 100 Profiles
	When I open the Profile console
	Then I will be present 10 pages of Profiles
	And each page will have 10 profiles
