# Machine Learning and AI with .NET for Beginners

Calling all .NET developers! Dive headfirst into the future with our .NET Machine Learning and AI for Beginners Series. Discover the seamless integration of Artificial Intelligence (AI) and Machine Learning (ML) into your .NET applications, unlocking a world of possibilities. From grasping foundational concepts to hands-on sessions with ChatGPT, Azure AI Services, and ML.NET, you'll acquire the skills to craft intelligent, responsive applications. Join us on this journey and revolutionize your .NET applications using the limitless potential of AI and ML!


## Video Series Link

Full Series:
YouTube link: https://aka.ms/dotnet/beginnervideos/youtube/ai 

Learn link:https://aka.ms/dotnet/beginnervideos/learn/ai

Individual Video Links:
1. [Introduction](https://youtu.be/vISLS8aY0RU)
1. [What is AI and ML?](https://youtu.be/Len8KRBFvGo)
1. [Introduction to ChatGPT](https://youtu.be/138LP5oztVg)
1. [Prompts & Prompt Engineering](https://youtu.be/0KuZJsm84-k)
1. [Adding context to your prompts](https://youtu.be/cNtBT2CsVIk)
1. [Introduction to ChatGPT Plugins](https://youtu.be/e3rO5W0q6q8)
1. [Introduction to Azure AI Services](https://youtu.be/YPwjd5oEZMc)
1. [Training custom models with Azure AI Services](https://youtu.be/DbooMAyhfL8)
1. [Introduction to ML.NET](https://youtu.be/wy4TyzGhXyw)
1. [Introduction to AutoML](https://youtu.be/Wmybg70CW9A)
1. [Train your own custom ML model using ML.NET](https://youtu.be/ji1hrvVfrhY)
1. [Deploy your custom ML.NET model](https://youtu.be/eaAIJQWp_FY)

## Overview

In this video series, we will discuss Machine Learning and AI for .NET.

| **Goal**              | Learn how to get started building AI applications             |
| ----------------------------- | --------------------------------------------------------------------- |
| **What will you learn**       | Azure OpenAI, Azure AI Services, ML.NET                                         |
| **What you'll need**          | [Prerequisites](#prerequisites) |
| **Number of videos**                  | 12                                                                |
| **Follow along**                  | [Code](./sample-code/)                                                                |
| **Slides** | [Powerpoint](./DotNet_Beginner_ML_Series_2023.pptx) |

## Prerequisites

- **Azure Account** - If you're new to Azure, get an [Azure account for free](https://azure.microsoft.com/free/students/) and you'll get some free Azure credits to get started.
- **Azure subscription with access enabled for the Azure OpenAI service** - [You can request access](https://learn.microsoft.com/azure/ai-services/openai/overview#how-do-i-get-access-to-azure-openai). 
    
    > **IMPORTANT**
    > You'll also need two model deployments. See the create a resource guide for more details on [deploying models](https://learn.microsoft.com/azure/ai-services/openai/how-to/create-resource?pivots=web-portal#deploy-a-model). These samples use [GPT 3.5](https://learn.microsoft.com/azure/ai-services/openai/concepts/models#gpt-35) and [embedding](https://learn.microsoft.com/en-us/azure/ai-services/openai/concepts/models) models. For more details, see the [Azure OpenAI model guide](https://learn.microsoft.com/azure/ai-services/openai/concepts/models).   

- [**Azure Document Intelligence resource**](https://learn.microsoft.com/azure/ai-services/document-intelligence/create-document-intelligence-resource?view=doc-intel-2.1.0)
- [**Azure Custom Vision resource**](https://portal.azure.com/?microsoft_azure_marketplace_ItemHideKey=microsoft_azure_cognitiveservices_customvision#create/Microsoft.CognitiveServicesCustomVision)
- [**GitHub Account**](https://github.com/join)
- [**Visual Studio 2022**](https://visualstudio.microsoft.com/downloads/)
    - [Model Builder Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=MLNET.ModelBuilder2022)
- [**Visual Studio Code**](https://code.visualstudio.com/Download)
    - [Polyglot Notebooks extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)
- [**(Optional) ML.NET CLI**](https://learn.microsoft.com/dotnet/machine-learning/how-to-guides/install-ml-net-cli?tabs=linux)

## Quick Start

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/dotnet/beginner-series)

## Setup

Some of the samples require Azure Services so you'll need to set the following environment variables:

- Azure OpenAI - See the [retrieve key and endpoint guide](https://learn.microsoft.com/azure/ai-services/openai/tutorials/embeddings?tabs=python%2Ccommand-line#retrieve-key-and-endpoint) for more details.
    - **AOAI_DEPLOYMENTID**: The name of your GPT model deployment.
    - **AOAI_EMBEDDINGS_DEPLOYMENTID**: The name of your embedding model deployment.
    - **AOAI_ENDPOINT**: Your Azure OpenAI endpoint
    - **AOAI_KEY**: Your Azure OpenAI Key
- Azure Document Intelligence - See the [get endpoint URL and keys guide](https://learn.microsoft.com/azure/ai-services/document-intelligence/create-document-intelligence-resource?view=doc-intel-3.1.0#get-endpoint-url-and-keys) for more details.
    - **DOCUMENT_KEY**: Your Document Intelligence Key
    - **DOCUMENT_ENDPOINT**: Your Document Intelligence Endpoint
- Azure Custom Vision - See the [create environment variables guide](https://learn.microsoft.com/azure/ai-services/custom-vision-service/quickstarts/image-classification?tabs=linux%2Cvisual-studio&pivots=programming-language-csharp#create-environment-variables) for more details on how to get these values. 
    - **VISION_TRAINING_KEY**: Your Azure Custom Vision training resource key
    - **VISION_TRAINING_ENDPOINT**: Your Azure Custom Vision training endpoint.
    - **VISION_PREDICTION_KEY**: The key for your Azure Custom Vision predicion resource
    - **VISION_PREDICTION_ENDPOINT**: Your Azure Custom Vision prediction resource key.
    - **VISION_PREDICTION_RESOURCE_ID**: The resource ID for your prediction resource.

### Codespaces

1. Open [*.devcontainer/ai/devcontainer.json*](../.devcontainer/ai/devcontainer.json)
1. Replace the blank environment variable values in the `containerEnv` section with your own.
1. Save your changes
1. Rebuild the container
    1. Open the command palette. In the menu bar, select **View > Command Palette**.
    1. Enter the following command into the command palette **>Codespaces: Rebuild Container**.                         

## Video

Full Series:

YouTube link: https://aka.ms/dotnet/beginnervideos/youtube/ai 

Learn link: https://aka.ms/dotnet/beginnervideos/learn/ai

## Additional Resources

- .NET Machine Learning and AI for Beginners Samples: https://aka.ms/dotnet-ai-beginner
- Intelligent App Sample: https://aka.ms/dotnet-ai-app
- Azure OpenAI Service documentation: https://learn.microsoft.com/azure/ai-services/openai/
- Azure AI Services documentation: https://learn.microsoft.com/azure/ai-services/
- ML.NET Documentation: https://learn.microsoft.com/dotnet/machine-learning/
- .NET YouTube - https://youtube.com/dotnet

## Video 1 : Introduction

In this video, we provide an introduction and overview of the topics that will be coverted throughout the series.

[Introduction](https://youtu.be/vISLS8aY0RU)

## Video 2 : What is AI and ML?

In this video, we go over what AI and Machine Learning are, what you can do with AI and ML, and how you as a .NET developer can get started using AI and Machine Learning in your applications.

[What is AI and ML?](https://youtu.be/Len8KRBFvGo)

## Video 3 : Introduction to ChatGPT

In this video, we discuss what ChatGPT is, define ChatGPT chat roles, learn about the role of chat and message history, and get started using ChatGPT in .NET.

[Introduction to ChatGPT](https://youtu.be/138LP5oztVg)

## Video 4 : Prompts & Prompt Engineering

In this video, we learn what prompts and prompt enginnering are, provide an overview of the different parts of a prompt, give tips for improving your prompts, and show these techniques in action.

[Prompts & Prompt Engineering](https://youtu.be/0KuZJsm84-k)


## Video 5 : Adding context to your prompts

In this video, we go over how you can use your data to provide more context to language models like ChatGPT to help augment and provide more relevant responses. We also introduce a pattern known as Retrieval Augmented Generation (RAG).

[Adding context to your prompts](https://youtu.be/cNtBT2CsVIk)

## Video 6 : Adding context to your prompts

In this video, we introduce what ChatGPT Plugins are and how they can be used to extend the functionality of language models. We then show how you can get started building and testing ChatGPT Plugins using .NET.

[Introduction to ChatGPT Plugins](https://youtu.be/e3rO5W0q6q8)

## Video 7 : Introduction to Azure AI Services

In this video, we introduce Azure AI Services, give some examples of what you can use them for, and then show how you can get started using them in your AI applications.

[Introduction to Azure AI Services](https://youtu.be/YPwjd5oEZMc)

## Video 8 : Training custom models with Azure AI Services

In this video, we go over why you might want to train your own custom AI models and then show how to do so using Azure AI Services and .NET.

[Training custom models with Azure AI Services](https://youtu.be/DbooMAyhfL8)

## Video 9 : Introduction to ML.NET

In this video, we introduce ML.NET, an open-source, cross-platform ML framework for .NET. We then show what you can do with ML.NET and how it integrates with the rest of the .NET ML ecosystem.

[Introduction to ML.NET](https://youtu.be/wy4TyzGhXyw)

## Video 10 : Introduction to AutoML

In this video, we introduced Automated Machine Learning (AutoML). We'll show how AutoML can help automate repetitive tasks in the machine learning model development workflow and how you can get started using AutoML techniques in .NET.

[Introduction to AutoML](https://youtu.be/Wmybg70CW9A)

## Video 11 : Introduction to ML.NET

In this video, we introduce Model Builder, a Visual Studio extension for training custom ML models using ML.NET. We then show how to get started training your own custom ML model using using Model Builder.

[Train your own custom ML model using ML.NET](https://youtu.be/ji1hrvVfrhY)

## Video 12 : Deploy your custom ML.NET model

In this video, we'll show how you can use Model Builder to generate an application that consumes your custom ML model. We'll then show how you can test your model locally and deploy it to Azure.

[Deploy your custom ML.NET model](https://youtu.be/eaAIJQWp_FY)

## Feedback

Be sure to give [feedback about this workshop](https://aka.ms/dotnet/beginnervideos/feedback)!

[Code of Conduct](../CODE_OF_CONDUCT.md)

