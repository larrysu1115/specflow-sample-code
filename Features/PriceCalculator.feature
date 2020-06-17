Feature: Price Calculator
    User provide product SKU and amount to buy,
    then the total price will be determined 
    based on unit-price, amount and sales condition.

Scenario: Calculate total price to pay
   Given I enter SKU number 'A-1234'
   And I enter purchase amount 5
   When I clicks calculate
   Then the calculator shows 500 as the total price to pay

Scenario Outline: Calculator makes 50% discount for products on sale
   Given I enter SKU number '<sku>'
   And I enter purchase amount <amount>
   When I clicks calculate
   Then the calculator shows <price> as the total price to pay

   Examples: 
   | sku        | amount | price |
   | A-123      | 3      | 300   |
   | A-123-sale | 3      | 150   |
   | B-xyz      | 2      | 400   |
   | B-xyz-sale | 2      | 200   |

