Feature: ProfileFeature

As a seller
I want the feature to add my Profile details
So that the people seeking for skills can look into my details

Scenario: Add Name in the Profile 
	Given I logged into portal successfully
	When I add name in the profile
	Then The name should be added successfully

Scenario: Add Description in the Profile
    Given I logged into portal successfully
	When I add description in the profile
	Then The description should be added successfully


Scenario Outline: Add Languages in the Profile
    Given I logged into portal successfully
	When I add '<Languages>' and '<Level>' to the profile
	Then The '<Languages>' and '<Level>' should be added successfully

    
Examples:
| Languages | Level             |
| Arabic    | Basic             |
| English   | Fluent            |
| Hindi     | Conversational    |
| Tamil     | Native/Bilingual  |      

#Scenario Outline: Add Skills in the Profile
#	Given I logged into portal successfully
#	When I add '<Skills>' and '<Level>' to profile
#	Then The '<Skills>' and '<Level>' should be added to the profile successfully
#
#Examples:
#| Skills    | Level         |
#| Cooking   | Expert        |
#| Reading   | Intermediate  |
#| Teaching  | Beginner      |

#Scenario : Choose Availability in the Profile
#	Given I logged into portal successfully
#   When I choose Part time in Availability dropdown
#   Then Part time should be added in Availability






  
 



	

