# Personal Website

My [own website](https://peterkeating.co.uk) using [Orchard Core](https://github.com/orchardcms/OrchardCore).

## Status

[![Build Status](https://secure.travis-ci.org/peterkeating/personal-website.png?branch=master)](http://travis-ci.org/peterkeating/personal-website) [![Build Status](https://dev.azure.com/petekeating/peterkeating.co.uk/_apis/build/status/peterkeating.personal-website?branchName=master)](https://dev.azure.com/petekeating/peterkeating.co.uk/_build/latest?definitionId=1&branchName=master)

## Prerequisities

### [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/)

Orchard Core runs on the .NET Core. Download the latest version from [https://www.microsoft.com/net/download/core](https://www.microsoft.com/net/download/core).

## Running Locally

### CLI

Run the command shown below and then navigate to `https://localhost:5001` in your browser of choice where you'll be preesented with the Orchard setup page.

    dotnet run --project src/PK.OrchardCore.Website

### Visual Studio

Open the solution in Visual Studio and run the `PK.OrchardCore.Website` project. This will open your default browser and you'll be presented with the Orchard setup page.