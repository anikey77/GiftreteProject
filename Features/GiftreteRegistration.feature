Feature: GiftreteRegistration
In order to have access to giftrete 
I need to register



Scenario: Valid Registration
Given I navigate to giftrete website
When I click on Create account
And I Fill in the registration form
Then I click register



Scenario: Invalid Registration
Given I navigate to giftrete website
When I click on Create account
#nd I Fill in the registration form
Then I click register
Then the error message"Please fill out this field"




