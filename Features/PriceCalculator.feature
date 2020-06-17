Feature: Price Calculator
    User provide product SKU and amount to buy,
    then the total price will be determined 
    based on unit-price, amount and sales condition.

Scenario: Calculate total price to pay
   Given I enter SKU number 'A-1234'
   And I enter purchase amount 5
   When I clicks calculate
   Then the calculator shows 500 as the total price to pay
