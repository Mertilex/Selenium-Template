Feature: Group of tests related to specific area - Login

As a User
I want to be able to log in to the application using different methods
So I can use the application when I am logged in

Background: 
	Given The User has role all privileges assigned 

#@tag1
Scenario: User is able to log in to the application using login and password
	Given Login page is displayed
	When the User provides login and password
	And the User clicks on LogIn button
	Then the User is logged in
	And Main page of the application is displayed
