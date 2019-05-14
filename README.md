# ASP.NET CORE WEBAPI Sample with swagger

# Introduction
 This short tutorial demonstrate how you can create a web api as micro service
 and cover your code with unit test and how you can use the principle of clean code.
 
The purpose of this example is to use the NoSQL data to display 
the temperatures of the different country and city, 
the user can search the temperature by specifying the country.


# Installation
  You must download the code from git and use visual studio 2017 (you can download Vs2017 from    https://visualstudio.microsoft.com/fr/downloads/) to open it
  and build the solution finaly you can run this application on iis express 
  - You can display the first page to test this application
  - The first page is a swagger page how display all action in this api
  (documentatuin swagger : https://swagger.io/tools/swagger-ui/)
  
  you can choose the endpoint to test it the swagger page look like this.
  
  ![alt text](https://user-images.githubusercontent.com/15520779/57588161-a59d8080-7510-11e9-9259-61e111c4c322.png)

# Demonstration

This application respect the separation of concern 
you can find the use of interface to declare the method used in 
different layer.

Inject all interface in the configure services method in Startup.cs file.
The controller inject the business class and the business class inject the repository class
with this method we facilitate the test of same layer of our application.
 * display the getAll action from swagger interface
 
 ![alt text](https://user-images.githubusercontent.com/15520779/57588340-0d54cb00-7513-11e9-9c9c-95c194c33fbb.png)
  - response: 
  ![alt text](https://user-images.githubusercontent.com/15520779/57588354-4d1bb280-7513-11e9-90f8-c5d66cf7834c.png)
  
# Unit test
to test this application i used NUnit framework and mock

- mock the class used in the tested method.
