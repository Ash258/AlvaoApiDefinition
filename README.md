# Alvao Custom Apps API Definition

_This project is not anyhow affiliated or maintened by Alvao corporation._

Purpose of this repository is to scrape **publicly available** documentation of Alvao Custom Apps to make local development of Custom Apps easier with help of IDE suggestions of all possible methods/properties/...

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
   - Examples could be found in Examples folder.

## Logging levels

`export Logging__LogLevel__AlvaoScrapper=1`

| Name        | Value | Description |
| :---------- | :---: |
| Trace       |   0   |
| Debug       |   1   |
| Information |   2   |
| Warning     |   3   |
| Error       |   4   |
| Critical    |   5   |
| None        |   6   |
