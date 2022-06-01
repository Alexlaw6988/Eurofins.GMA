Eurofins.GMA
Goals
The goal of this repository is to provide a basic solution structure that can be used to build Domain-Driven Design (DDD)-based or simply well-factored, SOLID applications using .NET Core. Learn more about these topics here:

SOLID Principles for C# Developers
SOLID Principles of Object Oriented Design (the original, longer course)


Domain-Driven Design:

The Application Contract Project:
    This provides the service contracts to the API/Presentation Layer. the following properties involves in this layer
* DTOs 
* Service Interfaces

The Application Project:
    This Layer covers the implemetation of the service contacts and the unit of work (Calling the other microservices and Domain services)
And other non domain oriented service implementations are done here.
* Service Implementations
* UnitOfWork
* Other non Domain services


The Domain Project:

    The Domian project is the center of the Clean Architecture design, and all other project dependencies should point toward it. As  such, it has very few external dependencies. The one exception in this case is the System.Reflection.TypeExtensions package, which is used by ValueObject to help implement its IEquatable<> interface. The Core project should include things like:

* Entities
* Aggregates
* Repositories(Interface)
* Domain Services(Contracts & Implementations)
* Specifications


The Configuration Project:
    The Configuration Project contains all the configurations , it uses Autofac to create the modules and its configurations.

* Configurations
* Module
* Seeding logic


The Infrastructure Project:
    Most of your application's dependencies on external resources should be implemented in classes defined in the Infrastructure project. These classes should implement interfaces defined in Domain. If you have a very large project with many dependencies, it may make sense to have multiple Infrastructure projects (e.g. Infrastructure.Data), but for most projects one Infrastructure project with folders works fine. The sample includes data access and domain event implementations.

    in future if we wants to replace this with ORACLE or if we are chaning the implementation logic with out disturbing other layer we can accomplish the new changes.

* DAL Logics
* Repository Implemetaions(Entity framework, Dapper and treditional approches)
* DB context (SQl, Oracle or other DB)
* migrations(it may be moved seperately in to another project)

The API Project:

    The entry point of the application is the ASP.NET Core web project. This is actually a console application, with a public static void Main method in Program.cs. It currently uses the default MVC organization (Controllers and Views folders) as well as most of the default ASP.NET Core project template code. This includes its configuration system, which uses the default appsettings.json file plus environment variables, and is configured in Startup.cs. The project delegates to the Infrastructure project to wire up its services using Autofac.

The Test Projects:
    Test projects could be organized based on the kind of test (unit, functional, integration, performance, etc.) or by the project they are testing (Core, Infrastructure, Web), or both. For this simple starter kit, the test projects are organized based on the kind of test, with unit, functional and integration test projects existing in this solution. In terms of dependencies, there are three worth noting:

xunit I'm using xunit because that's what ASP.NET Core uses internally to test the product. It works great and as new versions of ASP.NET Core ship, I'm confident it will continue to work well with it.

Moq I'm using Moq as a mocking framework for white box behavior-based tests. If I have a method that, under certain circumstances, should perform an action that isn't evident from the object's observable state, mocks provide a way to test that. I could also use my own Fake implementation, but that requires a lot more typing and files. Moq is great once you get the hang of it, and assuming you don't have to mock the world (which we don't in this case because of good, modular design).

Microsoft.AspNetCore.TestHost I'm using TestHost to test my web project using its full stack, not just unit testing action methods. Using TestHost, you make actual HttpClient requests without going over the wire (so no firewall or port configuration issues). Tests run in memory and are very fast, and requests exercise the full MVC stack, including routing, model binding, model validation, filters, etc.

