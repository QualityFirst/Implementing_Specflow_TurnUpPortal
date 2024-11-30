Feature: TimeAndMaterials

As an admin user of the TurnUp portal
I would like to create, edit and delete 
time and material records successfully 
so that I can manage employee data correctly

@regression
Scenario: 1 Create time record with valid data
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	When I create a time record
	Then the record should be created successfully

Scenario Outline: 2 edit existing time record with valid data
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	When I update the '<Code>' and '<Description>' on an existing Time record
	Then the record should have the updated '<Code>' and '<Description>'
	
Examples:
	| Code               | Description     |
	| N-Industry Connect | N-1-Description |
	| N-TA Job Ready     | N-2-Description |
	| N-EditedRecord     | N-3-Description |

Scenario: 3 delete existing time record
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	When I delete an existing record
	Then the record should not be present on the table
