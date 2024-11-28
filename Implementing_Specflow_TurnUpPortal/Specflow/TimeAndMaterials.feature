Feature: TimeAndMaterials

As an admin user of the TurnUp portal
I would like to create, edit and delete 
time and material records successfully 
so that I can manage employee data correctly

@regression
Scenario: Create time record with valid data
	Given I logged in into TurnUp portal successfully
	When I navigate to Time and Materials Page
	When I create a new Time record
	Then the record should be created successfully
