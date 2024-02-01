# Back-end Web Development with .NET for Beginners

Web APIs are designed to enable applications to interact with data and business logic and exchange information with other services over common internet protocols like HTTP. This course introduces the basic concepts behind building web APIs with ASP.NET Core, including: the hosting model, middlewares, and dependency injection. This course will also provide an overview of building HTTP-based services using minimal APIs. 

## Video Series Links

Full Series:
- YouTube link: https://aka.ms/dotnet/beginnervideos/youtube/webapi 
- Learn link: https://aka.ms/dotnet/beginnervideos/learn/webapi

Individual Video Links:

1. [Introduction to APIs with .NET](https://youtu.be/OmUuR4GiwIE)
1. [Hosting model for .NET APIs](https://youtu.be/r3ys7oL9izQ)
1. [Implementing a Web API in .NET](https://youtu.be/FNLuegvqNak)
1. [Testing .NET Web APIs with .http files](https://youtu.be/XX_LE_acBak)
1. [.NET API Middleware for common functionality](https://youtu.be/2QvUwxcHCBc)
1. [Endpoint filters for .NET APIs](https://youtu.be/wxS8nfMCN-4)
1. [Dependency injection for .NET APIs](https://youtu.be/LpBdpoHD50I)
1. [.NET APIs Recap & Resources](https://youtu.be/NJQxinaXk40)

## Overview

| **Goal**              | Build your first web APIs with ASP.NET Core                                    |
| ----------------------------- | --------------------------------------------------------------------- |
| **What will you learn**       | Introduction to Back-End Web Development with .NET using Minimal APIs and ASP.NET Core                                      |
| **What you'll need**          | [Visual Studio Code](code.visualstudio.com) with the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension and the [.NET SDK](https://dotnet.microsoft.com/download)|
| **Number of videos**          | 8                                                               |
| **Follow Along** | [sample-code](sample-code)                        |
                         

## Video

Full Series:

YouTube link: https://aka.ms/dotnet/beginnervideos/youtube/webapi

Learn link: https://aka.ms/dotnet/beginnervideos/learn/webapi

## Video 1: Introduction to APIs with .NET
The video introduces APIs in general and web APIs in particular and discusses the ASP.NET Core web framework. 
APIs, or Application Program Interfaces, are a way for applications to communicate with each other. Web APIs are APIs that communicate with each other over the internet.
ASP.NET Core is the technology this series focuses on. It is a cross-platform, high performance, and open-source application for building Web APIs.


Video link: [Introduction to APIs with .NET](https://youtu.be/OmUuR4GiwIE)
 
## Video 2: Hosting model for .NET APIs
This video introduces the minimal hosting models of web APIs in ASP.NET Core. In this video, Safia creates a new ASP.NET Core project template in Visual Studio Code (VS Code) then explores this new app's configuration in the Program.cs file. Program.cs will launch a host that's responsible for starting the application, configuring an underlying HTTP server, and setting up the pipeline for processing requests and responses over HTTP. 

Video link: [Hosting model for .NET APIs](https://youtu.be/r3ys7oL9izQ)

## Video 3: Implementing a Web API in .NET
This video covers implementing a CRUD web API for managing tasks in a to-do list with minimal APIs in ASP.NET Core. In ASP.NET Core, Minimal APIs allow us to describe how requests should be processed by a server using an entity known as an endpoint. Minimal APIs provide succinct methods for registering new endpoints to handle incoming requests in our web API.
In this video, Safia builds a Todo application with an API that follows the CRUD pattern of development. CRUD is an acronym that stands for Create, Read, Update, Delete. It describes the ways that users can interact with objects in an application.

Video link: [Implementing a Web API in .NET](https://youtu.be/FNLuegvqNak)

Resources:
- Tutorial: Create a minimal API with ASP.NET Core: https://learn.microsoft.com/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio 

## Video 4: Testing .NET Web APIs with .http files
This video covers testing web APIs locally using .http files and VS Code’s REST Client Extension. Safia will validate the implementation of the web API that she built for managing items in a Todo list.

Video link: [Testing .NET Web APIs with .http files](https://youtu.be/XX_LE_acBak)

**Note:** Download the [REST Client extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client)

Resources:
- VS Code REST Client Extension: https://marketplace.visualstudio.com/items?itemName=humao.rest-client 
 
## Video 5: .NET API Middleware for common functionality
This video covers implementing common behavior for ASP.NET Core APIs using middlewares. A middleware is a piece of code that can run before and after each request is processed. They run on all requests in a nested order. They're a super powerful way to execute common functionality on every request. ASP.NET Core comes with a collection of middlewares built in. We can also write our own middlewares. 

Video link: [.NET API Middleware for common functionality](https://youtu.be/2QvUwxcHCBc)

Resources:
- ASP.NET Core Middleware: https://learn.microsoft.com/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0 

## Video 6: Endpoint filters for .NET APIs
This video covers implementing common behavior for endpoints using endpoint filters. What if we want to execute common functionality on every request sent to a given endpoint in our application? That's where endpoint filters come in. Endpoint filters follow some of the same concepts that middlewares do. Though they are different because they have unique context on the endpoint associated with our request. One common scenario for endpoint filters is input validation.

Video link: [Endpoint filters for .NET APIs](https://youtu.be/wxS8nfMCN-4)
 
Resources:
- Filters in Minimal API apps: https://learn.microsoft.com/aspnet/core/fundamentals/minimal-apis/min-api-filters?view=aspnetcore-8.0 

## Video 7: Dependency injection for .NET APIs
This video covers support for dependency injection in ASP.NET Core and minimal APIs. Dependencies are objects that other objects can depend on; in ASP.NET Core, these are typically implemented as C# classes and interfaces. Dependencies are stored in the service container. Injection is the process by which a referenced dependency is resolved from the service container. This can happen when a class is constructed or in route handlers. In this video, Safia will utilize dependency injection to centralize the logic associated with the task management into a concrete implementation of ITaskService.

Video link: [Dependency injection for .NET APIs](https://youtu.be/LpBdpoHD50I)

Resources: 
-  Dependency injection in ASP.NET Core: https://learn.microsoft.com/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0

## Video 8: .NET APIs Recap & Resources
This video summarizes the topics discussed in the series and provides next learning steps. 

Video link: [.NET APIs Recap & Resources](https://youtu.be/NJQxinaXk40) 

## Feedback

Be sure to give [feedback about this workshop](https://aka.ms/dotnet/beginnervideos/feedback)!

[Code of Conduct](../CODE_OF_CONDUCT.md)

