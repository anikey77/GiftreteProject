Feature: GiftreteLogin


Scenario: Valid Login
 Given I navigate to giftrete website
 When I click on sign in button
 And enter valid email Addresss
 And I enter Valid password
 And I click on Sign in
  



  #Scenario: Invalid Valid Login
 #Given I navigate to giftrete website
# When I click on sign in button
 #And enter valid email Addresss
 #And I did not enter Valid password
 #And I click on Sign in
 #Then error message ""
  

 # Scenario: Valid Login
 #Given I navigate to giftrete website
 #When I click on sign in button
# And I left the email and password blank
# And I click on Sign in
 #Then errorMessage ""
  
 