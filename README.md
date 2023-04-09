# Unit Of Work Pattern Implementation Using ASP.Net Core 7.0
An ASP.Net Core 7.0 Web API For Unit Of Work Pattern on User Model

For Implemtation CRUD I used an object-relational mapper (O/RM) "Entity Framework Core" to work with database Sql Server.

![repository-open-graph-template](https://user-images.githubusercontent.com/25717692/230797740-4851892e-743a-4981-a677-0e57f2ee2a35.png)


## The Repository and Unit of Work Patterns
The repository and unit of work patterns are intended to create an abstraction layer between the data access layer and the business logic layer of an application. Implementing these patterns can help insulate your application from changes in the data store and can facilitate automated unit testing or test-driven development (TDD).

•	The repository pattern is used for create an abstraction layer between the data access layer and the business layer of an application.

•	The repository pattern helps to reduce code duplication and follows the DRY principle.

## What is the unit of work design pattern?
The unit of work design pattern guarantees data integrity and consistency in applications. It ensures that all changes made to multiple objects in the application are committed to the database or rolled back. It provides an organized and consistent way to manage database changes and transactions.

•	The main goal of unit of work pattern is to maintain consistency and atomicity, ensuring that all changes made to the database are successful or fail together if there’s a problem.

•	The unit of work pattern guarantees that data consistency is maintain and modifications to the database are accurate.

•	With the unit of work design pattern in place, developers can save time and effort by focusing on business logic instead of database access and management.

### Note: The following illustration shows one way to conceptualize the relationships between the controller and context classes compared to not using the repository or unit of work pattern at all.
![Windows-Live-Writer_8c4963ba1fa3_CE3B_Repository_pattern_diagram_1df790d3-bdf2-4c11-9098-946ddd9cd884](https://user-images.githubusercontent.com/25717692/230794077-b03828ef-9121-49ff-9ffe-afc8409c3caa.png)

The diagram is from <a href="https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application" target="_blank"> here </a> 

The result of web api project:
![Unit Of Work Pattern](https://user-images.githubusercontent.com/25717692/230794614-fbe30c6d-164d-4e1f-9575-48d954c11ec0.jpg)


References:

•	 https://learn.microsoft.com/

•	https://www.infoworld.com/

•	https://www.c-sharpcorner.com/

•	https://www.e-iceblue.com/

