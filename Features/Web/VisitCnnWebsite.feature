Feature: Visit CNN Website
   Demonstrate how to integrate web browser automation test with SpecFlow

Scenario: Visit CNN website
   Given I open the 'https://edition.cnn.com' in browser
   When the browser redirects me to the webpage
   Then The webpage title contains 'news'
