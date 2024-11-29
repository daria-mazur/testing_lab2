Feature: Remove items from cart
  As a user
  I want to add and then remove items from the cart
  So that I can manage my cart effectively

  Scenario: Removing all items from the cart
    Given I am logged into the website
    When I add items to the cart
    And I remove all items from the cart
    Then the cart should be empty
