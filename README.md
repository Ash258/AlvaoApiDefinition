# Alvao Custom Apps API Definition

[![NuGet](https://img.shields.io/nuget/v/Ash258.Alvao.Mock.API?label=Ash258.Alvao.Mock.API)](https://www.nuget.org/packages/Ash258.Alvao.Mock.API)

Unofficial C# API definitions for developing [ALVAO](https://www.alvao.com) custom applications with full IDE support: IntelliSense, signature help, inline documentation and compile-time checks.

> [!IMPORTANT]
> This project is **not affiliated with, endorsed by, or maintained by ALVAO s.r.o.**
> All definitions are generated from the publicly available [ALVAO API documentation](https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.html). Their correctness is not guaranteed.

## Overview

ALVAO custom applications are C# scripts that run inside ALVAO and use its API (`Alvao.API.*`, `Alvao.Apps.API`, `Alvao.Context`). These assemblies are not distributed publicly, so writing scripts outside ALVAO usually means working without type information.

This repository closes that gap:

- **`Ash258.Alvao.Mock.API`**: a NuGet package with every documented class, interface, enum, method and property. Doc comments link back to the official documentation.
- **Database schema**: the database models in `Alvao.API.Common.Model.Database` carry column types, nullability and foreign keys from the [database documentation](https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/). The full schema is also in [`DATABASE.md`](./Alvao/DATABASE.md), which ships in the package.
- **Examples**: the official [ALVAO application templates](https://doc.alvao.com/en/26/modules/alvao-am-custom-apps/applications/templates/) as compilable projects.
- **Generator**: the tool that scrapes the documentation and produces the package.

The package contains **definitions only**. Every method body throws `NotImplementedException`. It lets you write and compile scripts locally; the scripts still run inside ALVAO.

### Working with AI coding assistants

The package also makes ALVAO custom apps practical to write with AI coding assistants such as Claude Code, GitHub Copilot or Cursor. Without it, an assistant has to guess ALVAO's API from memory. With it, the assistant can:

- look up the real classes, signatures and doc comments of the ALVAO version you target
- write SQL against the real database schema (tables, column types, foreign keys) using [`DATABASE.md`](./Alvao/DATABASE.md) and the model doc comments
- compile its code and fix errors with `dotnet build` before you ever upload a script
- use the [examples](#examples) as working reference implementations

To get the best results, point the assistant at this package and the examples in your project instructions (e.g. `CLAUDE.md` or `.github/copilot-instructions.md`), and ask it to build after every change.

## Getting started

1. Create a class library for your custom application:

   ```bash
   dotnet new classlib --name MyCompany.Alvao.CustomApps
   cd MyCompany.Alvao.CustomApps
   ```

2. Add the libraries that ALVAO custom application scripts commonly use:

   ```bash
   dotnet add package Azure.Core
   dotnet add package Azure.AI.DocumentIntelligence
   dotnet add package AutoMapper
   dotnet add package Dapper
   dotnet add package Dapper.Contrib
   dotnet add package Microsoft.Data.SqlClient
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.Graph
   dotnet add package Newtonsoft.Json
   dotnet add package Volo.Abp.EntityFrameworkCore
   ```

3. Add the API definitions:

   ```bash
   dotnet add package Ash258.Alvao.Mock.API
   ```

4. Write your application, for example a periodic action:

   ```csharp
   using Alvao.Apps.API;
   using Alvao.Context;

   public class CloseStaleTickets : IPeriodicAction
   {
       public string Name { get; set; } = "Close stale tickets";

       public async Task OnPeriodAsync(CancellationToken cancellationToken)
       {
           using var scope = AlvaoContext.GetConnectionScope();
           // ...
       }
   }
   ```

5. Copy the finished scripts into your application in ALVAO.

### Versioning

The package version follows the ALVAO release it was generated from. The generator detects that release from the latest [release notes](https://doc.alvao.com/en/26/admin-guide/whats-new/1/) and stores it in [`.alvaorc`](./.alvaorc):

| Release notes | Package version |
| :--- | :--- |
| version 26.4 | `26.4.0` |
| version 26.4 Patch | `26.4.1` |

Use the package version that matches your ALVAO installation; signatures change between releases. In ALVAO 26, for example, most custom-app interfaces moved to `async` methods.

## Examples

The [`Examples`](./Examples/) folder contains every official ALVAO 26 application template, one folder per application:

| Example | Interface | Description |
| :--- | :--- | :--- |
| [ApproveByGroupMember](./Examples/ApproveByGroupMember/) | `ITicketAutoAction` | Adds a group member matching the requester's office or organization as an approver. |
| [AssignToSolverByEmail](./Examples/AssignToSolverByEmail/) | `IMailMessageAutoAction` | Assigns a ticket to the solver named in an `ASSIGNTO` command in an incoming email. |
| [AssignToTester](./Examples/AssignToTester/) | `ITicketAutoAction` | Passes resolved program modification tickets to a member of the Testers group. |
| [AutoCloseInactiveTickets](./Examples/AutoCloseInactiveTickets/) | `IPeriodicAction` | Closes resolved tickets that stay unclosed after the reopen period. |
| [CheckObjectMandatoryProperties](./Examples/CheckObjectMandatoryProperties/) | `IObjectMoveAutoAction` | Blocks moving objects with empty mandatory properties out of a storage room. |
| [CheckPhoneNumberFormat](./Examples/CheckPhoneNumberFormat/) | `IObjectPropertyAutoAction` | Validates the format of a new phone number property value. |
| [CopyNewPropertyValueToAnotherProperty](./Examples/CopyNewPropertyValueToAnotherProperty/) | `IObjectPropertyAutoAction` | Copies a new phone number into the empty Phone property of the same object. |
| [CreateAnalysis](./Examples/CreateAnalysis/) | `ITicketAutoAction` | Creates a linked design ticket when a program modification ticket is created. |
| [DeclineMessageSendCustomNotification](./Examples/DeclineMessageSendCustomNotification/) | `IMailMessageAutoAction` | Customizes the rejection notification sent when the sender has no SLA. |
| [MultilingualCommand](./Examples/MultilingualCommand/) | `IEntityCommand` | Shows how to build a multilingual application. |
| [OrderAfterApproval](./Examples/OrderAfterApproval/) | `ITicketApprovalAutoAction` | Moves a purchase ticket to the Order status once all approvers approve it. |
| [ReportProblem](./Examples/ReportProblem/) | `IGeneralCommand` | Adds a Report problem command to the main menu. |
| [SendMailsAboutNewEvent](./Examples/SendMailsAboutNewEvent/) | `IActAutoAction` | Emails service managers about new events on program modification tickets. |
| [SetComputerDetectionProfile](./Examples/SetComputerDetectionProfile/) | `IObjectMoveAutoAction` | Assigns the Standard scan profile to a computer moved out of a storage room. |
| [TicketCostsCalculation](./Examples/TicketCostsCalculation/) | `IEntityCommand` | Sums the SW Costs and HW Costs fields of matching tickets. |
| [TicketOpenAttachments](./Examples/TicketOpenAttachments/) | `IEntityCommand` | Adds a command that opens the link stored in the Attachments field. |
| [TicketShowRequesterAddress](./Examples/TicketShowRequesterAddress/) | `IEntityTab` | Adds a tab that shows the requester's organization address on a map. |
| [UpdateSuperiorGroup](./Examples/UpdateSuperiorGroup/) | `IPeriodicAction` | Fills a user group with the superiors of users from an organization. |

Each folder holds the scripts of one application and a `README.md` linking to the original template. To refresh the examples from the documentation, run [`Examples/ExportXmlIntoCs.ps1`](./Examples/ExportXmlIntoCs.ps1) (PowerShell 7). It downloads the templates for the version in `.alvaorc`.

## Development

### Prerequisites

- [.NET SDK 8](https://dotnet.microsoft.com/download) (pinned in [`mise.toml`](./mise.toml))
- [Task](https://taskfile.dev) for the build workflow
- [HTML Tidy](https://www.html-tidy.org) or Docker, used to normalize downloaded pages

### Repository layout

| Path | Contents |
| :--- | :--- |
| [`Program.cs`](./Program.cs), [`src/`](./src/) | Generator: scrapes the documentation and writes C# files |
| [`html/`](./html/) | Cached documentation pages (the generator reads these instead of downloading again) |
| [`overrides/`](./overrides/) | Hand-written files and data patches for anything the documentation does not cover |
| [`Alvao/`](./Alvao/) | Generated class library, packed as `Ash258.Alvao.Mock.API` |
| [`Examples/`](./Examples/) | Official application templates |

### Generating the library

```bash
task          # format, generate, tidy, build, pack
task r:c      # same, after removing the previously generated library
task r:c:h    # same, after also clearing the html cache (downloads everything again)
```

The generator can also run directly. Pass namespaces to process only those, and `ignore` to bypass the html cache:

```bash
dotnet run -- Alvao.API.AI Alvao.API.AI.Model
dotnet run -- ignore Alvao.API.SD
```

`task examples:build` builds every example project.

### How the definitions are generated

1. **Version and namespaces.** The release version is read from the release notes, and the namespace list from the API table of contents (`toc.json`). Every namespace page is read before any class is generated, so every documented type is known up front.
2. **Classes.** Each class page is parsed into its definition, constructors, properties, fields, events, methods and doc comments. Signatures are taken from the code blocks as written.
3. **Type resolution.** Types are resolved from the page itself, not from hand-maintained tables:
   - Usings and fully qualified names come from the `xref` links in parameter, return, inheritance and implements blocks. A link target contains the full type name. A type is written with its full name only when its short name would bind to a different type.
   - Types without a link are resolved from the member's `data-uid`, which contains fully qualified parameter types.
   - Undocumented ALVAO types referenced from documented pages are generated as empty stubs, so the library compiles.
4. **Database schema.** The database documentation adds column types, nullability, foreign keys and missing descriptions to the database models. It also generates models for tables without one and writes `Alvao/DATABASE.md`.
5. **Overrides.** Hand-written files from `overrides/` are copied over the generated output.

### Overrides

Anything the documentation cannot provide is kept in [`overrides/`](./overrides/) instead of in generator code:

- **`overrides/Alvao/**/*.cs`**: hand-written C# files that mirror the output tree, for example the `Alvao.Apps.API` interfaces (documented outside the API reference) and stubs that need members.
- **[`overrides/patches.json`](./overrides/patches.json)**: small data patches, namely usings needed by attributes, namespaces of unlinked types, members of implemented .NET interfaces, and text fixes for documentation quirks.

### Logging

Set the generator log level with an environment variable:

```bash
export Logging__LogLevel__AlvaoScrapper=1
```

| Level       | Value |
| :---------- | :---: |
| Trace       |   0   |
| Debug       |   1   |
| Information |   2   |
| Warning     |   3   |
| Error       |   4   |
| Critical    |   5   |
| None        |   6   |

The default is `4` (Error).

## License

The package is published under the MIT license. ALVAO is a trademark of ALVAO s.r.o.; all API documentation belongs to its respective owner.
