<p align="center">
  <p align="center">
    <img src="https://raw.githubusercontent.com/hypeproxy/hypeproxy/main/logo.png" height="100" alt="HypeProxy.io" />
  </p>
  <h3 align="center">
    HypeProxy.io C# SDK
  </h3>
  <p align="center">
    This is the official C# library of HypeProxy.io.
  </p>
  <p align="center">
    <a href="hhttps://github.com/hypeproxy/hypeproxy-dotnet/actions"><img src="https://github.com/hypeproxy/hypeproxy-dotnet/actions/workflows/publish.yml/badge.svg" /></a>
    <a href="https://dotnet.microsoft.com"><img src="https://img.shields.io/badge/Made%20With-.NET%206-512bd4" /></a>
    <a href="https://www.nuget.org/packages/HypeProxy/"><img alt="Nuget" src="https://img.shields.io/nuget/v/HypeProxy"></a>
    <a href="https://github.com/hypeproxy/hypeproxy-dotnet/blob/master/LICENSE.md"><img src="https://img.shields.io/badge/license-MIT-lightgrey.svg" /></a>
  </p>
</p>

# Introduction

This project contains the official HypeProxy.io library for the use of our API and access to all your account data.

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

# Using HypeProxy CLI

We also provide a command line tool to perform operations on your account and proxies (like IP rotation etc), to install it you need to first install .NET 6 here: https://dotnet.microsoft.com/en-us/download.

And then execute this command:

```bash
dotnet tool install --global HypeProxy.Cli
```

To verify if `hypeproxy-cli` is successfully installed you can execute:

```bash
hypeproxy healthy
```

## Credits & Contribution

All our library and tools are provided in full opensource, you can also contribute by reading [this guide](CONTRIBUTING.md).
