Feature: EmployeeFeature


@mytag
Scenario Outline: Insert employee details and fetch with ID
	Given insert employee details
	| Name    | Id | Phone    | Dept |
	| Sridhar | 1  | 12345767 | IT   |
	| Rexston | 2  | 23141414 | CS   |
	When I try to find with ID '<ID>'
	Then the employee details should be displayed
	Examples: 
	| ID |
	| 1  |
	| 2  |
	| 3  |
	| 4  |
