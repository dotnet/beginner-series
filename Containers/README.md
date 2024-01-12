# Containers with .NET and Docker for Beginners

Containers are a popular way of packaging and distributing applications in today’s Cloud Native landscape – but what are they, and how can .NET developers integrate them into their workflows? In this introductory series you’ll learn about Docker, Containers, and the tooling available in .NET to help make the whole process effortless!

## Video Series Link

Full Series:
YouTube link: https://aka.ms/dotnet/beginnervideos/youtube/containers 

Learn link: https://aka.ms/dotnet/beginnervideos/learn/containers

Individual Video Links:
1. [What's the deal with .NET & Containers?](https://youtu.be/HA8rpDWMRq0)
1. [Making great containers with .NET, Visual Studio, and Visual Studio Code](https://youtu.be/qCxSYymD0ug)
1. [Publishing your .NET containers everywhere!](https://youtu.be/21zduERRS3M) 

## Overview

In this video series, we will discuss Containers with .NET and Docker.

| **Goal**                | Introduction to .NET Containers                                                                                                                                                                                                                                                                |
| ----------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **What will you learn** | Introduction to .NET containers, how to make great containers, and how to publish .NET containers everywhere                                                                                                                                                                                   |
| **What you'll need**    | [VS Code](code.visualstudio.com) or [Visual Studio](https://visualstudio.microsoft.com/downloads/), [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) and [Docker](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker) extensions if you use VS Code, [.NET SDK](https://dotnet.microsoft.com/download), [Docker](https://docs.docker.com/get-docker/) |
| **Number of videos**    | 3                                                                                                                                                                                                                                                                                              |
| **Follow along**        | [sample code](./sample-code/)                                                                                                                                                                                                                                                                  |

## Video

YouTube link: https://aka.ms/dotnet/beginnervideos/youtube/containers 

Learn link: https://aka.ms/dotnet/beginnervideos/learn/containers

## Resources

- Microsoft Learn for Cloud Native & Containers: https://learn.microsoft.com/training/paths/create-microservices-with-dotnet/
- Introduction to Docker: https://learn.microsoft.com/dotnet/core/docker/introduction
- Containerize a .NET App with dotnet publish: https://learn.microsoft.com/dotnet/core/docker/publish-as-container
- Docker for VS Code: https://code.visualstudio.com/docs/containers/overview
- Containers workshop: https://github.com/richlander/container-workshop

## Video 1 : What's the deal with .NET and Containers?

This video grounds the Containers topic in a few key questions: 

- What are they used for? 
- Where can they be used? 
- How do they work? 
- Why would I use them instead of other techniques? 

We will talk about Containers vs VMs (virtual machines), containers as the ‘base language’ of the cloud and highlight popular cloud platforms/tools that run via Containers as evidence that developers should learn how to use Containers. From there, we will pivot to a brief examination of how containers work – we will go over the concept of wrapping an application up with data that describes how to run it, and talk about how this strategy enables tooling and teams to operate with a shared baseline understanding of the application. 

Once we have established how necessary Containers are, we will end with a very quick 'zero-to-containerized' demo of the .NET SDK Container tools, packaging an existing application into a container.

[What's the deal with .NET & Containers?](https://youtu.be/HA8rpDWMRq0)

## Video 2 : Making great containers with .NET, Visual Studio, and Visual Studio Code

This video will be all about our tooling offerings and how they come together to make .NET a great platform work working with Containers – and how the Containers built by our tooling are best-in-class. 

We will start where we left off – making containers with the .NET SDK. We will talk about what the SDK has done to make that container and how the tooling adapts and grows with your application – considering the kind of application and deployment models the developer has chosen. We will show some of the customization options that the user has, including changing the base image and adding custom environment variables.  We will show how tooling integrates deeply with the generated container, showing debugging in Visual Studio Code. Then, we will talk about what you as a developer can do when you need more control – we will ‘eject’ to a Dockerfile-based build and talk about What, When, and Why of making the switch to Dockerfiles. We will show that the tooling works great no matter how you make your containers. 

[Making great containers with .NET, Visual Studio, and Visual Studio Code](https://youtu.be/qCxSYymD0ug)

## Video 3 : Publishing your .NET containers everywhere!

This final video will cover deployment – we will switch to Visual Studio and show how the VS tooling helps guide you to a repeatable deployment process for both .NET SDK-built containers, as well as Dockerfile-based containers. We will focus on the scaffolded GitHub Actions CI/CD flow for deploying the application, drawing parallels between what that code does and the commands/demos that we showed earlier in the series. 

We will wrap with a summary/reinforcement that across the Visual Studio family of products for .NET we have tools to help you create, develop, and deploy best-in-class containerized applications. 

[Publishing your .NET containers everywhere!](https://youtu.be/21zduERRS3M)

## Feedback

Be sure to give [feedback about this workshop](https://aka.ms/dotnet/beginnervideos/feedback)!

[Code of Conduct](../CODE_OF_CONDUCT.md)

