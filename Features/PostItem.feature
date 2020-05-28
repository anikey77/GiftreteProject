Feature: PostItem
As a giftrete registered member
I want to be able to post an item


Scenario Outline: Valid post item
Given I navigate to giftrete website
When I click on sign in button
 And enter valid email Addresss
 And I enter Valid password
 And I click on Sign in 
 And I click on Post item
 And I enter item name
 And i enter item Description
 And I select item Category
 And I select Item type
 And I enter Item weight
 And I enter  location
 And I upload item image
 Then i click add item
