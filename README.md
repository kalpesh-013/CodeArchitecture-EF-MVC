# CodeArchitecture-EF-MVC
The Architecture provides a more reliable way to make applications for better implementation, maintainability, and dependability on the support like databases and services. The main aim is to address the challenges faced in 3-tier architecture or n-tier architecture.

- Core
  It is a class library project with all models used in EF architecture. Those models represent the Domain Entities layer of the project architecture. These classes are used to create database tables. It’s a core and central part of the application.
- Services 
  It is a class library project. It holds business logic and interfaces. These interfaces communicate between UI and code (data) access logic. As it communicates via interfaces,  with loosely coupled. This project represents the Service layer.
- Web
  It is a sample .NET Web application for Admin panel. It is the external part of an application by which the end-user can interact with the application. It builds loosely coupled applications with in-built dependency injection in ASP.NET. It represents the UI layer of the project architecture. 
  
