# ME.Api.Sdk

ME.Api.Sdk is a C# SDK that simplifies integration with Mercado Eletrônico APIs and Webhooks. It provides built-in authentication, retry handling, and rate-limit management, enabling a smoother and more efficient integration experience. 

**APIs Reference:** [Mercado Eletrônico APIs](https://developer.me.com.br/)

## Requirements
.NET 6.0 or higher

## Installation

To install the **ME.Api.Sdk**,  use NuGet Package Manager with the following command:

```bash
dotnet add package ME.Api.Sdk
```

Alternatively, you can search for **ME.Api.Sdk** in the NuGet Package Manager in Visual Studio.

# Getting Started

## Dependency Injection Setup

To integrate the SDK into your application, you need to configure it through Dependency Injection (DI). Add the following code in your application's DI setup (typically in **Program.cs** or **Startup.cs**):

```csharp

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMEApiClient(builder.Configuration);

// Retrieve the IMEApiClient from the service provider
var apiClient = serviceProvider.GetService<IMEApiClient>(); 

```

## Configuration

Ensure that your `appsettings.json` file contains the required API settings:
```json
{
  "MEApiSettings": {
    "BaseAddress": "https://api.mercadoe.com",
    "ClientId": "ClientId",
    "ClientSecret": "ClientSecret"
  }
}
```

This configuration allows the SDK to authenticate requests automatically.

## Direct Instantiation (Optional)

If you prefer not to use Dependency Injection, you can instantiate the client directly:

```csharp
var settings = new MEApiSettings
{
    BaseAddress = "https://api.mercadoe.com",
    ClientId = "ClientId",
    ClientSecret = "ClientSecret"
};
var apiClient = new MEApiClient(settings);
```

## Usage
To interact with the APIs, inject the `IMEApiClient` and enjoy!

```csharp
app.MapGet("/", async (IMEApiClient api, CancellationToken ctx) =>
{
   var preOrder = await api.PreOrderClient.GetPreOrderAsync(
     new GetPreOrderRequest { PreOrderId = "your_preorder_id" }
     , cancellationToken);
  return Ok(preOrder);
});
```

## Features
- Integrated Authentication: Easily manage OAuth 2.0 authentication flows.
- Retry Policies: Automatic retries on transient failures.
- Rate-Limit Control: Manage API request limits effectively.
For more details on the available API endpoints and usage examples, refer to the [Mercado Eletrônico API documentation](https://developer.me.com.br/)