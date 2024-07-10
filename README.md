# Alvao Custom Apps API Definition

_This project is not anyhow affiliated or maintened by Alvao corporation._

Purpose of this repository is to scrape **publicly available** documentation of Alvao Custom Apps to make local development of Custom Apps easier with help of IDE suggestions of all possible methods/properties/...

It is not ideal as Alvao is being compiled with Dotnet Framework and not Dotnet core, so you can face with false positive error about missing functions. But everything can be fixed locally (Using extension methods and so on...) in files that will not be copied to Alvao script file.

## How to use

1. Create new dotnet project
    1. `dotnet new console --name custom.app.development`
    1. `cd custom.app.development`
1. Add required packages

    ```bash
    dotnet add package AutoMapper
    dotnet add package Dapper
    dotnet add package Dapper.Contrib
    dotnet add package Microsoft.Data.SqlClient
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Newtonsoft.Json
    dotnet add package Volo.Abp.EntityFrameworkCore
    dotnet add package Smatlactvo.Mock.AlvaoAP
    dotnet add package Microsoft.Graph
    ```

1. Create new application class and implement it.
   - Example could be found in [ExampleEmailSendingOnTicketCreation.cs](./ExampleEmailSendingOnTicketCreation.cs)
   - Additional examples are avialable on [Alvao documentation site](https://doc.alvao.com/en/11.2/modules/alvao-sd-custom-apps/applications)
