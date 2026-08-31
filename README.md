[![](https://img.shields.io/nuget/v/soenneker.wise.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.wise.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.wise.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.wise.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.wise.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.wise.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.wise.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.wise.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Wise.OpenApiClient

A Kiota client for Wise profiles, quotes, recipients, transfers, balances, cards, and webhooks.

## Installation

```bash
dotnet add package Soenneker.Wise.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Wise.OpenApiClient;
using Soenneker.Wise.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", "your-access-token");

var authProvider = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient)
{
    BaseUrl = "https://api.wise.com/2026Q3"
};

var client = new WiseOpenApiClient(adapter);

List<Profile>? profiles = await client.Profiles.GetAsync();
Console.WriteLine($"Visible profiles: {profiles?.Count ?? 0}");
```

Use `https://api.wise-sandbox.com/2026Q3` with sandbox credentials. The client sends an existing personal or OAuth access token; obtaining and refreshing partner tokens remains the application's responsibility.
