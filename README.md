# ASP.NET CORE WEBAPI Sample with swagger

# Introduction
 this is a short tutorial demonstrate how you can create a web api as micro service
 and cover your code with unit test and how you can use the principle of code clean.

# Instalation
  you must download the code from git and use visual studio 2017 to open it
  and build the solution finaly you can run this application on iis express 
  - you can display the first page to test this application
  - the first page is a swagger page how display all action in this api
  you can choose the endpoint to test it 
  the swagger page look like this
  ![alt text](https://user-images.githubusercontent.com/15520779/57588161-a59d8080-7510-11e9-9259-61e111c4c322.png)

# demonstration

This application respect the separation of concern 
you can find the use of interface to declare the method used in 
different layer.

And you inject all interface in the configureservices method in Startup.cs file.
the controller inject the business class and the business class inject the repository class
with this method we facilitate the test of same layer of your application.
