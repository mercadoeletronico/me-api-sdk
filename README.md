# ME.Api.Sdk

ME.Api.Sdk is a C# SDK that simplifies integration with Mercado Eletrônico APIs and Webhooks. It provides built-in authentication, retry handling, and rate-limit management, enabling a smoother and more efficient integration experience. 

**APIs Reference:** [Mercado Eletrônico APIs](https://developer.me.com.br/)

## Framework Compatibility
The SDK supports multiple .NET frameworks to accommodate various project requirements:

- .NET Standard 2.0 (compatible with .NET Framework 4.6.1 and above)
- .NET Standard 2.1 (compatible with .NET Core 3.0 and above)
- .NET 6.0
- .NET 8.0

### Version 3.0.0 Changes
This major version introduces broader framework support through .NET Standard:
- Added support for .NET Standard 2.0 and 2.1, enabling usage in older .NET Framework projects
- Added support for .NET 8.0
- Optimized language features per framework version
- Updated package dependencies for cross-framework compatibility

### Framework-Specific Features
The SDK automatically adjusts its features based on your target framework:
- .NET Standard 2.0/.NET Framework: Basic functionality with traditional C# features
- .NET Standard 2.1: Enhanced type system and newer language features
- .NET 6.0/8.0: Full modern C# features including file-scoped namespaces and nullable reference types

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

### Migration from Previous Versions
When upgrading to version 3.0.0:
1. Review your target framework compatibility
2. Update package references to the latest version
3. If using .NET Standard 2.0/.NET Framework:
   - Ensure explicit `using` directives are present (no implicit usings)
   - Replace nullable reference type annotations if used
4. Test your integration thoroughly after upgrading

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
