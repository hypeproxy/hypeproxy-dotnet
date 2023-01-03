# Introduction

This is the official HypeProxy.io library for the use of our API and access to all your account data.

# Getting Started

First of all you need to install the latest version of our `HypeProxy` library with [NuGet](https://www.nuget.org/packages/HypeProxy/#readme-body-tab), to do this do :

```bash
dotnet add package HypeProxy
```

## Sign-in Example and consuming the API:

```cs
var client = new HypeProxyClient();

// Check if API is healthy or not;
await client.HealthyAsync();

// Sign-in to the API.
await client.SignInAsync("email@gmail.com", "Passw0rd");

// List all products.
var products = await client.Products.FindAsync();

// Do another something
```
