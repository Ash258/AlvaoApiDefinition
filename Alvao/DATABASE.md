# ALVAO database tables

ALVAO 26.4.1 database schema, generated from the [ALVAO documentation](https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/).
Tables with a model in `Alvao.API.Common.Model.Database` can be loaded with Dapper (`[Table]` attribute).

> [!CAUTION]
> Unofficial, not affiliated with ALVAO s.r.o. Correctness is not guaranteed.

## Apps.App

Application.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Application ID. |
| `Name` | nvarchar(255), not null |  | Application name. |
| `Description` | nvarchar(max), null |  | Application description. |
| `IsEnabled` | bit, not null |  | If the application is enabled. 1 = enabled, 0 = disabled. |
| `UniqueId` | uniqueidentifier, null |  | Application global identification (GUID). |
| `Version` | int, not null |  | Application version. |
| `AdvancedSettings` | nvarchar(max), null |  | Application advanced settings. |

## Apps.Script

Application scripts.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Script ID. |
| `AppId` | int, not null | `Apps.App` | Application ID. |
| `Name` | nvarchar(255), not null |  | Script name. |
| `Code` | nvarchar(max), null |  | Source code of the script. |
| `IsCompilable` | bit, not null |  | Whether the source code can be compiled. 1 = yes, 0 = no. |
| `LastChanged` | datetime, null |  | The date the script was last modified. |
| `IsLibCode` | bit, not null |  | If the code is library. 1 = yes, 0 = no. |
| `Codesign` | nvarchar(2048), null |  | Certified script integrity check value. |
| `Warning` | bit, not null |  | 1 = the script contains at least one warning, 0 = no warnings in the script. |

## dbo.ActMark

Marking the record in the ticket log.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | tinyint, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Record marking name |

## dbo.ActOperation

Kind of process in the ticket log

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Process kind name |

## dbo.AdTrustedDomain

List of trustworthy domains.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `DomainName` | nvarchar(128), not null |  | Domain name in a "dot" notation. |
| `Hostname` | nvarchar(32), not null |  | Network name of server where the domain controller is running. |
| `Order` | int, not null |  | Order in which ImportAD will try the servers of the replicated controller of the same domain. |
| `Skip` | bit, not null |  | 1=skip elements from this domain during import. |

## dbo.AlvaoModule

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `Name` | nvarchar(255), not null |  |  |

## dbo.AlvaoServiceSettings

Alvao Service settings.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `AutoLoadActive` | bit, not null |  |  |
| `AutoLoadFolder` | nvarchar(1024), null |  |  |
| `AutoLoadDeleteOnSucc` | bit, not null |  |  |
| `AutoloadDeleteOnFail` | bit, not null |  |  |
| `AutoLoadStorageConString` | nvarchar(1024), null |  | Connection string of MS Azure storage account. The Alvao Service will automatically load detection data from this storage. |
| `DetAfterErrorMinutes` | int, not null |  |  |
| `DetAfterPcOffMinutes` | int, not null |  |  |
| `SchedEvalActive` | bit, not null |  |  |
| `SchedEvalTimeFrom` | float, null |  |  |
| `SchedEvalTimeTo` | float, null |  |  |
| `SchedEvalDayExc` | int, null |  |  |
| `SwLibDownloadLib` | bit, not null |  | The Alvao Service will automatically update the SW product library from the Internet. If the option is enabled, it will take precedence over updating from the folder. |
| `SwlibEvalAllDetAfterDownload` | bit, not null |  |  |
| `SwlibCheckNewLibDays` | int, null |  |  |
| `SwLibLoadFromPath` | nvarchar(1024), null |  | The folder from which the new version of SW products library is uploaded. |
| `SwLibSearchUnknownSW` | bit, not null |  |  |
| `SwlibSendAnon` | bit, not null |  |  |
| `SwLibSendContactEmail` | nvarchar(255), null |  |  |

## dbo.ArticleChunk

Chunked text content of knowledge base articles.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ArticleId` | int, not null | `dbo.tArticle` | Article ID. |
| `ChunkId` | int, not null |  | Chunk ID. |
| `EmbeddingModelId` | int, not null | `dbo.EmbeddingModel` | Used embedding model for vectors. |
| `Time` | datetime, null |  | Time of ContentVector change. |
| `Content` | nvarchar(max), not null |  | Text content of the chunk. |
| `ContentVector` | vector, null |  | Vector used to compare the similarity of text in the article. |

## dbo.ArticleHdSection

Assigning articles from the knowledge base to services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `ArticleId` | int, null | `dbo.tArticle` |  |
| `SectionId` | int, null | `dbo.tHdSection` |  |

## dbo.ArticleLoc

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `ArticleId` | int, not null | `dbo.tArticle` |  |
| `LocaleId` | int, not null | `dbo.tLocale` |  |
| `Name` | nvarchar(1024), null |  |  |
| `Annotation` | nvarchar(max), null |  |  |
| `Text` | nvarchar(max), null |  |  |
| `HtmlText` | nvarchar(max), null |  |  |

## dbo.AssetAssignmentSettings

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | tinyint, not null |  |  |
| `RequireReceptionConfirmation` | bit, not null |  |  |
| `ReceptionConfirmationSubject` | nvarchar(255), null |  |  |
| `ReceptionConfirmationText` | nvarchar(max), null |  |  |
| `GeneratePdfByConfirmation` | bit, not null |  |  |
| `ConfirmationPrintReportTemplateId` | int, null | `dbo.PrintReportTemplate` |  |
| `SendNotificationOfReturnedAsset` | bit, not null |  |  |
| `NotificationOfReturnedAssetSubject` | nvarchar(255), null |  |  |
| `NotificationOfReturnedAssetText` | nvarchar(max), null |  |  |
| `NotificationOfReturnedAssetPrintReportTemplateId` | int, null | `dbo.PrintReportTemplate` |  |

## dbo.AssetCheckSettings

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | tinyint, not null |  |  |
| `AssetConfirmationByResponsibleUsers` | bit, not null |  |  |
| `SendNotificationForConfirmation` | bit, not null |  |  |
| `ConfirmationNotificationSubject` | nvarchar(255), null |  |  |
| `ConfirmationNotificationText` | nvarchar(max), null |  |  |

## dbo.AutomaticMonitorCreation

Settings for tracking computer monitors.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | tinyint, not null |  | Record ID. |
| `IsEnabled` | bit, not null |  | Settings is enabled or disabled. |
| `CreateAnywhere` | bit, not null |  | If enabled, monitors can be created anywhere. |
| `PlaceAlongside` | bit, not null |  | If enabled, monitors are created alongside a computer, otherwise under a computer. |

## dbo.AutomaticMonitorCreationException

Object type IDs under which monitors are created in opposite to default placement.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `ClassId` | int, not null | `dbo.tblClass` | Object class ID (tblClass.intClassId). |

## dbo.AutomaticMonitorCreationScope

Object IDs under which monitors can be created.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `ParentNodeId` | int, not null | `dbo.tblNode` | Parent object ID (tblNode.intNodeId). |

## dbo.AutomaticRepliesSettings

Automatic replies settings for MS Entra ID users.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID |
| `PersonId` | int, not null | `dbo.tPerson` | Person ID (tPerson.iPersonId) |
| `StatusId` | int, not null | `dbo.AutomaticRepliesStatus` | Status ID (AutomaticRepliesStatus.Id) |
| `ScheduledStart` | datetime, null |  | Scheduled start (UTC) |
| `ScheduledEnd` | datetime, null |  | Scheduled end (UTC) |
| `InternalReplyMessageHtml` | nvarchar(max), null |  | Internal reply message |
| `LastUpdate` | datetime, null |  | Last synchronization timestamp |

## dbo.AutomaticRepliesStatus

Automatic replies statuses.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID: 1 - Disabled 2 - Always enabled 3 - Scheduled |
| `Name` | nvarchar(255), not null |  | Status name |

## dbo.AzureAdTenant

The table of Azure Active Directory tenants from which users are imported.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `AzureTenantId` | nvarchar(40), not null |  | Folder ID in Azure |
| `Name` | nvarchar(max), not null |  | Tenant name. |
| `ScimSecretTokenHash` | nvarchar(255), null |  | Hash of the secret token for SCIM. |
| `ScimSecretTokenHashLastGenerated` | datetime, null |  | Date of the last SCIM token hash generation. |
| `UserPortraits` | bit, not null |  | User portraits are imported from Entra. |
| `UserPresence` | bit, not null |  | User presence is imported from Entra. |
| `Intune` | bit, not null |  | Devices are imported from Intune. |
| `ImportUserObjects` | bit, not null |  | User objects are imported. |
| `UseOrganizationStructure` | bit, not null |  | Use organizational structure. |
| `KnowledgeBaseSharepointIndex` | bit, not null |  | Enable vector index for Knowledge Base with SharePoint files. |
| `M365Licenses` | bit, not null |  | Licenses are imported from Microsoft 365. |
| `AutomaticReplies` | bit, not null |  | Automatic replies are imported from MS Outlook. |
| `Calendar` | bit, not null |  | Calendars are imported from MS Outlook. |
| `Shifts` | bit, not null |  | Shifts are imported from MS Teams. |

## dbo.Calendar

Solvers calendars imported from MS Outlook.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `PersonId` | int, not null | `dbo.tPerson` | Person ID (tPerson.iPersonId). |
| `LastUpdate` | datetime, not null |  | Last update timestamp (UTC). |
| `ODataDeltaLink` | nvarchar(2048), null |  | OData link to the next delta. |
| `ODataDeltaLinkStart` | datetime, null |  | OData link window start timestamp (UTC). |
| `ODataDeltaLinkEnd` | datetime, null |  | OData link window end timestamp (UTC). |

## dbo.CalendarEvent

Events in solvers calendars imported from MS Outlook.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | bigint, not null |  | Record ID. |
| `CalendarId` | int, not null | `dbo.Calendar` | Calendar ID (Calendar.Id). |
| `GraphEventId` | nvarchar(255), not null |  | Event ID in Graph API. |
| `GraphSeriesMasterId` | nvarchar(255), null |  | ID of the series master event in Graph API. |
| `Start` | datetime, not null |  | Start of the event (UTC). |
| `End` | datetime, not null |  | End of the event (UTC). |
| `ShowAsId` | tinyint, not null | `dbo.CalendarEventShowAs` | Availability status of the event (CalendarEventShowAs.Id). |
| `IsAllDay` | bit, not null |  | Indicates whether the event lasts all day. |

## dbo.CalendarEventShowAs

Availability statuses of the calendar event.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | tinyint, not null |  | Record ID: 1 - Unknown 2 - Free 3 - Tentative 4 - Busy 5 - Out of office 6 - Working elsewhere |
| `Name` | nvarchar(255), not null |  | Name of the status. |

## dbo.ChatModel

Settings for AI chat completion models

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `DeploymentName` | nvarchar(64), not null |  | Name of model deployment |
| `ModelName` | nvarchar(64), not null |  | Name of model |
| `IsEnabled` | bit, not null |  | Status of chat completions model |

## dbo.ChatModelPrompt

Prompt texts for specific chat completion models

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ChatModelId` | int, not null | `dbo.ChatModel` | Chat model ID. |
| `PromptId` | int, not null |  | Prompt ID: 1 - Ticket Summary 2 - Ticket Keywords 3 - Ticket Solution Proposal 4 - Ticket Description 5 - Chatbot |
| `Text` | nvarchar(max), not null |  | Prompt text |

## dbo.ClassKind

Definition of properties for object class

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ClassId` | int, not null | `dbo.tblClass` | ID of object class (tblClass.intClassId) |
| `KindId` | int, not null | `dbo.tblKind` | ID of object property (tblKind.intKindId) |

## dbo.ColumnValueLoc

Cache of value list item localizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ColumnValueId` | int, not null |  | Value list item ID. |
| `ColumnId` | int, not null |  | Custom field ID. |
| `LocaleId` | int, not null |  | Language ID. |
| `ColumnValue` | nvarchar(max), not null |  | Localized item value. |
| `ColumnValueShort` | nvarchar(max), not null |  | Localized reduced item value. |

## dbo.ConnectionToken

Valid safety token table.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `Token` | varchar, not null |  | Token. |
| `ValidTo` | datetime, not null |  | Valid to. |

## dbo.CustomThemeProperty

Property of the custom theme.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(30), not null |  | Name of the theme property. |
| `Value` | nvarchar(30), not null |  | Value of the theme property. |

## dbo.DataPack

Data packages inserted by database updates

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | nvarchar(128), not null |  | Data package identifier |
| `InsertedDate` | datetime, not null |  | Date of insertion |

## dbo.DataQuery

Data query defined by an SQL query

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Query name |
| `Description` | nvarchar(max), null |  | Description |
| `SqlQuery` | nvarchar(max), null |  | SQL query |
| `IsEnabled` | bit, not null |  | 1 = the query is enabled, 0 = disabled. |
| `ErrorMessage` | nvarchar(max), null |  | Error message at the last SQL script run. |
| `Hidden` | bit, not null |  |  |
| `ShowItemsInTotal` | bit, not null |  |  |

## dbo.DataQueryPermission

Permission to run a Data query.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `DataQueryId` | int, not null | `dbo.DataQuery` | DataQuery (DataQuery.id) |
| `RoleId` | int, null | `dbo.tRole` | Role (tRole.iRoleId) |
| `PersonId` | int, null | `dbo.tPerson` | Person (tPerson.iPersonId) |

## dbo.DetectEventLog

Detected events from the Event log of computers

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `DetectId` | int, not null | `dbo.tblDetect` | Detection ID |
| `EventDate` | datetime, null |  | Event date and time (UTC) |
| `EventID` | int, null |  | Event ID in the Event log |
| `Message` | nvarchar(max), null |  | Event text |

## dbo.DetectMethod

Detection method (e.g. autonomous Agent, MS SCCM, ...)

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `BehaviorId` | int, not null |  | Behavior from the system perspective: 0=Custom detection method, 1=Automatically, 2=Autonomous Agent, 6=MS SCCM, 7=Manually |
| `Name` | nvarchar(64), null |  | Name of the detection method. |
| `Custom1` | nvarchar(1024), null |  | Field for user data, usually identifier of the custom detection method. |

## dbo.DetectProfile

Detection profiles

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `ProfileName` | nvarchar(64), not null |  | Profile name |
| `DefaultProfile` | bit, not null |  | Default profile |
| `DetectPeriod` | int, null |  | Period of automatic detection planning |
| `HwMethodId` | int, null | `dbo.DetectMethod` | HW detection method ID |
| `SwMethodId` | int, null | `dbo.DetectMethod` | SW detection method ID |
| `SwIsFull` | bit, not null |  | Full SW detection |
| `SwIncludeFiles` | nvarchar(255), null |  | Full SW detection, include files |
| `SwExcludeFiles` | nvarchar(255), null |  | Full SW detection, skip files |

## dbo.DetRegUninstall

Detected registry entries. The table contains records which may differ in various computers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | bigint, not null |  | Record ID. |
| `DetectId` | int, not null | `dbo.tblDetect` | ID detection. |
| `RegUninstallId` | int, not null | `dbo.tblRegUninstall` | ID of the unique registry key. |
| `EstimatedSize` | int, null |  |  |
| `UninstallString` | nvarchar(255), null |  |  |
| `ProductID` | nvarchar(255), null |  |  |
| `InstallDate` | nvarchar(255), null |  |  |
| `InstallLocation` | nvarchar(255), null |  |  |
| `InstallSource` | nvarchar(255), null |  |  |
| `LogFile` | nvarchar(255), null |  |  |
| `ModifyPath` | nvarchar(255), null |  |  |
| `Readme` | nvarchar(255), null |  |  |
| `NoModify` | int, null |  |  |
| `NoRemove` | int, null |  |  |
| `NoRepair` | int, null |  |  |
| `ALC_ProductPath` | nvarchar(255), null |  |  |
| `PIDKey` | nvarchar(255), null |  |  |
| `CD_KEY` | nvarchar(255), null |  | Detected activation key. |
| `DigitalProductId` | nvarchar(255), null |  | Detected product key. |

## dbo.DocumentFolder

Document folder

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Folder name |
| `Objects` | bit, not null |  | 1 = documents in this folder can be linked to objects |
| `SwLicenses` | bit, not null |  | 1 = documents in this folder can be linked to software licenses |
| `Stocktakings` | bit, not null |  | 1 = documents in this folder can be linked to the asset stocktaking |

## dbo.DocumentFolderRight

Permissions of users and groups for documents stored in a certain document folder

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `DocumentFolderId` | int, not null | `dbo.DocumentFolder` | Document folder (DocumentFolder.id) |
| `PersonId` | int, null | `dbo.tPerson` | User (tPerson.iPersonId); Just one of the PersonId and RoleId must have a value filled in. |
| `RoleId` | int, null | `dbo.tRole` | User group (tRole.iRoleId) |
| `CanRead` | bit, null |  | 1 = read permission for documents |
| `CanModify` | bit, null |  | 1 = editing permission for documents |
| `CanDelete` | bit, null |  | 1 = deletion permission for documents |

## dbo.EmailSignatureHdSection

Assigning signatures to services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `EmailSignatureId` | int, not null | `dbo.tEmailSignature` |  |
| `HdSectionId` | int, null | `dbo.tHdSection` |  |

## dbo.EmailSubscription

Email subscriptions

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID |
| `EmailSubscriptionTypeId` | int, not null | `dbo.EmailSubscriptionType` | Email subscription (EmailSubscriptionType.Id) |
| `PersonId` | int, null | `dbo.tPerson` | Person (tPerson.iPersonId) |
| `RoleId` | int, null | `dbo.tRole` | Role (tRole.tRoleId) |
| `Email` | nvarchar(max), null |  | Email if it was inserted without user |

## dbo.EmailSubscriptionType

Email subscription type

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Email subscription type name |

## dbo.EmbeddingModel

Used models to calculate embeddings.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `DeploymentName` | nvarchar(64), not null |  | Name of model deployment |
| `ModelName` | nvarchar(64), not null |  | Name of model |
| `Status` | int, not null |  | Status of embedding model: 0 - Disabled 1 - Active 2 - Reindexing 3 - FastReindexing 4 - Aborted |

## dbo.ExternalArticle

External knowledge article imported from an external service.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `FileId` | nvarchar(128), not null |  | Identifier of the source file in the external service. |
| `FileName` | nvarchar(128), not null |  | Name of the source file. |
| `Url` | nvarchar(256), not null |  | URL of the source file. |
| `ModifiedTime` | datetimeoffset, not null |  | Date and time the source file was last modified (UTC). |
| `CTag` | nvarchar(64), null |  | Change tracking tag (ETag) of the content from the external service. |

## dbo.ExternalArticleChunk

Chunk of an external article text used for semantic search.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ExternalArticleId` | int, not null | `dbo.ExternalArticle` | External article ID. |
| `ChunkId` | int, not null |  | Sequential chunk number starting from 0. |
| `EmbeddingModelId` | int, not null | `dbo.EmbeddingModel` | Used embedding model for vectors. |
| `Time` | datetime, null |  | Time of ContentVector change. |
| `Content` | nvarchar(max), not null |  | Text content of the chunk. |
| `ContentVector` | vector, null |  | Embedding vector of the chunk content. |

## dbo.ExternalObject

Objects from external systems

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID |
| `ExternalId` | nvarchar(255), not null |  | ID of the object in the external system |
| `ExternalObjectTypeId` | int, null | `dbo.ExternalObjectType` | External object type ID |
| `Name` | nvarchar(255), null |  | Object name |

## dbo.ExternalObjectType

External object types

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID |
| `Name` | nvarchar(64), not null |  | Name of the type |

## dbo.ExternalService

External services

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | ID of external service |
| `Name` | nvarchar(255), not null |  | Name of external service |

## dbo.ExternalServiceMetric

External services metrics

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | ID of external service metric |
| `ExternalServiceId` | int, not null | `dbo.ExternalService` | ID of external service |
| `Feature` | nvarchar(255), null |  | Name of the feature |
| `GroupName` | nvarchar(255), null |  | Name of the group |
| `MetricName` | nvarchar(255), null |  | Name of the metric |

## dbo.ExternalServiceMetricValue

Values of external service usages

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | ID of the usage |
| `ExternalServiceMetricId` | int, not null | `dbo.ExternalServiceMetric` | ID of external service metric |
| `Date` | date, not null |  | Date of usage |
| `IntValue` | int, not null |  | Value of the usage for the date |

## dbo.FeedbackForm

Feedback form definitions

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Guid` | uniqueidentifier, not null |  | Form GUID |
| `FromDate` | datetime, not null |  | Date from when the form is shown |
| `ToDate` | datetime, not null |  | Date to which the form is shown |
| `UrlPattern` | nvarchar(255), null |  | Regex pattern for matching URL |
| `RoleBehaviorIds` | nvarchar(max), null |  | List of role behavior identifiers |
| `ShowOnlyToRequester` | bit, not null |  | Feedback form is shown only for requester |
| `ShowToAllSolvers` | bit, not null |  | Feedback is shown only for solvers on at least one service |
| `RequiredModules` | nvarchar(max), null |  | Modules combination needed to display the feedback form |
| `Title` | nvarchar(255), null |  | Form title |
| `Description` | nvarchar(max), null |  | Form description |
| `SubmitButtonText` | nvarchar(255), null |  | Text of form submit button |
| `CancelButtonText` | nvarchar(255), null |  | Text of form cancel button |
| `FieldsJson` | nvarchar(max), null |  | Feedback form fields |
| `FromAlvaoVersion` | nvarchar(50), null |  | Alvao version from which the form is shown |

## dbo.FeedbackResponse

Feedback responses

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Feedback response ID |
| `FormGuid` | uniqueidentifier, not null |  | Feedback form GUID |
| `PersonId` | int, not null | `dbo.tPerson` | Person ID that filled in the form |
| `SubmittedDate` | datetime, not null |  | Date when the form was submitted |
| `AnswersJson` | nvarchar(max), not null |  | Form responses |

## dbo.FormScriptExtension

Definition of custom JavaScript for forms.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Entity ID. |
| `SectionId` | int, null | `dbo.tHdSection` | Link to service (tHdSection.iHdSectionId) |
| `StatusId` | int, null | `dbo.TicketState` | Link to status (TicketState.id) |
| `Javascript` | nvarchar(max), null |  | JavaScript inserted into the page. |

## dbo.GraphMailInfo

Emails for processing received from change notifications.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `MessageId` | nvarchar(max), not null |  | Unique email Graph message ID. |
| `DateCreated` | datetime, not null |  | Record creation date. |
| `DateProcessed` | datetime, null |  | The timestamp when the record was successfully processed. |
| `GraphSubscriptionId` | int, null | `dbo.GraphSubscription` | Unique identifier for the subscription (GraphSubscription.Id). |
| `TenantId` | nvarchar(40), null |  | Tenant ID. |
| `Resource` | nvarchar(max), null |  | Resource (mailbox and message). |
| `ErrorCount` | int, null |  | Number of retries for email processing. |
| `LastErrorMessage` | nvarchar(max), null |  | Last error message. |

## dbo.GraphSubscription

Microsoft Graph subscriptions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `SubscriptionId` | nvarchar(50), not null |  | Unique identifier for the subscription. |
| `Resource` | nvarchar(100), not null |  | Resource that is monitored for changes. |
| `ChangeType` | nvarchar(25), null |  | Indicates the type of change in the subscribed resource that raises a change notification. The supported values are: created, updated, deleted. |
| `ClientState` | nvarchar(128), not null |  | Checks that the change notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each change notification. |
| `NotificationUrl` | nvarchar(2048), null |  | The URL of the endpoint that receives the change notifications. This URL must make use of the HTTPS protocol. |
| `NotificationQueryOptions` | nvarchar(255), null |  | OData query options for specifying value for the targeting resource. |
| `LifecycleNotificationUrl` | nvarchar(2048), null |  | The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved, reauthorizationRequired, and missed notifications. |
| `ExpirationDateTime` | datetime, null |  | Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to. Any value under 45 minutes after the time of the request is automatically set to 45 minutes after the request time. |
| `LastSupportedTlsVersion` | nvarchar(10), null |  | Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports. The possible values are: v1_0, v1_1, v1_2, v1_3. |
| `GraphSubscriptionStatusId` | int, not null | `dbo.GraphSubscriptionStatus` | Microsoft Graph subscription status ID (GraphSubscriptionStatus.Id). |
| `LastStatusChangeDate` | datetime, null |  | Date of the last status change. |

## dbo.GraphSubscriptionSectionSettings

Link between service and MS Graph subscription record.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `ClientState` | nvarchar(128), not null |  | Client state for verifying change notifications. |
| `SectionId` | int, not null | `dbo.tHdSection` | Service ID (tHdSection.iHdSectionId). |
| `GraphSubscriptionId` | int, null | `dbo.GraphSubscription` | Subscription ID (GraphSubscription.Id). |

## dbo.GraphSubscriptionStatus

Microsoft Graph subscription status for change notifications.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `Name` | nvarchar(100), not null |  | Status name. |

## dbo.HdSectionLoc

Cache of service localizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `HdSectionId` | int, not null |  | Service ID. |
| `LocaleId` | int, not null |  | Language ID. |
| `HdSection` | nvarchar(1024), null |  | Localized service name. |
| `HdSectionShort` | nvarchar(255), null |  | Located short service name. |
| `HdSectionDesc` | nvarchar(max), null |  | Located short service name. |
| `DescriptionHtml` | nvarchar(max), null |  |  |
| `ObjectsFieldName` | nvarchar(255), null |  | Custom objects field name |
| `HdSectionKeywords` | nvarchar(max), null |  | Localized service keywords. |
| `HdSectionLocId` | int, not null |  | Record ID. |
| `DescriptionFieldName` | nvarchar(255), null |  |  |

## dbo.HdSectionManager

Effective service managers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | ID of the service where the user is a manager. |
| `PersonId` | int, not null | `dbo.tPerson` | User ID. |
| `RequesterRoleId` | int, not null | `dbo.tRole` | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |

## dbo.HdSectionMessageTag

Unique service prefix and suffix pair.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Prefix` | nvarchar(255), null |  | Prefix |
| `Suffix` | nvarchar(255), null |  | Suffix |

## dbo.HdSectionNodeClass

Object types assigned to services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | A service (tHdSection.iHdSectionId) to which the object type is linked. |
| `NodeClassId` | int, not null | `dbo.tblClass` | The object type (tblClass.intClassId) which is linked to the service. |

## dbo.HdSectionNodeClassMyAssets

Property entrusted to me - services which should be displayed in the service offer on the pages of objects of a certain type.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | The service (tHdSection.iHdSectionId) which should be displayed on the object pages. |
| `NodeClassId` | int, not null | `dbo.tblClass` | The class of objects (tblClass.intClassId) whose website should display the service. |

## dbo.HdSectionOperator

Effective main service solvers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | ID of the service where the user is a main solver. |
| `PersonId` | int, not null | `dbo.tPerson` | User ID. |
| `RequesterRoleId` | int, not null | `dbo.tRole` | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |

## dbo.HdSectionReader

Effective readers in services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | ID of the service where the user is a reader. |
| `PersonId` | int, not null | `dbo.tPerson` | User ID. |
| `RequesterRoleId` | int, not null | `dbo.tRole` | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |

## dbo.HdSectionRightsLog

Logging of changes in user permissions to services. The meaning of values in permission columns: 1=enable 0=not set

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TimeStamp` | datetime, not null |  | Change performance date and time (UTC) |
| `ModifiedByPersonId` | int, null |  | User ID of a person who performed the change. |
| `ModifiedByPerson` | nvarchar(255), not null |  | The name of the user who did the change. |
| `HdSectionId` | int, null |  | Service ID |
| `HdSectionIdOld` | int, null |  | ID of the original service |
| `HdSection` | nvarchar(1024), null |  | Service name |
| `HdSectionOld` | nvarchar(1024), null |  | Original service name |
| `RoleId` | int, null |  | User group ID which is the permission holder. |
| `RoleIdOld` | int, null |  |  |
| `Role` | nvarchar(255), null |  | User group name which is the permission holder. |
| `RoleOld` | nvarchar(255), null |  | User group name of a person who was originally a permission holder. |
| `PersonId` | int, null |  | User ID of a person who is the permission holder. |
| `PersonIdOld` | int, null |  | User ID of a person who was originally a permission holder. |
| `Person` | nvarchar(255), null |  | User name of a person who is the permission holder. |
| `PersonOld` | nvarchar(255), null |  | User name of a person who was originally a permission holder. |
| `MainSolver` | bit, not null |  | Main solver permissions |
| `MainSolverOld` | bit, not null |  | Original main solver permissions |
| `Solver` | bit, not null |  | Solver permissions |
| `SolverOld` | bit, not null |  | Original solver permissions |
| `SolverTake1` | bit, not null |  | Solver permissions with the right to take the ticket over (main) |
| `SolverTake1Old` | bit, not null |  | Original solver permissions with the right to take the ticket over (main) |
| `SolverTake2` | bit, not null |  | Solver permissions with the right to take the ticket over (secondary) |
| `SolverTake2Old` | bit, not null |  | Original solver permissions with the right to take the ticket over (secondary) |
| `Manager` | bit, not null |  | Manager permissions |
| `ManagerOld` | bit, not null |  | Original manager permissions |
| `Reader` | bit, not null |  | Reader permissions |
| `ReaderOld` | bit, not null |  | Original reader permissions |
| `ExceptionalSolver` | bit, not null |  | Exceptional solver permissions |
| `ExceptionalSolverOld` | bit, not null |  | Original exceptional solver permissions |
| `TicketReporter` | bit, not null |  | Permissions of the ticket reporter (formerly of the irregular operator) |
| `TicketReporterOld` | bit, not null |  | The original permissions of the ticket reporter (formerly of irregular operator) |
| `SolverGroup` | bit, not null |  |  |
| `SolverGroupOld` | bit, not null |  |  |
| `RequesterRoleId` | int, null |  | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |
| `RequesterRoleIdOld` | int, null |  | ID of the group of requesters originally associated with the permissions (mapping of requesters to the solver team). |
| `RequesterRole` | nvarchar(255), null |  | Name of the group of requesters associated with the permissions (mapping of requesters to the solver team). |
| `RequesterRoleOld` | nvarchar(255), null |  | Name of the group of requesters originally associated with the permissions (mapping of requesters to the solver team). |

## dbo.HdSectionSolver

Effective service solvers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | ID of the service where the user is a solver. |
| `PersonId` | int, not null | `dbo.tPerson` | User ID. |
| `RequesterRoleId` | int, not null | `dbo.tRole` | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |

## dbo.HdSectionSolverGroup

Effective solvers from solver groups of services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | ID of the service where the user is a solver group member. |
| `PersonId` | int, not null | `dbo.tPerson` | User ID. |
| `RequesterRoleId` | int, not null | `dbo.tRole` | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |

## dbo.IdSeqType

Numeric sequence types.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `IdSeqType` | nvarchar(32), not null |  | Numeric sequence type. |

## dbo.Import

Imported CSV files

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `PersonId` | int, not null | `dbo.tPerson` | User ID of a person (tPerson.iPersonId), who imported the file. |
| `Source` | varbinary, null |  | Binary content of the file |
| `Printout` | nvarchar(max), null |  | Information printout from validation |
| `Progress` | int, not null |  | Current progress |
| `CreatedAmount` | int, not null |  | Number of new objects created |
| `UpdatedAmount` | int, not null |  | Number of updated objects |
| `StartedDate` | datetime, null |  | Date and time when the import started |
| `ValidationFinished` | bit, not null |  | 1 if the file validation is finished |
| `ImportFinished` | bit, not null |  | 1 if the file import is finished |
| `Error` | bit, not null |  | 1 if the file import end up with an error |
| `CreatedObjectId` | int, not null |  | ID of object (tblNode.intNodeId), which was created by import. |
| `JobId` | bigint, null |  | Last job created for Hangfire by this import |

## dbo.IntegratedAuthIpRange

IP address range for Integrated Windows Authentication.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `FromIP` | bigint, null |  | Beginning of the range of IP addresses, including. |
| `ToIP` | bigint, null |  | End of the range of IP addresses, including endpoint. |

## dbo.KindDataType

Property data types in AM.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `KindDataTypeId` | int, not null |  | Property data type ID. |
| `DataTypeName` | nvarchar(20), null |  | Property data type name. |

## dbo.KindRight

Security for properties.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `KindId` | int, not null | `dbo.tblKind` | Property definition ID. |
| `RoleId` | int, not null | `dbo.tRole` | Group ID. |
| `ClassId` | int, null | `dbo.tblClass` | Object type ID. The value NULL meals that the permission applies to all object types. |
| `CanRead` | tinyint, null |  | Permission to read. |
| `CanModify` | tinyint, null |  | Permission to change value. |

## dbo.KnowledgeFeedback

Feedback on knowledge.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `KnowledgeId` | int, not null | `dbo.tArticle` | Knowledge (tArticle.iArticleId) |
| `PersonId` | int, not null | `dbo.tPerson` | Person (tPerson.iPersonId) |
| `Rating` | bit, null |  | Rating of knowledge. |

## dbo.LibraryIcon

Service icon library.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID |
| `Name` | nvarchar(100), null |  | Icon name |
| `Content` | varbinary, not null |  | Binary content of file in PNG format |
| `SystemIcon` | bit, not null |  | 1 = system icon |

## dbo.LicDowngrade

License - downgrade.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `LicHistId` | int, not null | `dbo.tblLicHist` | License ID - tblListHist |
| `ProductId` | int, not null | `dbo.tblProduct` | Product ID - tblProduct |
| `Desc` | nvarchar(255), null |  | Note |

## dbo.LicHistCust

License custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `LicHistId` | int, null | `dbo.tblLicHist` |  |

## dbo.LicHistDocument

License - links to documents and media.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `LicHistId` | int, not null | `dbo.tblLicHist` | License (tblLicHist.intLicHistId) |
| `AMDocumentId` | int, not null | `dbo.tblDocument` | Document (tblDocument.id) |

## dbo.LicHistItemAssign

Assigning/removing/moving license to/from/between computers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `LicHistId` | int, not null | `dbo.tblLicHist` | License |
| `LicHistItemId` | int, null | `dbo.tblLicHistItem` | License item |
| `AssignedDate` | datetime, not null |  | Date assigned/removed |
| `AssignedPersonId` | int, not null | `dbo.tPerson` | Assigning/Removing author |
| `SrcNodeId` | int, null | `dbo.tblNode` | Source object |
| `DestNodeId` | int, null | `dbo.tblNode` | Target object |
| `LicInfo` | nvarchar(1000), null |  | Information on the assigned/removed license. |
| `ItemInfo` | nvarchar(1000), null |  | Information on the assigned/removed license item. |

## dbo.LicHistLog

Change record for a license or a license item.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `LogDate` | datetime, not null |  | Date and time of the event. |
| `LicHistId` | int, null | `dbo.tblLicHist` | The license ID to which the change relates. A foreign key in the LicHist table. |
| `LicHistLogKindId` | int, not null | `dbo.LicHistLogKind` | Change kind ID. The kinds of changes are specified in the LicHistLogKind table. |
| `PersonId` | int, not null | `dbo.tPerson` | Change author ID. A foreign key in the tPerson table. |
| `PropName` | nvarchar(100), null |  | Name of the changed license property or license item property. |
| `OldVal` | nvarchar(255), null |  | The original property value. |
| `NewVal` | nvarchar(255), null |  | New property value. |
| `Message` | nvarchar(max), null |  | A message displayed in the license log. |
| `IsExternalObject` | bit, not null |  | 1=when the tblLicHistItem entry was assigned to an external object. |

## dbo.LicHistLogKind

Kind of change of a license or a license item.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `LogKind` | nvarchar(100), not null |  | Kind of change. |
| `MsgTemplate` | nvarchar(255), not null |  | Template of the message for displaying the change in the license log. |

## dbo.LicHistMedia

License - links to documents and media.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `LicHistId` | int, not null | `dbo.tblLicHist` | License (tblLicHist.intLicHistId) |
| `MediaId` | int, not null | `dbo.tblMedia` | Media (tblMedia.id) |

## dbo.LicHistRelation

A table containing links between licenses in Asset Management

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `BeginLicHistId` | int, not null | `dbo.tblLicHist` | Initial license link ID. A foreign key on the tblLicHist table. |
| `EndLicHistId` | int, not null | `dbo.tblLicHist` | End license link ID. A foreign key on the tblLicHist table. |
| `LicHistRelationTypeId` | int, not null | `dbo.LicHistRelationType` | Link type. A foreign key on the LicHistRelationType table. |
| `ModifiedDate` | datetime, not null |  | Date of last link edit. |
| `ModifiedByPersonId` | int, not null | `dbo.tPerson` | Person who performed the last link edit. |

## dbo.LicHistRelationType

Types of links between licenses in the AM

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `BeginName` | nvarchar(32), not null |  | Start of link (name). |
| `EndName` | nvarchar(32), not null |  | End of link (name). |
| `Directional` | bit, not null |  | If the link is directional or non-directional. 1 = directional, 0 = non-directional. |
| `Cyclic` | bit, not null |  | if creating circular tasks is permitted. 1 = Yes, 0 = No. |
| `OneToMany` | bit, not null |  | If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany. |
| `LicHistRelationTypeBehaviorId` | int, not null | `dbo.LicHistRelationTypeBehavior` | Link behavior. If system or custom one. A foreign key on LicHistRelationTypeBehavior. |

## dbo.LicHistRelationTypeBehavior

Types of links between licenses in the AM from the viewpoint of system/custom links.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(70), null |  | Name |

## dbo.LicKind

"CAL/Licensing" list, i.e. per device, per user, etc.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `LicKind` | nvarchar(32), not null |  |  |

## dbo.LicProductCoverage

Which of all products have license coverage.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `LicHistId` | int, not null | `dbo.tblLicHist` | License ID - tblListHist |
| `ProductId` | int, not null | `dbo.tblProduct` | Product ID - tblProduct |
| `ProductPackId` | int, null | `dbo.tblProduct` |  |

## dbo.LicRight

Permissions of persons and groups to software licenses of organizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `NodeId` | int, null | `dbo.tblNode` | Organization (tblNode.intNodeId) to whose software licenses the permissions apply. |
| `PersonId` | int, null | `dbo.tPerson` | Authorized user (tPerson.iPersonId) |
| `RoleId` | int, null | `dbo.tRole` | Authorized group of users (tRole.iRoleId) |
| `CanRead` | tinyint, null |  | Permission to read |
| `CanModify` | tinyint, null |  | Permission to modify |

## dbo.LicType

License types.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Item ID. |
| `LicType` | nvarchar(32), not null |  | Type name. |

## dbo.LogLevel

Enumeration of log levels

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(50), not null |  | Log level name |

## dbo.MailMessage

Outgoing email queue.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `EmlMail` | varbinary, not null |  |  |
| `SendAttempts` | int, null |  |  |
| `LastErrorMsg` | nvarchar(max), null |  |  |
| `LastAttemptTime` | datetime, null |  |  |
| `Priority` | int, null |  | Priority in the queue for sending. Larger numbers represent higher priority. The default value is 10000. Recommended values: Urgent messages (e.g., synchronization messages between systems) = 15000 Standard notifications and alerts = 10000 Messages sent in bulk = 5000 |

## dbo.MailServerConnectionType

Connection type for loading messages on services

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Connection type ID |
| `Name` | nvarchar(50), not null |  | Connection type |

## dbo.MediaLend

Information on items lent and returned in the media library.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `MediaId` | int, not null | `dbo.tblMedia` | Media (tblMedia.id) |
| `lintPersonNodeId` | int, null | `dbo.tblNode` | Lended to person in tree - tblNode |
| `txtPerson` | nvarchar(255), null |  | Lended to |
| `dteLended` | datetime, null |  | Date lended |
| `dteReturned` | datetime, null |  | Date returned |
| `txtNote` | nvarchar(max), null |  | Note |
| `liLendingPersonId` | int, not null | `dbo.tPerson` | Lended by - tPerson |
| `liAcceptingPersonId` | int, null | `dbo.tPerson` | Taken over by - tPerson |

## dbo.News

News.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Primary table key. |
| `CreatedDate` | datetime, not null |  | Creation date of the news post. |
| `Subject` | nvarchar(max), not null |  | Name of the news post. |
| `Text` | nvarchar(max), null |  | Text of the news post. |
| `Order` | int, not null |  | News post display order. |
| `ShowEndDate` | datetime, null |  | Date until which the news post shall be displayed. |
| `CreatedByPersonId` | int, not null | `dbo.tPerson` | User who created the news post. |
| `HtmlText` | nvarchar(max), null |  | HTML text of the news post. |
| `SentDate` | datetime, null |  | Date and time of the last sending of the news post. |
| `Important` | bit, not null |  | 1 = important news post. Alerts for important unread news are displayed on every WA page. |
| `PublishToTenants` | bit, not null |  | 1 = news post displayed to users of all tenants. This option can only be enabled in the ALVAO provider's database. |
| `ShowToRequesters` | bit, not null |  | 1 = also show to requesters of selected services; 0 = show only to members of service teams |
| `LocaleId` | int, null | `dbo.tLocale` |  |
| `IsSample` | bit, not null |  |  |

## dbo.NewsChunk

Chunked text content of news articles.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NewsId` | int, not null | `dbo.News` | News ID. |
| `ChunkId` | int, not null |  | Chunk ID. |
| `EmbeddingModelId` | int, not null | `dbo.EmbeddingModel` | Used embedding model for vectors. |
| `Time` | datetime, null |  | Time of ContentVector change. |
| `Content` | nvarchar(max), not null |  | Text content of the chunk. |
| `ContentVector` | vector, null |  | Vector used to compare the similarity of text in the news article. |

## dbo.NewsHdSection

Services for which the individual news are intended.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Primary table key. |
| `NewsId` | int, not null | `dbo.News` | id of the news post (News.id). |
| `HdSectionId` | int, null | `dbo.tHdSection` | id of the service for which the news post is intended (tHdSection.iHdSectionId). NULL = intended for all services. |

## dbo.NewsLoc

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `NewsId` | int, not null | `dbo.News` |  |
| `LocaleId` | int, not null | `dbo.tLocale` |  |
| `Subject` | nvarchar(max), not null |  |  |
| `Text` | nvarchar(max), null |  |  |
| `HtmlText` | nvarchar(max), null |  |  |

## dbo.NewsRead

Records of reading the news. In multi-tenant operation, records of reading news displayed to other tenants are saved in the provider's database.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `NewsId` | int, not null | `dbo.News` | News post ID (News.id). |
| `PersonId` | int, not null |  | Person ID (tPerson.iPersonId). Person ID in the tenant's database in a multi-tenant operation. |
| `PersonName` | nvarchar(255), null |  | Name of the person |
| `PersonLogin` | nvarchar(255), null |  | Personâs username |
| `TenantId` | int, null |  | Tenant ID in the tenant database. ZERO, if this is a local news post. |
| `Organization` | nvarchar(255), null |  | Organization name in the tenant database. NULL if this is local news post. |
| `FirstDisplayed` | datetime, not null |  | Date and time user first viewed the news post. |

## dbo.NewTicketFormColumn

Column order on a New Ticket Form

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Entity ID |
| `SectionId` | int, not null | `dbo.tHdSection` | Link to service |
| `ColumnId` | int, not null | `dbo.tColumn` | Link to column |
| `Order` | int, not null |  | Row on which the item is displayed |
| `Required` | bit, not null |  | Marking the item obligation. |
| `Column` | int, null |  | Column on which the item is displayed (0 left, 1 right) |

## dbo.NewTicketFormSection

Section order on a New Ticket Form

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Entity ID |
| `Name` | nvarchar(255), not null |  | Section name |
| `Order` | int, not null |  | Row on which the item is displayed |
| `SectionId` | int, not null | `dbo.tHdSection` | Id of the service (tHdSection.iHdSectionId) |
| `Expand` | bit, not null |  | 1 = when the form for submitting a new ticket is displayed, the section will be expanded. 0 = the section will be collapsed |

## dbo.NewTicketFormTextBlock

Text block order on a New Ticket Form

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Entity ID |
| `TextHtml` | nvarchar(max), null |  | Text in HTML |
| `Order` | int, not null |  | Row on which the item is displayed |
| `SectionId` | int, not null | `dbo.tHdSection` | Id of the service (tHdSection.iHdSectionId) |
| `Column` | int, null |  | Column on which the item is displayed (0 left, 1 right) |
| `ColSpan` | int, null |  | Number of columns the item occupies. (1 half row, 2 whole row) |

## dbo.NodeColumnInheritance

Inheritance between objects

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NodeId` | int, not null | `dbo.tblNode` | ID of object (tblNode.intNodeId) |
| `KindId` | int, not null | `dbo.tblKind` | ID of object property (tblKind.intKindId) |
| `InheritedFromNodeId` | int, null | `dbo.tblNode` | ID of parent object (tblNode.intNodeId); NULL = this object property is inheritable. |

## dbo.NodeCust

Object property values

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NodeId` | int, not null | `dbo.tblNode` | ID of object (tblNode.intNodeId) |
| `ColumnSet` | xml, null |  | System column with sparse column set information. |
| `Name` | nvarchar(255), null |  |  |
| `ComputerSetName` | nvarchar(255), null |  |  |
| `Hostname` | nvarchar(255), null |  |  |
| `NetworkBranchName` | nvarchar(255), null |  |  |
| `User` | nvarchar(255), null |  |  |
| `Note` | nvarchar(255), null |  |  |
| `Location` | nvarchar(255), null |  |  |
| `Address` | nvarchar(255), null |  |  |
| `OrganizationCode` | nvarchar(255), null |  |  |
| `TypeDesignation` | nvarchar(255), null |  |  |
| `InventoryNumber` | nvarchar(255), null |  |  |
| `SerialNumber` | nvarchar(255), null |  |  |
| `PackingSlipNumber` | nvarchar(255), null |  |  |
| `Port` | nvarchar(255), null |  |  |
| `Manufacturer` | nvarchar(255), null |  |  |
| `Type` | nvarchar(255), null |  |  |
| `Frequency` | nvarchar(255), null |  |  |
| `RefreshMaximum` | nvarchar(255), null |  |  |
| `RefreshMinimum` | nvarchar(255), null |  |  |
| `HorizontalResolution` | nvarchar(255), null |  |  |
| `VerticalResolution` | nvarchar(255), null |  |  |
| `Version` | nvarchar(255), null |  |  |
| `Codepage` | nvarchar(255), null |  |  |
| `CountryCode` | nvarchar(255), null |  |  |
| `FileSystem` | nvarchar(255), null |  |  |
| `LogicalDevice` | nvarchar(255), null |  |  |
| `PictureWidth` | nvarchar(255), null |  |  |
| `PictureHeight` | nvarchar(255), null |  |  |
| `__order` | nvarchar(255), null |  |  |
| `NumberOfLicenses` | nvarchar(255), null |  |  |
| `Building` | nvarchar(255), null |  |  |
| `Floor` | nvarchar(255), null |  |  |
| `Room` | nvarchar(255), null |  |  |
| `Vendor` | nvarchar(255), null |  |  |
| `Department` | nvarchar(255), null |  |  |
| `PurchaseDate` | date, null |  |  |
| `Warranty` | nvarchar(255), null |  |  |
| `Description` | nvarchar(255), null |  |  |
| `DateOfNextServiceInspection` | date, null |  |  |
| `Phone` | nvarchar(255), null |  |  |
| `Fax` | nvarchar(255), null |  |  |
| `Email` | nvarchar(255), null |  |  |
| `ContactPerson` | nvarchar(255), null |  |  |
| `OrganizationName` | nvarchar(255), null |  |  |
| `Price` | nvarchar(255), null |  |  |
| `Size` | nvarchar(255), null |  |  |
| `Website` | nvarchar(255), null |  |  |
| `Password` | nvarchar(255), null |  |  |
| `UserName` | nvarchar(255), null |  |  |
| `CostCenter` | nvarchar(255), null |  |  |
| `Segment` | nvarchar(255), null |  |  |
| `Unit` | nvarchar(255), null |  |  |
| `SubnetName` | nvarchar(255), null |  |  |
| `MacAddress` | nvarchar(255), null |  |  |
| `IpAddress` | nvarchar(255), null |  |  |
| `DnsDomain` | nvarchar(255), null |  |  |
| `DhcpServer` | nvarchar(255), null |  |  |
| `IpxAddress` | nvarchar(255), null |  |  |
| `Irq` | nvarchar(255), null |  |  |
| `DiskInterface` | nvarchar(255), null |  |  |
| `PersonalNumber` | nvarchar(255), null |  |  |
| `Office` | nvarchar(255), null |  |  |
| `Facility` | nvarchar(255), null |  |  |
| `Diagonal` | nvarchar(255), null |  |  |
| `ComputerKind` | nvarchar(255), null |  |  |
| `BiosSerialNumber` | nvarchar(255), null |  |  |
| `Subdivision` | nvarchar(255), null |  |  |
| `Site` | nvarchar(255), null |  |  |
| `Division` | nvarchar(255), null |  |  |
| `Section` | nvarchar(255), null |  |  |
| `Subsidiary` | nvarchar(255), null |  |  |
| `Sockets` | nvarchar(255), null |  |  |
| `Model` | nvarchar(255), null |  |  |
| `CaseKind` | nvarchar(255), null |  |  |
| `PartOfTheDomain` | nvarchar(255), null |  |  |
| `Quantity` | nvarchar(255), null |  |  |
| `AssetCategory` | nvarchar(255), null |  |  |
| `AssetNumber` | nvarchar(255), null |  |  |
| `AssetCheckDate` | date, null |  |  |
| `WarrantyExpiration` | date, null |  |  |
| `MobilePhone` | nvarchar(255), null |  |  |
| `Position` | nvarchar(255), null |  |  |
| `City` | nvarchar(255), null |  |  |
| `Street` | nvarchar(255), null |  |  |
| `Country` | nvarchar(255), null |  |  |
| `Company` | nvarchar(255), null |  |  |
| `PoBox` | nvarchar(255), null |  |  |
| `StateOrProvince` | nvarchar(255), null |  |  |
| `ZipCode` | nvarchar(255), null |  |  |
| `HomePhone` | nvarchar(255), null |  |  |
| `Pager` | nvarchar(255), null |  |  |
| `IpPhone` | nvarchar(255), null |  |  |
| `ScreenResolution` | nvarchar(255), null |  |  |
| `MonitorType` | nvarchar(255), null |  |  |
| `Imei` | nvarchar(255), null |  |  |
| `DataRecordingMedium` | nvarchar(255), null |  |  |
| `PhoneNumber` | nvarchar(255), null |  |  |
| `ModemInterface` | nvarchar(255), null |  |  |
| `DataService` | nvarchar(255), null |  |  |
| `MemoryCardType` | nvarchar(255), null |  |  |
| `KeyFor` | nvarchar(255), null |  |  |
| `Color` | nvarchar(255), null |  |  |
| `LicensePlateNumber` | nvarchar(255), null |  |  |
| `TechnicalInspectionValidUntil` | date, null |  |  |
| `Tariff` | nvarchar(255), null |  |  |
| `ServerFarmName` | nvarchar(255), null |  |  |
| `CloudName` | nvarchar(255), null |  |  |
| `HostComputer` | nvarchar(255), null |  |  |
| `LastLoggedOnUser` | nvarchar(255), null |  |  |
| `PersonResponsibleForSoftware` | nvarchar(255), null |  |  |
| `NumberOfLogicalCpuCores` | nvarchar(255), null |  |  |
| `DefaultIncidentSla` | nvarchar(255), null |  |  |
| `DefaultIncidentService` | nvarchar(255), null |  |  |
| `MonitoringMode` | nvarchar(255), null |  |  |
| `AccountIsDisabled` | nvarchar(255), null |  |  |
| `PersonResponsibleForAsset` | int, null |  |  |
| `LastImportedFromAd` | date, null |  |  |
| `RamSizeGb` | float, null |  |  |
| `TotalStorageCapacityGb` | float, null |  |  |
| `NumberOfHardDrives` | float, null |  |  |
| `Cpu` | nvarchar(255), null |  |  |
| `NumberOfProcessors` | float, null |  |  |
| `OperatingSystem` | nvarchar(255), null |  |  |
| `MacAddresses` | nvarchar(255), null |  |  |
| `IpAddresses` | nvarchar(255), null |  |  |
| `GraphicCard` | nvarchar(255), null |  |  |
| `NumberOfPhysicalCpuCores` | nvarchar(255), null |  |  |
| `Order` | nvarchar(255), null |  |  |
| `UserGroups` | nvarchar(255), null |  |  |
| `HiddenProperties` | nvarchar(255), null |  |  |
| `ContractNumber` | nvarchar(255), null |  |  |
| `PaymentPeriodMonths` | float, null |  |  |
| `ValidFrom` | date, null |  |  |
| `ValidTo` | date, null |  |  |
| `NotifyOfTheEndOfValidityInAdvanceDays` | float, null |  |  |
| `ContractStatus` | nvarchar(255), null |  |  |
| `IntuneDeviceId` | nvarchar(255), null |  |  |
| `UserUpn` | nvarchar(255), null |  |  |
| `IntuneLastCheckIn` | nvarchar(255), null |  |  |
| `TonerLevel` | nvarchar(255), null |  |  |
| `SnmpScan` | nvarchar(255), null |  |  |
| `SnmpLastScan` | nvarchar(255), null |  |  |
| `ResourceGroup` | nvarchar(255), null |  |  |
| `AzureSqlServer` | nvarchar(255), null |  |  |
| `AzureSqlDatabase` | nvarchar(255), null |  |  |
| `AzureStorageAccount` | nvarchar(255), null |  |  |
| `Workstation` | nvarchar(255), null |  |  |
| `AlvaoAgentDeviceId` | nvarchar(255), null |  |  |
| `StatusAssetCheck` | nvarchar(255), null |  |  |
| `ReasonForNotBeingFoundAssetCheck` | nvarchar(255), null |  |  |
| `NoteForAdministratorAssetCheck` | nvarchar(255), null |  |  |
| `AdGuid` | nvarchar(255), null |  |  |
| `JamfDeviceId` | nvarchar(255), null |  |  |
| `JamfLastCheckIn` | nvarchar(255), null |  |  |
| `LansweeperDeviceId` | nvarchar(255), null |  |  |
| `LansweeperLastCheckIn` | nvarchar(255), null |  |  |
| `LansweeperSiteId` | nvarchar(255), null |  |  |
| `ZabbixDeviceId` | nvarchar(255), null |  |  |
| `ZabbixLastCheckIn` | nvarchar(255), null |  |  |
| `MsSccmDeviceId` | nvarchar(255), null |  |  |
| `AlvaoAgentLastCheckIn` | nvarchar(255), null |  |  |
| `StatusAssetAssignment` | nvarchar(255), null |  |  |
| `CommentForRecipientAssetAssignment` | nvarchar(255), null |  |  |
| `SupportServices` | nvarchar(255), null |  |  |
| `Availability` | nvarchar(255), null |  |  |
| `Confidentiality` | nvarchar(255), null |  |  |
| `Integrity` | nvarchar(255), null |  |  |
| `TotalAssetValue` | float, null |  |  |
| `RiskLevel` | nvarchar(255), null |  |  |
| `AssetCyberSecurityCategory` | nvarchar(255), null |  |  |
| `Ownership` | nvarchar(255), null |  |  |
| `MonitorComputerLastScan` | nvarchar(255), null |  |  |
| `LastScanDate` | date, null |  |  |
| `CiscoMerakiDeviceId` | nvarchar(255), null |  |  |
| `CiscoMerakiLastCheckIn` | nvarchar(255), null |  |  |
| `SplashtopDeviceId` | nvarchar(255), null |  |  |
| `TeamViewerGuid` | nvarchar(255), null |  |  |
| `TeamViewerDeviceId` | nvarchar(255), null |  |  |
| `TeamViewerLastCheckIn` | nvarchar(255), null |  |  |
| `AdDomain` | nvarchar(255), null |  |  |

## dbo.NodeDocument

Objects in the tree - links to documents.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintNodeId` | int, not null | `dbo.tblNode` | Object (tblNode.intNodeId |
| `AMDocumentId` | int, not null | `dbo.tblDocument` | Document (tblDocument.id) |
| `RemovedDate` | datetime, null |  | Date of link deletion. |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | ID of the person who deleted the link. |

## dbo.NodeHealthStatus

Object health status

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Health status ID. |
| `Description` | nvarchar(max), null |  | Status description |

## dbo.NodeHealthStatusLoc

Cache of language localizations of object health statuses, see NodeHealthStatus.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NodeHealthStatusId` | int, not null | `dbo.NodeHealthStatus` | Health status ID (NodeHealthStatus.id). |
| `LocaleId` | int, not null | `dbo.tLocale` | Language ID (tLocale.iLocaleId). |
| `Description` | nvarchar(max), null |  | Localized status description. |

## dbo.NodeRelation

Table with links between objects in Asset Management

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `BeginNodeId` | int, not null | `dbo.tblNode` | ID of start link object. Foreign key on tblNode table. |
| `EndNodeId` | int, not null | `dbo.tblNode` | ID of end link object. Foreign key on tblNode table. |
| `NodeRelationTypeId` | int, not null | `dbo.NodeRelationType` | Link Type. Foreign key on NodeRelationType table. |
| `CreatedDate` | datetime, not null |  | Link creation date and time (UTC) |
| `CreatedByPersonId` | int, not null | `dbo.tPerson` | User ID of a person who created the link (tPerson.iPersonId). |
| `RemovedDate` | datetime, null |  | Link removal date and time (UTC) |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | User ID of a person who deleted the link (tPerson.iPersonId). |
| `RequiredRelationFieldAlert` | bit, not null |  | The relation does not have any of the required fields filled in. |

## dbo.NodeRelationCust

Object relation custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NodeRelationId` | int, not null | `dbo.NodeRelation` | Link to object relation to which the values belong (NodeRelation.id) |
| `Weight` | int, null |  |  |
| `ThreatOccurrenceLikelihood` | int, null |  |  |
| `ProbabilityOfVulnerabilityBeingExploited` | int, null |  |  |
| `RiskLevel` | int, null |  |  |

## dbo.NodeRelationCustChange

Changes of object relation custom fields.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `NodeRelationId` | int, not null | `dbo.NodeRelation` | Object relation ID (NodeRelation.id) |
| `PersonId` | int, not null | `dbo.tPerson` | Author of the change (tPerson.iPersonId) |
| `ChangeDate` | datetime, not null |  | Change date and time (UTC) |
| `ColumnId` | int, not null | `dbo.tColumn` | Changed field (tColumn.iColumnId) |
| `ValueOldNvarchar` | nvarchar(max), null |  | Old string value |
| `ValueNewNvarchar` | nvarchar(max), null |  | New string value |
| `ValueOldBit` | bit, null |  | Old bit value |
| `ValueNewBit` | bit, null |  | New bit value |
| `ValueOldDate` | date, null |  | Old date value |
| `ValueNewDate` | date, null |  | New date value |
| `ValueOldDateTime` | datetime, null |  | Old datetime value |
| `ValueNewDateTime` | datetime, null |  | New datetime value |
| `ValueOldFloat` | float, null |  | Old float value |
| `ValueNewFloat` | float, null |  | New float value |
| `ValueOldInt` | int, null |  | Old int value (could be foreign key to various tables) |
| `ValueNewInt` | int, null |  | New int value (could be foreign key to various tables) |

## dbo.NodeRelationType

Types of links between objects in the AM.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `BeginName` | nvarchar(255), not null |  | Start of link (name). |
| `EndName` | nvarchar(255), not null |  | End of link (name). |
| `Directional` | bit, not null |  | If the link is directional or non-directional. 1 = directional, 0 = non-directional. |
| `Cyclic` | bit, not null |  | if creating circular tasks is permitted. 1 = Yes, 0 = No. |
| `OneToMany` | bit, not null |  | If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany. |
| `NodeRelationTypeBehaviorId` | int, not null | `dbo.NodeRelationTypeBehavior` | Link behavior. System or custom. Foreign key to NodeRelationTypeBehavior. |
| `LineStyle` | varchar, not null |  |  |
| `LineColor` | varchar, not null |  |  |
| `AffectsNodeHealth` | bit, not null |  | 1 = health of the final object is influenced by the health of the starting object. 0 = otherwise. |
| `DeterminesParametersOfCybersecurity` | bit, not null |  |  |

## dbo.NodeRelationTypeBehavior

Types of links between objects in the AM from the viewpoint of system/custom links.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `Name` | nvarchar(70), null |  | Name. |

## dbo.NodeRelationTypeColumn

Custom fields used by object relation type.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `NodeRelationTypeId` | int, not null | `dbo.NodeRelationType` | Object relation type ID. |
| `ColumnId` | int, not null | `dbo.tColumn` | Custom field ID. |
| `IsMandatory` | bit, not null |  | Field is mandatory on relation type. |

## dbo.NodeRightLog

Logging of changes in permissions of users in Asset Management.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `TimeStamp` | datetime, not null |  | Date and time of the change execution. |
| `User` | nvarchar(255), null |  | User name. |
| `Group` | nvarchar(255), null |  | Group name. |
| `Object` | nvarchar(255), null |  | Object name. |
| `ObjectOld` | nvarchar(255), null |  | Object name - the previous value. |
| `Recursive` | bit, not null |  | Check box including of child objects. |
| `RecursiveOld` | bit, null |  | Check box including of child objects - the previous value. |
| `Class` | nvarchar(255), null |  | Object type name. |
| `ClassOld` | nvarchar(255), null |  | Object type name - the previous value. |
| `Read` | bit, null |  | Permission to read. |
| `ReadOld` | bit, null |  | Permission to read - the previous value. |
| `Write` | bit, null |  | Permission to edit. |
| `WriteOld` | bit, null |  | Permission to edit - the previous value. |
| `Move` | bit, null |  | Permission to move. |
| `MoveOld` | bit, null |  | Permission to move - the previous value. |
| `Create` | bit, null |  | Permission to create any objects. |
| `CreateOld` | bit, null |  | Permission to create any objects - the previous value. |
| `Delete` | bit, null |  | Permission to delete. |
| `DeleteOld` | bit, null |  | Permission to delete - the previous value. |
| `ModifiedBy` | nvarchar(255), not null |  | Logged-in user name. |

## dbo.ObjectEmbedding

Embeddings for objects.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null | `dbo.tblNode` | Object ID. |
| `EmbeddingModelId` | int, not null | `dbo.EmbeddingModel` | Used embedding model for vectors. |
| `DescriptionTime` | datetime, null |  | Time of DescriptionVector change. |
| `DescriptionVector` | vector, null |  | Vector used to compare the similarity of object description made from name, type and property values. |

## dbo.ObjectRule

Object rules for automatic object sorting

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `Name` | nvarchar(1024), not null |  | Rule name |
| `Description` | nvarchar(max), null |  | Rule description |
| `IsEnabled` | bit, not null |  | 1 = the rule is enabled, 0 = disabled |
| `Error` | nvarchar(max), null |  | Rule execution error text |
| `Condition` | nvarchar(max), null |  | SQL conditions related to selected source and destination properties, paths and types |
| `ToObjectTypeId` | int, null | `dbo.tblClass` | To object type Id (tblClass.intClassId) |
| `ToObjectId` | int, null | `dbo.tblNode` | To object ID (tblNode.intNodeId) |
| `Removed` | datetime, null |  | Rule removal date and time (UTC) |
| `Order` | int, null |  |  |
| `AlvaoModuleId` | int, null | `dbo.AlvaoModule` |  |

## dbo.ObjectRuleLog

Object rules mapping. Table contains concrete mapping to source and moved objects

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `ObjectRuleId` | int, null | `dbo.ObjectRule` | Object rule ID (ObjectRule.id) |
| `NodeId` | int, null | `dbo.tblNode` | Moved object ID (tblNode.intNodeId) |
| `NodeName` | nvarchar(255), not null |  | Moved object name |
| `FromNodeId` | int, null | `dbo.tblNode` | Original parent object ID (tblNode.intNodeId) |
| `FromNodeName` | nvarchar(255), not null |  | Original parent object name |

## dbo.ObjectRuleMapping

Object rules mapping. Table contains concrete mapping to source and moved objects

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `ObjectRuleId` | int, not null | `dbo.ObjectRule` | Object rule ID (ObjectRule.id) |
| `FromObjectId` | int, null | `dbo.tblNode` | From object ID (tblNode.intNodeId) |
| `FromObjectTypeId` | int, null | `dbo.tblClass` | From object type Id (tblClass.intClassId) |
| `FromAllObjects` | bit, not null |  | 1 = the rule is above all tree, 0 = specific mapping is used |
| `ObjectsOfTypeId` | int, null | `dbo.tblClass` | Moved object type Id (tblClass.intClassId) |
| `ObjectsOfAllTypes` | bit, not null |  | 1 = the rule is for all object types, 0 = specific mapping is used |

## dbo.OperatorServiceUsage

Services to which the given solver created tickets last using the New Ticket Form.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `PersonId` | int, not null | `dbo.tPerson` | The solver who used the given service while registering the ticket. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | Used service ID while registering the ticket |
| `LastUsed` | datetime, not null |  | Service last use time |

## dbo.PeriodicAlert

Periodic alerts not defined by an SQL query. Sent by email, periodically with the selected regularity.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Alert name |
| `Description` | nvarchar(max), null |  | Description |
| `IsEnabled` | bit, not null |  | If sending is enabled. 1 = enabled, 0 = disabled. |
| `AttachCSV` | bit, not null |  | If the CSV attachment is be attached to the notification. 1 = enabled, 0 = disabled |
| `PeriodicAlertPeriodId` | tinyint, not null | `dbo.PeriodicAlertPeriod` | Send period. A foreign key on PeriodicAlertPeriod. |
| `StartDate` | datetime, not null |  | Date and time from which the alert should be sent. At the same time, it is the starting point for calculating the date and time another will be sent according to the selected period. |
| `LastSent` | datetime, null |  | Date and time of last alert sent. |
| `SqlQuery` | nvarchar(max), null |  | SQL query defining alerts. |
| `RunOverAnalyticalDatabase` | bit, not null |  | If starting above the analytical database is enabled. 1 = enabled, 0 = disabled. |
| `LastModified` | datetime, not null |  | Date and time of the last notice modification. |
| `ErrorMessage` | nvarchar(max), null |  | Error message at the last SQL script run. |

## dbo.PeriodicAlertPeriod

Send period of periodic alerts.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | tinyint, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Period name |

## dbo.PersonBehavior

People types. Normal users =1, system users >1.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `Description` | nvarchar(max), null |  | Description of the system person type. |

## dbo.PersonEmailUsage

Use of an email address for sending the message by a specific user.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `UsedByPersonId` | int, not null | `dbo.tPerson` | The user who used the email address. |
| `UsedEmail` | nvarchar(255), not null |  | Used email address for sending the message. |
| `LastUsed` | datetime, not null |  | Time of the last use of the email address. |

## dbo.PersonEventDisplay

Events viewed by a person.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `PersonId` | int, null | `dbo.tPerson` |  |
| `ActId` | int, null | `dbo.tAct` |  |
| `TicketApprovalItemId` | int, null | `dbo.tHdTicketApprovalItem` |  |

## dbo.PersonGridView

Cache for the number of unread tickets from the viewpoint of a specific user.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `PersonId` | int, not null | `dbo.tPerson` | Person (tPerson.iPersonId). |
| `GridName` | nvarchar(200), null |  | Name of table (grid), see the ProfileValue.ValueName table. |
| `ViewName` | nvarchar(200), null |  | View name. |
| `UnreadTicketsCount` | int, null |  | Number of unread tickets in the view. |
| `LastCheck` | datetime, null |  | Time (UTC) of the last update of the UnreadTicketsCount value. |

## dbo.PersonManager

Pre-counted structure of managers and employees.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ManagerPersonId` | int, not null | `dbo.tPerson` | Manager's ID. |
| `EmployeePersonId` | int, not null | `dbo.tPerson` | Employee's ID. |
| `Distance` | int, not null |  | Hierarchical distance of a user from his/her manager. Automatically calculated column. Direct manager = 1, manager of a direct manager = 2 etc. |

## dbo.PersonPasswordHistory

Used people's passwords.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `SinceDate` | datetime, not null |  | Password setting date. |
| `PersonId` | int, not null | `dbo.tPerson` | Person Id. |
| `Password` | nvarchar(255), not null |  | Hash of password used. |

## dbo.PersonTicketDisplay

A record from the history of the last viewed tickets of the requester.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketId` | int, not null | `dbo.tHdTicket` | Viewed ticket number. |
| `PersonId` | int, not null | `dbo.tPerson` | ID of the person who viewed the ticket. |
| `LastDisplayed` | datetime, null |  | Date and time of the last view of the ticket. |
| `EventsNotDisplayed` | bit, not null |  |  |
| `Id` | int, not null |  |  |

## dbo.PrintReportTemplate

Templates for print reports

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Template name |
| `Description` | nvarchar(max), null |  | Description of template |
| `LastModified` | datetime, not null |  | Date and time of last change |
| `LastModifiedByPersonId` | int, not null | `dbo.tPerson` | User ID of the person who performed the latest change (tPerson.iPersonId). |
| `PrintReportTemplateTypeId` | int, null | `dbo.PrintReportTemplateType` |  |
| `AssetCodeTypeId` | tinyint, null | `dbo.PrintTemplateAssetCodeType` | Asset code type ID |
| `BarcodeSourcePropKindId` | int, null | `dbo.tblKind` | Barcode source property kind ID |
| `WidthMm` | int, null |  | Page width in mm |
| `HeightMm` | int, null |  | Page height in mm |
| `MarginLeftMm` | int, null |  | Page margin left in mm |
| `MarginRightMm` | int, null |  | Page margin right in mm |
| `MarginTopMm` | int, null |  | Page margin top in mm |
| `MarginBottomMm` | int, null |  | Page margin bottom in mm |
| `PageOrientation` | bit, null |  | Page orientation. NULL, 0 = portrait, 1 = landscape |
| `ShowPageNumbers` | bit, null |  | Print page "X from Y" information in the footer of each page |

## dbo.PrintReportTemplateType

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `Name` | nvarchar(255), not null |  |  |

## dbo.PrintTemplateAssetCodeType

Type of an asset code (Barcode/QR Code)

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | tinyint, not null |  | Asset code type ID |
| `Name` | nvarchar(128), not null |  | Asset code type name |

## dbo.ProductCust

Product License custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ProductId` | int, not null | `dbo.tblProduct` |  |

## dbo.ProductState

Status of the products

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Product status - numerical (Primary key) |
| `ProductState` | nvarchar(127), not null |  | Product status - written |
| `txtDesc` | nvarchar(255), not null |  | txtDesc |

## dbo.ProfileValue

View settings table

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `PersonId` | int, not null | `dbo.tPerson` | Foreign key to table tPerson - iPersonId. Specifies the settings "owner" |
| `ValueName` | nvarchar(max), not null |  | Name of settings including path used in registries. The path is provided for the purpose of product identification |
| `StringValue` | nvarchar(max), null |  | String settings value |
| `IntValue` | int, null |  | Int settings value |
| `Backup` | bit, not null |  |  |

## dbo.ReceivedMessage

Table for temporary storage of read messages for custom actions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Message ID. |
| `EmlMail` | varbinary, not null |  | Message in EML format. |
| `Created` | datetime, not null |  | Date and time of message storage in the database. |

## dbo.ReceivedMessageRule

Rules for incoming messages to service mailboxes.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `OrderNum` | int, not null |  | Determines the order in which the rules are detected and applied. |
| `RuleName` | nvarchar(255), not null |  | Name of rules (must be unique). |
| `SubjectCondition` | nvarchar(255), null |  | Condition for comparing with the subject of the loaded mail. |
| `BodyCondition` | nvarchar(255), null |  | Condition for comparing with the body of the loaded mail. |
| `SenderCondition` | nvarchar(255), null |  | Condition for comparing with the recipient of the loaded mail. |
| `ReceiverCondition` | nvarchar(255), null |  | Condition for comparing with the sender of the loaded mail. |
| `SendMessage` | bit, not null |  | Permit "Send message" action (Yes/No). |
| `MailTo` | nvarchar(255), null |  | Message recipient for "Send message" action. |
| `MailSubject` | nvarchar(255), null |  | Message subject for "Send message" action. |
| `MailText` | nvarchar(max), null |  | Message text for "Send message" action. |
| `MoveRequestToService` | bit, not null |  | Permit "Move to service" action (Yes/No). |
| `MoveToSectionId` | int, null | `dbo.tHdSection` | If "Move to service" is permitted, the service id is displayed, otherwise NULL. |
| `ResolveRequest` | bit, not null |  | Enabling the option "Resolve ticket" (Yes/No). |
| `DeleteRequest` | bit, not null |  | Permit "Remove ticket" option (Yes/no). |
| `ModifiedDate` | datetime, null |  | Date and time of last rule edit. |
| `ModifiedByPersonId` | int, null | `dbo.tPerson` | Person who edited the rules. |

## dbo.RelatedTicketRule

The rules for automatic creation of linked tickets while transiting the source ticket to a certain status.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketStateId` | int, not null | `dbo.TicketState` | Ticket status ID (TicketState.id) |
| `TicketTemplateId` | int, not null | `dbo.TicketTemplate` | Ticket template ID (see TicketTemplate.id) |
| `TicketRelationTypeId` | int, not null | `dbo.TicketRelationType` | ID of the relation type between tickets (see TicketRelationType.id) |
| `InDirection` | bit, not null |  | Relation direction; 1 = the created ticket is at the beginning of the relation, 0 = the created ticket is at the end of the relation. |
| `TicketNameTemplate` | nvarchar(1024), null |  | Ticket name template |
| `RelatedTicketRuleRequesterModeId` | tinyint, not null | `dbo.RelatedTicketRuleRequesterMode` | ID of requester setting method (see RelatedTicketRuleRequesterMode.id). 1 = source ticket requester; 2 = source ticket solver; 3 = RequesterPersonId. |
| `RequesterPersonId` | int, null | `dbo.tPerson` | ID of requester for a new ticket (see tPerson.iPersonId) |
| `RequesterColumnId` | int, null | `dbo.tColumn` | ID of selected custom field of type User. This column is used when RelatedTicketRuleRequesterModeId=4. Otherwise is null. |
| `SqlCondition` | nvarchar(max), null |  | SQL condition for creating a ticket |
| `TicketDescriptionTemplate` | nvarchar(max), null |  | Ticket descrition template |

## dbo.RelatedTicketRuleColumn

Copied items of the source ticket while creating linked tickets.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `RelatedTicketRuleId` | int, not null | `dbo.RelatedTicketRule` | Rule ID (see RelatedTicketRule.id) |
| `ColumnId` | int, not null | `dbo.tColumn` | Ticket item ID (see tColumn.iColumnId) |

## dbo.RelatedTicketRuleRequesterMode

Method of setting the requester while creating linked tickets, see RelatedTicketRule.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | tinyint, not null |  | Record ID |
| `Description` | nvarchar(1024), null |  | Record description |

## dbo.RequiredClassKind

The table contains properties that must be filled in for the given object types.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `ClassId` | int, not null | `dbo.tblClass` | Object type ID (tblClass.intClassId) |
| `KindId` | int, not null | `dbo.tblKind` | Property definition ID (tblKind.intKindId) |

## dbo.ReturnedAsset

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `NodeId` | int, not null | `dbo.tblNode` |  |
| `FromPersonId` | int, not null | `dbo.tPerson` |  |
| `AuthorPersonId` | int, not null | `dbo.tPerson` |  |
| `ChangeDate` | datetime, not null |  |  |

## dbo.RoleBehavior

Types of system rolls, e.g. all users, administrators, ...

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `RoleBehavior` | nvarchar(100), null |  |  |

## dbo.RoleMembershipLog

Logging of changes in membership in groups.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `TimeStamp` | datetime, not null |  | Date and time of the operation execution. |
| `MemberTypeId` | int, not null | `dbo.RoleMembershipLogMemberType` | Kind of membership in the group. |
| `Member` | nvarchar(255), not null |  | User or group name. |
| `OperationId` | int, not null | `dbo.RoleMembershipLogOperation` | Operation. |
| `Group` | nvarchar(255), not null |  | Group name. |
| `ModifiedBy` | nvarchar(255), not null |  | Logged-in user name. |

## dbo.RoleMembershipLogMemberType

Kind of membership in the group.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Membership kind ID. |
| `Name` | nvarchar(50), not null |  | Membership kind name. |

## dbo.RoleMembershipLogOperation

Executed operation which is logged.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Operation ID. |
| `Name` | nvarchar(50), not null |  | Operation name. |

## dbo.SamAlert

SAM notifications sent.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `ProductId` | int, not null | `dbo.tblProduct` | Product |
| `ComputerId` | int, not null | `dbo.tblNode` | Computer |
| `SentDate` | datetime, not null |  | Date on which the notification was sent |
| `SamAlertRuleId` | int, not null | `dbo.SamAlertRule` | Notification type |
| `SequenceNum` | int, not null |  | Sequence number of notification |
| `Recipients` | nvarchar(max), null |  | Recipients |
| `ResolvedDate` | datetime, null |  | Date on which the system determined the problem was resolved. |

## dbo.SamAlertConfig

SAM configuration of notifications.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `CheckingDetectPeriod` | int, not null |  |  |
| `SendTimeHour` | float, not null |  |  |
| `RepeatLastAlertAfterDays` | int, null |  |  |
| `MaxDetectAgeDays` | int, null |  |  |

## dbo.SamAlertRule

SAM notification rules.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `Active` | bit, not null |  |  |
| `AlertAfterDays` | int, null |  |  |
| `AlertSwManager` | bit, not null |  |  |
| `AlertSuperior` | bit, not null |  |  |
| `AlertRoleId` | int, null | `dbo.tRole` |  |

## dbo.SamType

SAM notification type - Audit: yes, no, via email.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `Name` | nvarchar(32), not null |  |  |
| `Desc` | nvarchar(256), null |  |  |

## dbo.Scanner

Scanners importing data from other systems or physical devices into Alvao.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Scanner id (system-defined values) |
| `Name` | nvarchar(32), not null |  | Scanner name |

## dbo.ScannerPropertyLockout

Locking of values of object properties (dbo.tblKind) for editing by scanners (dbo.Scanner).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `ScannerId` | int, not null | `dbo.Scanner` | Scanner (Scanner.id) |
| `ClassId` | int, not null | `dbo.tblClass` | Object type (tblClass.intClassId) |
| `LockingKindId` | int, not null | `dbo.tblKind` | A property definition (tblKind.intKindId) whose non-empty value locks the property LockedKindId for editing. |
| `LockedKindId` | int, not null | `dbo.tblKind` | A property definition (tblKind.intKindId) which is locked for editing by the non-empty value of the property LockingKindId. |

## dbo.SccmConnection

Connection to MS SCCM

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `SccmConnectionKindId` | int, not null | `dbo.SccmConnectionKind` | Type of connection (SccmConnectionKind.id) |
| `Url` | nvarchar(2048), null |  | Administration Service URL |
| `Username` | nvarchar(32), null |  | Login name for connecting to Administration Service |
| `Password` | nvarchar(32), null |  | User password |
| `ClientId` | nvarchar(255), null |  | GUID of the native client application registered in Azure. Required when connecting via Cloud Management Gateway. |
| `TokenEndpoint` | nvarchar(2048), null |  | URL of the access point for the native client application used to obtain an authorisation token for connecting via the Cloud Management Gateway. |
| `ApplicationUri` | nvarchar(2048), null |  | URL of the web application registered in Azura used to connect via the Cloud Management Gateway. |
| `ConnectionString` | nvarchar(2048), null |  | Connection string for the SCCM database |

## dbo.SccmConnectionKind

Type of connection to MS SCCM

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID: 1=Administration Service 2=Database |
| `Name` | nvarchar(32), not null |  | Type name |

## dbo.SearchLog

Log of searched queries

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TimeStamp` | datetime, not null |  | Date and time of search |
| `Query` | nvarchar(max), null |  | Query |
| `PersonId` | int, null | `dbo.tPerson` | User ID |

## dbo.SectionSequence

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NextSectionId` | int, not null |  |  |

## dbo.SendEmailMethodType

Send method types for emails

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Method type ID |
| `Name` | nvarchar(100), not null |  | Method type |

## dbo.ServiceEmbedding

Embeddings for services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null | `dbo.tHdSection` | Service ID. |
| `EmbeddingModelId` | int, not null | `dbo.EmbeddingModel` | Used embedding model for vectors. |
| `PresentFlag` | int, not null |  | Present vector bit flag 0 â no valid vector present 1 â Communication 2 â Fields 4 - Objects 8 - Description |
| `CommunicationTime` | datetime, null |  | Time of CommunicationVector change. |
| `DescriptionTime` | datetime, null |  | Time of DescriptionVector change. |
| `FieldsTime` | datetime, null |  | Time of FieldsVector change. |
| `ObjectsTime` | datetime, null |  | Time of ObjectsVector change. |
| `CommunicationVector` | vector, null |  | Mean vector used to compare the similarity of ticket communication. |
| `DescriptionVector` | vector, null |  | Vector used to compare the similarity of service name, description and keywords. |
| `FieldsVector` | vector, null |  | Mean vector used to compare the similarity of ticket fields. |
| `ObjectsVector` | vector, null |  | Mean vector used to compare ticket objects. |

## dbo.SharedView

Table of shared views.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Shared view identifier |
| `OwnerPersonId` | int, not null | `dbo.tPerson` | View owner. A foreign key to the tPerson table. |
| `Settings` | nvarchar(max), not null |  | Shared view setting |
| `GridName` | nvarchar(max), not null |  | Name of a table which the shared view is assigned to. The same as dbo.ProfileValue.ValueName. |
| `Removed` | datetime, null |  | Time of view deletion. If it wasnât, NULL is present. |

## dbo.SharedViewRecipient

Table of users and groups which the view is shared with.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `RoleId` | int, null | `dbo.tRole` | The group of persons who the view is shared with. |
| `SharedViewId` | int, not null | `dbo.SharedView` | A foreign key to the SharedView table. |
| `id` | int, not null |  | Record identifier. |
| `PersonId` | int, null | `dbo.tPerson` | A person who the view is shared with. |

## dbo.SlaAlertRuleReceiver

Notice for unresolved tickets - other recipients.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `SlaAlertRuleId` | int, not null | `dbo.tSlaAlertRule` |  |
| `PersonId` | int, null | `dbo.tPerson` |  |
| `RoleId` | int, null | `dbo.tRole` |  |

## dbo.SlaLoc

Cache of SLA localizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `SlaId` | int, not null |  | SLA ID. |
| `LocaleId` | int, not null |  | Language ID. |
| `Sla` | nvarchar(255), null |  | Localized SLA name. |
| `SlaDesc` | nvarchar(max), null |  | Localized SLA description. |

## dbo.SlaRightsLog

Logging of changes in SLA assignment The meaning of values in permission columns: 1=enable 0=refuse NULL=not set

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TimeStamp` | datetime, not null |  | Change performance date and time (UTC) |
| `ModifiedByPersonId` | int, null |  | User ID of a person who performed the change. |
| `ModifiedByPerson` | nvarchar(255), not null |  | The name of the user who did the change. |
| `HdSectionId` | int, null |  | Service ID |
| `HdSectionIdOld` | int, null |  | ID of the original service |
| `HdSection` | nvarchar(1024), null |  | Service name |
| `HdSectionOld` | nvarchar(1024), null |  | Original service name |
| `RoleId` | int, null |  | User group ID which is the permission holder. |
| `RoleIdOld` | int, null |  |  |
| `Role` | nvarchar(255), null |  | User group name of a person who was originally a permission holder. |
| `RoleOld` | nvarchar(255), null |  |  |
| `PersonId` | int, null |  | User ID of a person who is the permission holder. |
| `PersonIdOld` | int, null |  | User ID of a person who was originally a permission holder. |
| `Person` | nvarchar(255), null |  | User name of a person who is the permission holder. |
| `PersonOld` | nvarchar(255), null |  | User name of a person who was originally a permission holder. |
| `SlaId` | int, null |  | SLA ID |
| `SlaIdOld` | int, null |  | ID of the original SLA |
| `Sla` | nvarchar(255), null |  | SLA name |
| `SlaOld` | nvarchar(255), null |  | Original SLA name |
| `Access` | bit, null |  | Access permissions |
| `AccessOld` | bit, null |  | Original access permissions |
| `Default` | bit, null |  | Marking of the default SLA |
| `DefaultOld` | bit, null |  | Original marking of the default SLA |
| `Inheritance` | bit, null |  | Inheritance. |
| `InheritanceOld` | bit, null |  | Original value of inheritance. |

## dbo.SnmpDeviceTypeMap

Map for determining the type of object based on device descriptions in SNMP.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record id |
| `SysDescrRegex` | nvarchar(max), not null |  | Regex pattern of the "sysDescr" SNMP values (OID 1.3.6.1.2.1.1.1) associated with this record. See Regular Expression Language - Quick Reference. |
| `ClassId` | int, null | `dbo.tblClass` | Object type (see tblClass). |

## dbo.StringLoc

Cache of text string localizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `StringId` | int, not null |  | Text string ID. |
| `LocaleId` | int, not null |  | Language ID. |
| `String` | nvarchar(max), null |  | Localized string text. |

## dbo.Subscriber

A table containing information on the customer and on the ticket on which information is taken.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `PersonId` | int, not null | `dbo.tPerson` |  |
| `TicketId` | int, not null | `dbo.tHdTicket` |  |
| `SinceDate` | datetime, null |  |  |
| `SubscribedByPerson` | int, null |  | Id of the user who set the subscription. |

## dbo.SwItemKind

Kinds of records in the views of software.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `Kind` | nvarchar(64), not null |  | Kind of record. |

## dbo.tAccount

Organization (in accordance with CRM, i.e. the company).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iAccountId` | int, not null |  |  |
| `sAccount` | nvarchar(255), not null |  |  |
| `sImportSystem` | nvarchar(255), null |  |  |
| `sImportRecordId` | nvarchar(255), null |  |  |
| `dRemoved` | datetime, null |  |  |
| `liRemovedPersonId` | int, null |  |  |
| `dCreated` | datetime, not null |  |  |
| `liCreatedPersonId` | int, null |  |  |
| `dModified` | datetime, not null |  |  |
| `liModifiedPersonId` | int, null |  |  |
| `Phone` | nvarchar(30), null |  | Phone |
| `Phone2` | nvarchar(30), null |  | Phone 2 |
| `Fax` | nvarchar(30), null |  | Fax |
| `Email` | nvarchar(50), null |  | Email |
| `Email2` | nvarchar(50), null |  | Email 2 |
| `AddressId` | int, null | `dbo.tAddress` | Address 1 |
| `Address2Id` | int, null | `dbo.tAddress` | Address 2 |
| `Web` | nvarchar(50), null |  | Company web |
| `IdentificationNumber` | nvarchar(20), null |  | Company ID - company identification number |
| `TaxIdentificationNumber` | nvarchar(20), null |  | VAT ID - value added tax identification number |
| `IsSample` | bit, not null |  |  |

## dbo.tAccountCust

Organization custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liAccountId` | int, null | `dbo.tAccount` |  |

## dbo.tAct

The record in communication or ticket log.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iActId` | int, not null |  | Record ID |
| `liActKindId` | int, null | `dbo.tActKind` | Link to record type |
| `dAct` | datetime, null |  | Time at which the event occurred: |
| `sAct` | nvarchar(max), null |  | Name of event |
| `mActNotice` | nvarchar(max), null |  | Note to event |
| `liActFromPersonId` | int, null | `dbo.tPerson` | Link to sender. |
| `liActToPersonId` | int, null | `dbo.tPerson` | Link to recipient. |
| `liActHdTicketId` | int, not null | `dbo.tHdTicket` | Ticket to which the event belongs |
| `sActFrom` | nvarchar(1024), null |  | Sender name |
| `sActFromEmail` | nvarchar(255), null |  | Sender email |
| `sActFromPhone` | nvarchar(255), null |  | Sender's phone |
| `mActFromContact` | nvarchar(max), null |  | Sender contact details |
| `sActFromMobile` | nvarchar(255), null |  | Sender cell phone |
| `sActFromOffice` | nvarchar(255), null |  | Sender office |
| `sActFromDepartment` | nvarchar(255), null |  | Sender's department |
| `sActFromWorkPosition` | nvarchar(255), null |  | Sender's job |
| `sActFromCompany` | nvarchar(255), null |  | Sender's company |
| `sActTo` | nvarchar(4000), null |  | Name of the recipient. At email messages sent to multiple recipients, the column contains all message recipients. |
| `sActToEmail` | nvarchar(255), null |  | Recipient email. The column is empty at email messages sent to multiple recipients. |
| `nActWorkHours` | float, null |  | Number of work hours |
| `dActRemoved` | datetime, null |  | Time at which the event was removed. The event is not removed for NULL |
| `sActCc` | nvarchar(4000), null |  | Copy |
| `sActAutoSubmitted` | nvarchar(255), null |  | Atribut AutoSubmitted read from email |
| `sActMessageId` | nvarchar(255), null |  | Atribut MessageId read from email |
| `sActXSpamLevel` | nvarchar(255), null |  | Atribut XSpamLever read from email |
| `sActXSpamStatus` | nvarchar(255), null |  | Atribut XSpamStatus read from email |
| `nActTravelHours` | float, null |  | Time traveled in hours |
| `nActTravelKm` | float, null |  | Travel distance in km |
| `bNoCharge` | bit, not null |  | If the value is 1, paid |
| `bWaitingForUser` | bit, null |  | 1 - Marks the start of waiting for the requisitioner from 0 - Marks the end of waiting for the requisitioner NULL - does not change the status of waiting for the requisitioner |
| `dRecordCreated` | datetime, null |  | Time at which the record was created. This attribute is only available from version 2.9, records created with an older version will have a NULL value |
| `sRecordCreatedByMachine` | nvarchar(255), null |  | Name of computer on which the record was created. This attribute is only filled in by the Alvao Service. This attribute is only available from version 2.9, records created with an older version will have a NULL value |
| `iRecordCreatedByProcessPid` | int, null |  | Process ID which created the record. This attribute is only available from version 2.9, records created with an older version will have a NULL value |
| `CreatedByPersonId` | int, null | `dbo.tPerson` | User ID of the event creator |
| `ActHtml` | nvarchar(max), null |  |  |
| `ActOperationId` | int, null | `dbo.ActOperation` | Process kind ID |
| `EffectiveDate` | datetime, null |  |  |
| `ActMarkId` | tinyint, null | `dbo.ActMark` | Record marking. A foreign key to the ActMark table. |
| `UserRead` | bit, not null |  | The flag specifying whether this event can also be seen by requesters or ticket participants without additional permissions for the service |
| `Modified` | datetime, null |  | Time at which the record was modified. |

## dbo.tActKind

Record type tAct, e.g. "email", "phone", "note", "process", â¦

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iActKindId` | int, not null |  | Record ID: 1 = email 2 = phone 3 = personal meeting 4 = letter 5 = voice message 6 = written message 7 = form 8 = note 9 = process 10 = other 11 = alert |
| `sActKind` | nvarchar(255), null |  | Naming the type of event |
| `iActKindOrder` | int, null |  | Order in which records are displayed. |
| `Removable` | bit, not null |  |  |

## dbo.tAddress

Address

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `Street` | nvarchar(max), not null |  | Street |
| `ZIP` | nvarchar(20), null |  | ZIP code |
| `City` | nvarchar(100), not null |  | City |
| `Country` | nvarchar(100), null |  | Country |

## dbo.tApprovalSchema

Approval schemes.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iApprovalSchemaId` | int, not null |  |  |
| `sApprovalSchema` | nvarchar(255), null |  |  |
| `mApprovalSchemaDescription` | nvarchar(max), null |  |  |
| `dApprovalSchemaRemoved` | datetime, null |  |  |
| `dApprovalSchemaCreated` | datetime, null |  |  |
| `AutoApproveStepsSameApprover` | bit, not null |  | Automatic approval of steps with the same approver. |

## dbo.tApprovalSchemaItem

Approval scheme step.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iApprovalSchemaItemId` | int, not null |  |  |
| `liApprovalSchemaItemApprovalSchemaId` | int, not null | `dbo.tApprovalSchema` |  |
| `iApprovalSchemaItemOrder` | int, not null |  |  |
| `liApprovalSchemaItemAuthorityRoleId` | int, null | `dbo.tRole` |  |
| `bApprovalSchemaItemAuthorityManagerOfUser` | bit, not null |  | The "Requester's direct manager" approval step |
| `bApprovalSchemaItemAuthorityRootManagerOfUser` | bit, not null |  |  |
| `nExpirationHours` | float, null |  |  |
| `sCustom` | nvarchar(255), null |  |  |
| `sApprovalSchemaItemCustomUrl` | nvarchar(max), null |  | Custom form for "approval/rejection". |
| `AutoApproveByRequester` | bit, not null |  | The step is automatically approved by the requester, if he is a member of the selected approval group. |
| `AuthorityRequester` | bit, not null |  | "Requester" approval step. |
| `OnlyRequesterOrHisManager` | bit, not null |  | Selection of the approval step "Group" - "only the requester or their manager" |

## dbo.tArticle

Article in Knowledge Base.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iArticleId` | int, not null |  |  |
| `sArticle` | nvarchar(1024), null |  |  |
| `mArticleAnnotation` | nvarchar(max), null |  |  |
| `mArticle` | nvarchar(max), null |  |  |
| `dArticleCreated` | datetime, null |  |  |
| `dArticleModified` | datetime, null |  |  |
| `liArticleAuthorPersonId` | int, null | `dbo.tPerson` |  |
| `ModifierPersonId` | int, null |  |  |
| `HtmlArticle` | nvarchar(max), null |  |  |
| `Published` | bit, null |  |  |
| `Order` | int, null |  |  |
| `Removed` | datetime, null |  |  |
| `HtmlArticleBinary` | varbinary, null |  |  |
| `HtmlArticleBinaryExt` | nvarchar(10), null |  |  |
| `LocaleId` | int, null | `dbo.tLocale` |  |
| `ExternalArticleId` | nvarchar(255), null |  | ID of an article from external services |
| `IsSample` | bit, not null |  |  |

## dbo.tBankHoliday

National holidays.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iBankHolidayId` | int, not null |  |  |
| `liBankHolidayRegionId` | int, null | `dbo.tBankHolidayRegion` |  |
| `dBankHoliday` | datetime, not null |  |  |
| `sBankHoliday` | nvarchar(255), null |  |  |

## dbo.tBankHolidayLoaded

National holiday blocks included in the database. A block is a list of holidays belonging to one region and year.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liBankHolidayRegionId` | int, not null | `dbo.tBankHolidayRegion` |  |
| `iYear` | int, not null |  |  |
| `dRevision` | datetime, not null |  |  |

## dbo.tBankHolidayRegion

Local national holiday regions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iBankHolidayRegionId` | int, not null |  |  |
| `sBankHolidayRegion` | nvarchar(255), not null |  |  |
| `CountryCode` | nvarchar(2), null |  |  |

## dbo.tblADMap

Mapping attributes from AD to AM properties. This configuration is used by ImportAD.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintClassId` | int, null | `dbo.tblClass` |  |
| `lintKindId` | int, null | `dbo.tblKind` |  |
| `txtADClass` | nvarchar(255), null |  |  |
| `txtADAttr` | nvarchar(255), null |  |  |
| `bolKey` | bit, not null |  |  |

## dbo.tblClass

ID of the objects types. Texts in tblDict.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intClassId` | int, not null |  | Class Id |
| `bComputer` | bit, not null |  | If the type is a computer |
| `DefaultObjectTemplateNodeId` | int, null | `dbo.tblNode` | Default object template (tblNode.intNodeId) |
| `ObjectNameTemplate` | nvarchar(max), null |  | Object name template |

## dbo.tblCommandDef

Definitions of commands for the "Administrator's Tools" function.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intCommandDefId` | int, not null |  |  |
| `intCommandDefUID` | int, null |  |  |
| `txtName` | nvarchar(255), not null |  |  |
| `txtCommand` | nvarchar(255), not null |  |  |
| `txtRunDir` | nvarchar(255), null |  |  |
| `intGroup` | int, null |  |  |

## dbo.tblCompany

Code list of organizations (software product library).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intCompanyId` | int, not null |  |  |
| `intCompanyUID` | int, null |  |  |
| `txtName` | nvarchar(255), not null |  |  |
| `txtAddress1` | nvarchar(255), null |  |  |
| `txtAddress2` | nvarchar(255), null |  |  |
| `txtCity` | nvarchar(255), null |  |  |
| `txtZIP` | nvarchar(255), null |  |  |
| `txtState` | nvarchar(255), null |  |  |
| `txtWeb` | nvarchar(255), null |  |  |
| `txtPhone` | nvarchar(255), null |  |  |
| `bolProducer` | bit, not null |  |  |
| `bolReseller` | bit, not null |  |  |
| `bolPrint` | bit, not null |  |  |
| `intFlags` | int, null |  |  |
| `txtDescription` | nvarchar(255), null |  |  |
| `dteTimeStamp` | datetime, not null |  |  |
| `bolValid` | bit, not null |  |  |
| `txtCertifiedBy` | nvarchar(255), null |  |  |
| `VendorCpe` | nvarchar(max), null |  |  |
| `IsVendorCpeManual` | bit, not null |  |  |
| `CpeMatchScore` | float, not null |  |  |

## dbo.tblDetect

Information on HW and SW detections in the computers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intDetectId` | int, not null |  | Record ID |
| `lintComputerNodeId` | int, not null | `dbo.tblNode` | Computer designated for detection (tblNode). |
| `dteCreated` | datetime, null |  | Time at which the detection is performed. |
| `dteImported` | datetime, null |  | Time at which the detection is loaded to the database |
| `txtDescription` | nvarchar(255), null |  | Note |
| `lintDetectKindId` | int, not null | `dbo.tblDetectKind` | 1=hw, 2=sw (see tblDetectKind, tblDict) |
| `dteRqCreated` | datetime, null |  | Time at which the request (manual or automatic) was created. The request will be created once the detection is loaded from the file to the Asset Management. The time of the detection is written to dteRqCreated. |
| `lintDetectStatusId` | int, not null | `dbo.tblDetectStatus` | 1 = "no response so far" 2 = "ok" - carried out without warnings and errors. 3 = "warning" - Warnings were encountered during the detection process, but no errors. 4 = "error" - At least one error was encountered during the detection. |
| `liRqCreatedPersonId` | int, not null | `dbo.tPerson` | The user that created this request, see tPerson. |
| `dUpdated` | datetime, null |  |  |
| `DetectSourceMethod` | int, null | `dbo.DetectMethod` |  |
| `ManualRq` | bit, not null |  | If the value is 1, the request was created manually with the activated Detect and evaluate immediately option. |

## dbo.tblDetectAction

Scheduled evaluation of HW and SW by detection.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intDetectActionId` | int, not null |  |  |
| `lintDetectId` | int, not null | `dbo.tblDetect` |  |
| `lintDetectActionKindId` | int, not null |  |  |
| `ManualRq` | bit, not null |  | If the value is 1, the request was created manually by the Evaluate immediately command. |

## dbo.tblDetectKind

ID of the types of detection (HW, SW). Texts in tblDict.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intDetectKindId` | int, not null |  |  |

## dbo.tblDetectOpts

Detections setting.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintDetectId` | int, null | `dbo.tblDetect` |  |
| `lintComputerNodeId` | int, null | `dbo.tblNode` |  |
| `lintDetectMethodId` | int, null | `dbo.DetectMethod` |  |
| `lintDetectKindId` | int, not null | `dbo.tblDetectKind` |  |
| `bolSwFull` | bit, null |  |  |
| `txtSwInclude` | nvarchar(255), null |  |  |
| `txtSwExclude` | nvarchar(255), null |  |  |
| `intDetectPeriod` | int, null |  |  |

## dbo.tblDetectStatus

ID of the detections statuses. Texts in tblDict.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intDetectStatusId` | int, not null |  |  |

## dbo.tblDetFile

Detected files on the computers (SW detection).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intDetFileId` | bigint, not null |  |  |
| `lintFileId` | int, null | `dbo.tblFile` |  |
| `lintDetectId` | int, null | `dbo.tblDetect` |  |
| `txtFolderPath` | nvarchar(255), null |  |  |
| `dteCreated` | datetime, null |  |  |
| `dteModified` | datetime, null |  |  |
| `dteAccessed` | datetime, null |  |  |
| `intAttribs` | int, null |  |  |
| `LastRun` | datetime, null |  | The date the file was last run. |
| `RunCount` | int, null |  | Total number of files running |

## dbo.tblDict

Common table for the text code lists of the system tables values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintClassId` | int, null | `dbo.tblClass` | object class - tblClass |
| `lintNameLangId` | int, null | `dbo.tblLang` | language name - tblLang |
| `lintDetectKindId` | int, null | `dbo.tblDetectKind` |  |
| `lintDetectStatusId` | int, null | `dbo.tblDetectStatus` |  |
| `lintIdSeqId` | int, null | `dbo.tblIdSeq` |  |
| `lintProductTypeId` | int, null | `dbo.tblProductType` |  |
| `lintProductCategoryId` | int, null | `dbo.tblProductCategory` |  |
| `lintMediaTypeId` | int, null | `dbo.tblMediaType` |  |
| `lintDocumentKindId` | int, null | `dbo.tblDocumentKind` |  |
| `lintHistoryFlags` | int, null |  |  |
| `lintDiaryKindId` | int, null |  |  |
| `txtText` | nvarchar(255), null |  | Just one of the attributes lintClassId, lintNameLangId, ..., lintDiaryKindId must have a value different from null. The attribute txtText contains the name of the relevant item. |
| `lintInstallMsgId` | int, null |  | installation/uninstallation reports |
| `lintPropEditMsgId` | int, null |  | Log - edit |
| `lintLicTypeId` | int, null |  | License kind |
| `lintLicModeId` | int, null |  | License mode |
| `lintLicHistCALId` | int, null |  | Cal license |
| `lintPropertyMapAssignId` | int, null |  |  |
| `lintAssetStateId` | int, null |  | Property status |
| `lintInventoryStatusId` | int, null |  | Asset check status |
| `lintAllClassObjId` | int, null |  | Text for "all objects" - combo box |
| `lintLendSubjId` | int, null |  | Log - rental |
| `lintLendMsgId` | int, null |  | Log - rental |
| `liSwPresenceId` | int, null |  | SW profiles - profile name |
| `iLicenseStatusId` | int, null |  | SW - license status - text |
| `iLicErrMsgId` | int, null |  | SW - error message for license on SW tab |
| `iSwProfErrMsgId` | int, null |  | SW - error message for profile on SW tab |

## dbo.tblDocument

Documents.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), null |  | Name of the document. |
| `IdNumber` | nvarchar(255), null |  | Identification number 1 |
| `lintDocumentKindId` | int, not null | `dbo.tblDocumentKind` | Type - tblDict |
| `txtMemo` | nvarchar(max), null |  | Note |
| `CreatedDate` | datetime, not null |  | Date and time the document was created (UTC). |
| `IssuedDate` | datetime, null |  | Date of issue of the document. |
| `lintResellerCompanyId` | int, null | `dbo.tblCompany` | Vendor - tblCompany |
| `lintSrcNodeId` | int, null | `dbo.tblNode` | Handover protocol - the User type object representing a person handing over (tblNode.intNodeId). |
| `lintDestNodeId` | int, null | `dbo.tblNode` | Handover protocol - the User type object representing a recipient (tblNode.intNodeId). |
| `txtIdNumber2` | nvarchar(255), null |  | ID number 2 |
| `dteRemoved` | datetime, null |  | Voided |
| `liCreatedPersonId` | int, null | `dbo.tPerson` | Author - tPerson |
| `liRemovedPersonId` | int, null | `dbo.tPerson` | Voided by - tPerson |
| `TransferConfirmTypeId` | int, not null | `dbo.TransferConfirmType` | Sign method. |
| `SignDate` | datetime, null |  | Date of signing. |
| `SignPersonId` | int, null | `dbo.tPerson` | ID of the person who signed the document. |
| `SignComputer` | nvarchar(255), null |  | Name of the computer from which the document was signed. |
| `SignedBy` | nvarchar(128), null |  | The person who signed the document (if its ID cannot be obtained) |
| `DocumentFolderId` | int, not null | `dbo.DocumentFolder` | Document folder (DocumentFolder.id) |
| `GiverFlags` | int, null |  | The bit array of flags expressing the relation of the person handing over to the handed over asset in the handover protocol. Possible values: NULL = no relation 0x01 = assets entrusted for use 0x02 = other entrusted assets |
| `ReceiverFlags` | int, null |  | The bit array of flags expressing the relation of the recipient to the asset handed over in the handover protocol. Possible values: NULL = no relation 0x01 = assets entrusted for use 0x02 = other entrusted assets |
| `SummaryProtocol` | bit, not null |  | 1 = this is a summary internal handover protocol. |
| `HtmlText` | nvarchar(max), null |  | Html text of the document. |

## dbo.tblDocumentKind

Kinds of documents. Texts in tblDict

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intDocumentKindId` | int, not null |  |  |

## dbo.tblFile

Detected files on the computer (SW detection).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intFileId` | int, not null |  |  |
| `txtName` | nvarchar(255), null |  |  |
| `txtExt` | nvarchar(255), null |  |  |
| `intSize` | int, null |  |  |
| `iInsertSourceRecordAuxId` | int, null |  |  |
| `ProductId` | int, null | `dbo.tblProduct` | Recognized product. |
| `FileImageId` | int, null | `dbo.tblFileImage` | Recognized based on the rule. |
| `OriginalProductId` | int, null | `dbo.tblProduct` | Original recognized product |
| `Hash` | varbinary, not null |  | File signature. |
| `EvalSwLibDate` | datetime, null |  | The date of the library according to which the file has been recognized. |

## dbo.tblFileImage

Recognition rules for files (software product library).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intFileImageId` | int, not null |  |  |
| `intFileImageUID` | int, not null |  |  |
| `txtName` | nvarchar(255), null |  |  |
| `txtExt` | nvarchar(255), null |  |  |
| `intSize` | int, null |  |  |
| `intFileVersionMSLo` | int, null |  |  |
| `intFileVersionMSHi` | int, null |  |  |
| `intFileVersionLSLo` | int, null |  |  |
| `intFileVersionLSHi` | int, null |  |  |
| `intProductVersionMSLo` | int, null |  |  |
| `intProductVersionMSHi` | int, null |  |  |
| `intProductVersionLSLo` | int, null |  |  |
| `intProductVersionLSHi` | int, null |  |  |
| `intLanguage` | int, null |  |  |
| `intCodePage` | int, null |  |  |
| `txtComments` | nvarchar(255), null |  |  |
| `txtCompanyName` | nvarchar(255), null |  |  |
| `txtFileDescription` | nvarchar(255), null |  |  |
| `txtFileVersion` | nvarchar(255), null |  |  |
| `txtInternalName` | nvarchar(255), null |  |  |
| `txtLegalCopyright` | nvarchar(255), null |  |  |
| `txtLegalTrademarks` | nvarchar(255), null |  |  |
| `txtOriginalFilename` | nvarchar(255), null |  |  |
| `txtProductName` | nvarchar(255), null |  |  |
| `txtProductVersion` | nvarchar(255), null |  |  |
| `txtPrivateBuild` | nvarchar(255), null |  |  |
| `txtSpecialBuild` | nvarchar(255), null |  |  |
| `bolProductKey` | bit, not null |  |  |
| `intOrder` | int, null |  |  |
| `intFlags` | int, null |  |  |
| `dteTimeStamp` | datetime, not null |  |  |
| `bolValid` | bit, not null |  |  |
| `txtCertifiedBy` | nvarchar(255), null |  |  |
| `lintProductId` | int, not null | `dbo.tblProduct` |  |

## dbo.tblFileStringInfo

Information on detected files - texts.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintFileId` | int, not null | `dbo.tblFile` |  |
| `intLanguage` | int, null |  |  |
| `intCodePage` | int, null |  |  |
| `txtComments` | nvarchar(255), null |  |  |
| `txtCompanyName` | nvarchar(255), null |  |  |
| `txtFileDescription` | nvarchar(255), null |  |  |
| `txtFileVersion` | nvarchar(255), null |  |  |
| `txtInternalName` | nvarchar(255), null |  |  |
| `txtLegalCopyright` | nvarchar(255), null |  |  |
| `txtLegalTrademarks` | nvarchar(255), null |  |  |
| `txtOriginalFilename` | nvarchar(255), null |  |  |
| `txtProductName` | nvarchar(255), null |  |  |
| `txtProductVersion` | nvarchar(255), null |  |  |
| `txtPrivateBuild` | nvarchar(255), null |  |  |
| `txtSpecialBuild` | nvarchar(255), null |  |  |

## dbo.tblFileVerInfo

Information on detected files - versions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintFileId` | int, not null | `dbo.tblFile` |  |
| `intFileVersionMS` | int, null |  |  |
| `intFileVersionLS` | int, null |  |  |
| `intProductVersionMS` | int, null |  |  |
| `intProductVersionLS` | int, null |  |  |
| `intFileFlagsMask` | int, null |  |  |
| `intFileFlags` | int, null |  |  |
| `intFileOS` | int, null |  |  |
| `intFileType` | int, null |  |  |
| `intFileSubtype` | int, null |  |  |
| `intFileDateMS` | int, null |  |  |
| `intFileDateLS` | int, null |  |  |

## dbo.tblHistory

Log - history of objects in the tree - move, deletion, insertion, etc.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intHistoryId` | int, not null |  | Record ID |
| `lintNodeId` | int, not null | `dbo.tblNode` | object - tblNode; always different from null |
| `lintDetectId` | int, null | `dbo.tblDetect` | detection - tblDetect; Null is possible, provided the operation was executed manually without a link to the detection |
| `dteDateTime` | datetime, null |  | date and time |
| `intFlags` | int, null |  | 1 = The child object inserted 2 = Object deleted 4 = Deleted from 8 = Inserted to 256 = Child object inserted (moved) 512 = Child object deleted (moved) 768 = Move 1024 = A new child object inserted 1280 = Inserted new to 1536 = Child object inserted (moved) 1792 = Child object deleted (moved) 2048 = Moved to 2304 = A new child object inserted 2560 = Inserted new to 2816 = Automatic move 3072 = Child object inserted (moved automatically by rule) 3328 = Child object deleted (moved automatically by rule) 3329 = Relations copied from object 3330 = Relations copied to object 3331 = Relations moved from object 3332 = Relations moved to object 3333 = Object replaced by 3334 = Object replaced something |
| `lintOpNodeId` | int, null | `dbo.tblNode` | object X - tblNodeId; This attribute can be NULL, if object X was removed from the database |
| `txtOpNodeName` | nvarchar(255), null |  | name of object X including full path |
| `liPersonId` | int, not null | `dbo.tPerson` | Author of recorded operation - tPerson |
| `lintOp2NodeId` | int, null | `dbo.tblNode` | object Y - tblNodeId; This attribute can be NULL, if object Y was removed from the database |
| `txtOp2NodeName` | nvarchar(255), null |  | name of object Y including full path |
| `RemovedDate` | datetime, null |  |  |
| `RemovedByPersonId` | int, null | `dbo.tPerson` |  |
| `ObjectRuleId` | int, null | `dbo.ObjectRule` |  |

## dbo.tblIcon

Icons.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intIconId` | int, not null |  | icon Id |
| `txtDesc` | nvarchar(255), null |  | icon name |
| `uid` | int, null |  | Unique identifier UID (only system icons) |
| `Svg` | varbinary, null |  | Icon in SVG format |

## dbo.tblIdSeq

Numeric sequences - definitions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intIdSeqId` | int, not null |  | 1 = Media 2 = Invoices 3 = Acceptance Protocols 4 = Documents 5 = Certificates 6 = EULAs |
| `txtPrefix` | nvarchar(255), null |  | Prefix |
| `NextNumber` | nvarchar(60), null |  | Next number that will be used. Formatting including "0" is preserved. |
| `txtSuffix` | nvarchar(255), null |  | Suffix |
| `sName` | nvarchar(255), null |  | Sequence name |
| `liKindId` | int, null | `dbo.tblKind` | Property |
| `bUse` | bit, not null |  | 1=series is active |
| `IdSeqTypeId` | int, null | `dbo.IdSeqType` | Numeric sequence type. |

## dbo.tblInstHist

Records on installation and uninstallation of products on the computers (manual as well as detected)

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intInstHistId` | int, not null |  | installation id |
| `lintComputerNodeId` | int, not null | `dbo.tblNode` | Computer - tblNode |
| `lintProductId` | int, not null | `dbo.tblProduct` | Product - tblProduct |
| `lintInstallDetectId` | int, null | `dbo.tblDetect` | Which detection detected the installation - tblDetect |
| `lintUnistallDetectId` | int, null | `dbo.tblDetect` | Which detection detected the uninstallation - tblDetect |
| `dteInstallDetected` | datetime, null |  | Date on which the installation was detected |
| `dteUninstallDetected` | datetime, null |  | Date on which the uninstallation was detected |
| `dteInstalled` | datetime, null |  | Installed |
| `dteUninstalled` | datetime, null |  | Uninstalled |
| `txtMemo` | nvarchar(max), null |  | Note |
| `txtDetProductName` | nvarchar(255), null |  | Name of detected product |
| `txtDetProductVersion` | nvarchar(255), null |  | Version of detected product |
| `intDetLanguage` | int, null |  | Detection product language - LCID |
| `txtDetProductId` | nvarchar(255), null |  | Detected Product-ID |
| `txtDetInstallDate` | nvarchar(255), null |  | Detected installation date |
| `txtDetRecognizedBy` | nvarchar(255), null |  | Recognized by |
| `txtDetCDKey` | nvarchar(255), null |  | Detected CD-Key |
| `liInstalledPersonId` | int, null | `dbo.tPerson` | Installed by - tPerson |
| `liUninstalledPersonId` | int, null | `dbo.tPerson` | Uninstalled by - tPerson |
| `Installed` | datetime, null |  | Date of manual or detected installation of the product. |
| `Uninstalled` | datetime, null |  | Date of manual or detected uninstallation of the product. |

## dbo.tblInstTrial

Special installation.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintProductId` | int, not null | `dbo.tblProduct` | Product - tblProduct |
| `lintComputerNodeId` | int, not null | `dbo.tblNode` | Computer - tblNode |
| `txtDesc` | nvarchar(255), null |  | Note |
| `ValidUntil` | datetime, null |  | Date of expiration |

## dbo.tblKind

Definitions of the objects properties.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intKindId` | int, not null |  | primary key |
| `txtName` | nvarchar(255), not null |  | property name |
| `intFlags` | int, null |  | bit field: 0x20 = property not inheritable |
| `lintValueKindId` | int, null | `dbo.tblKind` | This attribute contains the tblKind.intKindId definition of the property, from which the list of values shall be used (tblKindValue) |
| `bolGlobalScope` | bit, not null |  | 1 = global property for a class of objects. "0" indicates the property is considered local for each class of objects (printers, computers etc.). An automatic list of values is then put together from the values of this property for the given object class, |
| `bolUnique` | bit, not null |  | 1 = property value must be unique |
| `intOrder` | int, null |  | The sequence for table filtering can be set |
| `intKindCode` | int, null |  | The unique number determines the property (integrated ones are numbered), user properties do not have this number |
| `bSelectOnly` | bit, not null |  | 1 = property value can only be selected from the list of values |
| `CleanValueByCopying` | bit, not null |  | 1 = Delete value when copying properties |
| `KindDataTypeId` | int, not null | `dbo.KindDataType` | Property data type ID. |
| `RequiredForAllClasses` | bit, not null |  | 1 = the property is mandatory in objects of all kinds that use it. In this case, there is no record for it in the RequiredClassKind table. |
| `ColumnName` | nvarchar(255), null |  | NodeCust table column name that stores the property value. NULL = the object property is not used in any object class and has no representation in the NodeCust table. |
| `Category` | nvarchar(max), null |  | Property categories |
| `Precision` | int, null |  | Precision of the decimal part of the number. |

## dbo.tblKindValue

Value lists for the properties of objects.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintKindId` | int, not null | `dbo.tblKind` | definition of property - tblKind |
| `txtValue` | nvarchar(255), null |  | Value |
| `KindValueBehaviorId` | int, null |  | System item identification |

## dbo.tblLang

ID of languages. Text in tblDict

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intLangId` | int, not null |  | language Id, e.g. 1029=Czech, 1051=Slovak, 1033=English |

## dbo.tblLicHist

License - list of purchased software licenses.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intLicHistId` | int, not null |  | Record ID |
| `lintProductId` | int, not null | `dbo.tblProduct` | Product - tblProduct |
| `LicenseCount` | int, null |  | Number of purchased licenses |
| `dteDate` | date, not null |  | Purchase date |
| `dteDateExpire` | date, null |  | Date of expiration |
| `txtLicName` | nvarchar(255), null |  | License name |
| `txtMemo` | nvarchar(max), null |  | Note |
| `txtDepartment` | nvarchar(255), null |  | Cost center |
| `txtInventoryNum` | nvarchar(255), null |  | Inventory number |
| `dteUpgradeTo` | date, null |  | Date of upgrading to ... |
| `txtActivationKey` | nvarchar(1024), null |  | Activation key |
| `CreatedPersonId` | int, null | `dbo.tPerson` | Author - tPerson |
| `CreatedDate` | datetime, null |  | Created. |
| `LicKindId` | int, not null | `dbo.LicKind` | 1 = devices 2 = user 3 = connection 4 = processor |
| `AutoAssign` | bit, not null |  | Assign automatically |
| `MultiAssign` | bit, not null |  | A flag indicating whether multiple license items can be assigned to the same object. |
| `LicTypeId` | int, null | `dbo.LicType` | License type. |
| `AutoAssignFilter` | nvarchar(max), null |  | Filter for automatic assignment of licenses. |
| `InvalidatedDate` | datetime, null |  | The date on which the license was invalidated. |
| `InvalidatedByPersonId` | int, null | `dbo.tPerson` | The person who has invalidated the license. |
| `AutoAssignNow` | bit, not null |  | A tag indicating whether the license should be automatically and immediately assigned. |
| `OrganizationNodeId` | int, null | `dbo.tblNode` | Organization ID. |
| `IsValid` | bit, not null |  | A flag indicating whether the license is valid. |
| `UId` | nvarchar(255), null |  | Unique license identifier in the external system. |
| `CoverPackPartsWithoutPackageInstalled` | bit, not null |  | Cover package components when package itself is not installed. 0 = the license will cover the components of the package only if the license package itself is installed. 1 = the license covers the components of the package even if the package itself is not installed. |
| `NoProductInstallation` | bit, not null |  | Check whether the assigned license covers any installations on endpoint devices or not (SaaS, CAL). |
| `ProductNotes` | nvarchar(255), null |  |  |
| `IsSample` | bit, not null |  |  |

## dbo.tblLicHistItem

License - license items.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intLicHistItemId` | int, not null |  | Record ID |
| `lintLicHistId` | int, not null | `dbo.tblLicHist` | License ID - tblLicHist |
| `NodeId` | int, null | `dbo.tblNode` | Computer ID - tblNode |
| `ActivationKey` | nvarchar(1024), null |  | Serial number |
| `txtMemo` | nvarchar(max), null |  | Note |
| `txtInventoryNum` | nvarchar(255), null |  | Inventory number |
| `txtDepartment` | nvarchar(255), null |  | Center |
| `txtRequest` | nvarchar(255), null |  | Ticket |
| `AutoAssigned` | bit, not null |  | Automatically assigned item |
| `LicensesCount` | int, not null |  | Number of assigned licenses |
| `ExternalObjectId` | int, null | `dbo.ExternalObject` | External object ID |

## dbo.tblLicTrans

License - shared licenses.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintProductId` | int, not null | `dbo.tblProduct` | Product - tblProduct |
| `NodeId` | int, not null | `dbo.tblNode` | Computer - tblNode |
| `LicNodeId` | int, not null | `dbo.tblNode` | Computer from which the license is shared - tblNode |
| `txtDesc` | nvarchar(255), null |  | Note |

## dbo.tblLog

Log - changes in the properties values and information on the detection results.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intLogId` | int, not null |  | Record ID |
| `lintNodeId` | int, null | `dbo.tblNode` | object - tblNode |
| `lintDetectId` | int, null | `dbo.tblDetect` | detection - tblDetect |
| `dteLog` | datetime, null |  | date and time |
| `lintLogKindId` | int, null |  | record type: 0 = unclassified 1 = information 2 = warning 3 = error 4 = property value change 5 = computer is off 6 = detection file does not exist yet (this is a detection via a shared folder) 7 = data in detection differs from data in inventory 8 = object cannot be automatically updated according to the detection 9 = hw detection performed 10 = sw detection performed 11 = inventory performed 12 = duplicate computer name |
| `txtLog` | nvarchar(max), null |  | record text |
| `lintInventoryId` | int, null |  |  |
| `liLogPersonId` | int, null | `dbo.tPerson` | author - tPerson |
| `RemovedDate` | datetime, null |  |  |
| `RemovedByPersonId` | int, null | `dbo.tPerson` |  |
| `KindId` | int, null | `dbo.tblKind` | ID of the property definition related to the change. |
| `DetectKindId` | int, null | `dbo.tblDetectKind` |  |

## dbo.tblMedia

Media.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `IdNumber` | nvarchar(255), null |  | Identification number |
| `lintMediaTypeId` | int, not null | `dbo.tblMediaType` | Type - tblMediaTypeId |
| `txtTitle` | nvarchar(255), null |  | Name |
| `txtAuthor` | nvarchar(255), null |  | Author |
| `txtMemo` | nvarchar(max), null |  | Note |
| `txtLocation` | nvarchar(255), null |  | Location |

## dbo.tblMediaType

ID of the media types. Texts in tblDict.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intMediaTypeId` | int, not null |  |  |

## dbo.tblNode

Objects in the tree.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intNodeId` | int, not null |  | Object id |
| `lintParentId` | int, null | `dbo.tblNode` | Id of parent object, foreign key to tblNode |
| `lintIconId` | int, null | `dbo.tblIcon` | icon - tblIcon |
| `intState` | int, null |  | bit field: 1 = Recycle Bin object 2 = the object is protected against deletion 4 = Object Template object 8 = object cannot obe moved 0x10 = hidden object 0x20 = object template 0x40 = property list tabs 0x80 = history is not kept for the object 0x100 = folder "Computer found in network" |
| `txtName` | nvarchar(255), null |  | object name |
| `lintClassId` | int, not null | `dbo.tblClass` | object type - tblClass |
| `bolComputerStateOn` | bit, null |  | 1=object represents the last computer to respond to ping, 0=computer did not respond, NULL=ping not applied |
| `txtPath` | nvarchar(1024), null |  | path to object in tree, e.g., "Contoso/Prague/Sales Department" |
| `liSwProfileId` | int, null | `dbo.tSwProfile` | which SW profile does the computer use |
| `bSwAllAllowed` | bit, not null |  | 1=all software is allowed on PC for profiles |
| `LastAgentWSContact` | datetime, null |  |  |
| `NotNullParentId` | int, not null |  | The ID of the parent object; in the case of no parent object, 0 is here. |
| `DetectProfileId` | int, null | `dbo.DetectProfile` | Computer detection profile |
| `RequiredPropertyAlert` | bit, not null |  | The object does not have any of the required properties filled in. |
| `PathLen` | int, null |  |  |
| `IsDiscarded` | bit, not null |  | 1 = the object is discarded. |
| `IsRemoved` | bit, not null |  | 1 = Whether the object is in the Recycle bin. |
| `IsTemplate` | bit, not null |  | 1 = the object is object template. |
| `IsHidden` | bit, null |  | 1 = the object is the Recycle bin, or Object templates, or Property categories, or their child object. |
| `IsActive` | bit, null |  | 1 = the object is not the Discarded assets, or the Recycle bin, or Object templates, or Property categories, neither their child object. |
| `Search` | nvarchar(max), null |  | Column for regular search. |
| `IsSample` | bit, not null |  | Is data sample. |
| `Created` | datetime, null |  | Object creation date. |
| `ImportDuplicateAlert` | bit, not null |  | Two or more devices matched onto this object during import. |
| `AssetLabelHtml` | nvarchar(max), null |  | Asset label HTML |
| `UniqueId` | nvarchar(255), null |  | Unique identifier for the object. |
| `SearchNormalized` | nvarchar(max), null |  | Column for full text search. |
| `AssetLabelCreatedDate` | datetime, null |  | Date and time when the asset label was generated. |

## dbo.tblNodeParent

Objects in the tree - tree.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintNodeId` | int, not null |  | object - tblNode |
| `lintParentNodeId` | int, not null |  | object on path to tree root - tblNode |

## dbo.tblNotice

Notes.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intNoticeId` | int, not null |  | Record ID |
| `lintNodeId` | int, not null | `dbo.tblNode` | object - tblNodeId |
| `dteDateTime` | datetime, null |  | date and time the note was created |
| `txtSubject` | nvarchar(255), null |  | subject |
| `txtDesc` | nvarchar(max), null |  | text |
| `liPersonId` | int, null | `dbo.tPerson` | author - tPerson |
| `RemovedDate` | datetime, null |  |  |
| `RemovedByPersonId` | int, null | `dbo.tPerson` |  |

## dbo.tblOsVersionInfo

Detection of SW - information on the operating system.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintDetectId` | int, not null | `dbo.tblDetect` |  |
| `intMajorVersion` | int, null |  |  |
| `intMinorVersion` | int, null |  |  |
| `intBuildNumber` | int, null |  |  |
| `intPlatformId` | int, null |  |  |
| `txtCSDVersion` | nvarchar(255), null |  |  |
| `intServicePackMajor` | int, null |  |  |
| `intServicePackMinor` | int, null |  |  |
| `intSuiteMask` | int, null |  |  |
| `intProductType` | int, null |  |  |

## dbo.tblProduct

Products / software (software product library).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intProductId` | int, not null |  |  |
| `intProductUID` | int, null |  |  |
| `txtName` | nvarchar(255), not null |  |  |
| `txtVersion` | nvarchar(255), null |  |  |
| `txtEdition` | nvarchar(255), null |  |  |
| `txtPlatform` | nvarchar(255), null |  |  |
| `lintLangId` | int, null |  |  |
| `lintProducerCompanyId` | int, null | `dbo.tblCompany` |  |
| `lintProductTypeId` | int, not null | `dbo.tblProductType` |  |
| `lintProductCategoryId` | int, null | `dbo.tblProductCategory` |  |
| `txtDescription` | nvarchar(255), null |  |  |
| `intFlags` | int, null |  |  |
| `dteTimeStamp` | datetime, not null |  |  |
| `bolValid` | bit, not null |  |  |
| `txtCertifiedBy` | nvarchar(255), null |  |  |
| `nPrice` | float, null |  |  |
| `SamTypeId` | int, not null | `dbo.SamType` |  |
| `AlternateApprovedProduct` | nvarchar(max), null |  |  |
| `ProductStateId` | int, not null | `dbo.ProductState` |  |
| `SupportedVersion` | nvarchar(32), null |  |  |
| `ProductStateModifiedPersonId` | int, null | `dbo.tPerson` |  |
| `ProductStateModifiedDate` | datetime, null |  |  |
| `ProductRejectedFrom` | datetime, null |  |  |
| `IsSample` | bit, not null |  |  |
| `FullName` | nvarchar(1023), null |  |  |
| `ProductCpe` | nvarchar(max), null |  |  |
| `IsProductCpeManual` | bit, not null |  |  |
| `CpeMatchScore` | float, not null |  |  |

## dbo.tblProductCategory

ID of the product categories (OS). Text in tblDict.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intProductCategoryId` | int, not null |  |  |

## dbo.tblProductPack

Definition of software product packages (software product library).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintProductPackId` | int, not null | `dbo.tblProduct` |  |
| `lintProductId` | int, not null | `dbo.tblProduct` |  |
| `intFlags` | int, null |  |  |
| `dteTimeStamp` | datetime, not null |  |  |
| `bolValid` | bit, not null |  |  |
| `txtCertifiedBy` | nvarchar(255), null |  |  |

## dbo.tblProductType

ID of the product types (commercial, freeware, ...) (software product library).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intProductTypeId` | int, not null |  |  |

## dbo.tblPropertyMap

Mapping properties to system functions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intPropertyMapId` | int, not null |  |  |
| `lintPropertyMapTypeId` | int, null |  |  |
| `lintObjClassId` | int, null | `dbo.tblClass` |  |
| `lintObjKindId` | int, null | `dbo.tblKind` |  |
| `lintKindId` | int, null | `dbo.tblKind` |  |
| `lintMapObjClassId` | int, null | `dbo.tblClass` |  |
| `lintMapObjKindId` | int, null | `dbo.tblKind` |  |
| `lintMapKindId` | int, null | `dbo.tblKind` |  |

## dbo.tblRegImage

Software product library - recognition rules for records from the register.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intRegImageId` | int, not null |  |  |
| `intRegImageUID` | int, not null |  |  |
| `txtDisplayName` | nvarchar(255), null |  |  |
| `txtDisplayVersion` | nvarchar(255), null |  |  |
| `intVersionMajorLo` | int, null |  |  |
| `intVersionMinorLo` | int, null |  |  |
| `intVersionMajorHi` | int, null |  |  |
| `intVersionMinorHi` | int, null |  |  |
| `intLanguage` | int, null |  |  |
| `txtPublisher` | nvarchar(255), null |  |  |
| `txtComments` | nvarchar(255), null |  |  |
| `txtPath` | nvarchar(255), null |  |  |
| `bolProductKey` | bit, not null |  |  |
| `intOrder` | int, null |  |  |
| `intFlags` | int, null |  |  |
| `dteTimeStamp` | datetime, not null |  |  |
| `bolValid` | bit, not null |  |  |
| `txtCertifiedBy` | nvarchar(255), null |  |  |
| `lintProductId` | int, not null | `dbo.tblProduct` |  |

## dbo.tblRegUninstall

Detected registry entries. The table contains records which may repeat in various computers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intRegUninstallId` | int, not null |  |  |
| `lintRootRegKeyId` | int, not null |  |  |
| `txtPath` | nvarchar(255), not null |  |  |
| `txtDisplayName` | nvarchar(255), null |  |  |
| `txtDisplayVersion` | nvarchar(255), null |  |  |
| `intVersion` | int, null |  |  |
| `intLanguage` | int, null |  |  |
| `txtPublisher` | nvarchar(255), null |  |  |
| `txtComments` | nvarchar(255), null |  |  |
| `txtAuthorizedCDFPrefix` | nvarchar(255), null |  |  |
| `txtContact` | nvarchar(255), null |  |  |
| `txtHelpLink` | nvarchar(255), null |  |  |
| `txtHelpTelephone` | nvarchar(255), null |  |  |
| `intSystemComponent` | int, null |  |  |
| `txtSize` | nvarchar(255), null |  |  |
| `txtURLInfoAbout` | nvarchar(255), null |  |  |
| `txtURLUpdateInfo` | nvarchar(255), null |  |  |
| `intVersionMajor` | int, null |  |  |
| `intVersionMinor` | int, null |  |  |
| `intWindowsInstaller` | int, null |  |  |
| `lintProductId` | int, null | `dbo.tblProduct` |  |
| `lintRegImageId` | int, null | `dbo.tblRegImage` |  |
| `lintOriginalProductId` | int, null | `dbo.tblProduct` |  |
| `Hash` | varbinary, not null |  |  |
| `EvalSwLibDate` | datetime, null |  |  |
| `FullName` | nvarchar(511), not null |  |  |

## dbo.tblRegValue

Detection - values of detected records from the register.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intRegValueId` | int, not null |  |  |
| `lintDetectId` | int, not null | `dbo.tblDetect` |  |
| `lintRootRegKeyId` | int, not null |  |  |
| `txtPath` | nvarchar(255), null |  |  |
| `txtName` | nvarchar(255), null |  |  |
| `txtValue` | nvarchar(255), null |  |  |

## dbo.tblSetting

Mapping properties to system functions.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `txtKey` | nvarchar(255), not null |  |  |
| `txtValue` | nvarchar(255), null |  |  |
| `intValue` | int, null |  |  |

## dbo.tblSystemSetting

System settings.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `bolDetect_RestrictDetectionCnt` | bit, not null |  |  |
| `bolNode_Rights` | bit, not null |  |  |

## dbo.tblUserNodeRight

Rights in the object tree to groups / users.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intUserNodeRightId` | int, not null |  |  |
| `lintNodeId` | int, null | `dbo.tblNode` |  |
| `lintClassId` | int, null | `dbo.tblClass` |  |
| `bolRecursive` | bit, not null |  |  |
| `bolRead` | bit, null |  |  |
| `bolWrite` | bit, null |  |  |
| `bolMove` | bit, null |  |  |
| `bolDelete` | bit, null |  |  |
| `liPersonId` | int, null | `dbo.tPerson` |  |
| `liRoleId` | int, null | `dbo.tRole` |  |
| `CreateObj` | bit, null |  |  |

## dbo.tblVersion

Software product library version.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intVersion` | int, null |  | database version number (=35 and further recorded in tDb) |
| `intDataVersion` | int, null |  | basic data version number |
| `dteSwLib` | datetime, null |  | Software product library version date |
| `intLangId` | int, null |  | Database language |
| `intLanguage` | int, null |  | Database language |

## dbo.tblWbemClassDesc

Code list of values for the detected HW properties.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `txtCLASS` | nvarchar(255), null |  |  |
| `txtPropName` | nvarchar(255), null |  |  |
| `intPropValueIndex` | int, null |  |  |
| `txtPropValueDesc` | nvarchar(255), null |  |  |

## dbo.tblWbemObject

HW detected in the computers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `intWbemObjectId` | bigint, not null |  |  |
| `lintDetectId` | int, not null | `dbo.tblDetect` |  |
| `bolVirtualObject` | bit, not null |  |  |
| `__CLASS` | nvarchar(255), null |  |  |
| `AdapterRAM` | float, null |  |  |
| `AdapterType` | nvarchar(255), null |  |  |
| `AttachedTo` | nvarchar(255), null |  |  |
| `Availability` | int, null |  |  |
| `BankLabel` | nvarchar(255), null |  |  |
| `BaseBoard` | nvarchar(255), null |  |  |
| `Capacity` | bigint, null |  |  |
| `Caption` | nvarchar(255), null |  |  |
| `ChassisTypes` | int, null |  |  |
| `txtChassisTypesDesc` | nvarchar(255), null |  |  |
| `Compressed` | bit, null |  |  |
| `CSDVersion` | nvarchar(255), null |  |  |
| `CurrentClockSpeed` | int, null |  |  |
| `CurrentRefreshRate` | int, null |  |  |
| `DataWidth` | int, null |  |  |
| `Description` | nvarchar(255), null |  |  |
| `DeviceID` | nvarchar(255), null |  |  |
| `DeviceLocator` | nvarchar(255), null |  |  |
| `DeviceType` | nvarchar(255), null |  |  |
| `DHCPEnabled` | bit, null |  |  |
| `DNSServerSearchOrder` | nvarchar(255), null |  |  |
| `Prop_Domain` | nvarchar(255), null |  |  |
| `Drive` | nvarchar(255), null |  |  |
| `DriveType` | int, null |  |  |
| `EDIDVersion` | nvarchar(255), null |  |  |
| `FileSystem` | nvarchar(255), null |  |  |
| `FormFactor` | int, null |  |  |
| `txtFormFactorDesc` | nvarchar(255), null |  |  |
| `FreeSpace` | float, null |  |  |
| `InstallDate` | datetime, null |  |  |
| `InfraredSupported` | bit, null |  |  |
| `InterfaceType` | nvarchar(255), null |  |  |
| `IPAddress` | nvarchar(255), null |  |  |
| `IPEnabled` | bit, null |  |  |
| `IPSubnet` | nvarchar(255), null |  |  |
| `IRQNumber` | int, null |  |  |
| `MACAddress` | nvarchar(255), null |  |  |
| `ManufactureDate` | datetime, null |  |  |
| `Manufacturer` | nvarchar(255), null |  |  |
| `MaxCapacity` | int, null |  |  |
| `MaxClockSpeed` | int, null |  |  |
| `MaxRefreshRate` | int, null |  |  |
| `MediaType` | nvarchar(255), null |  |  |
| `MemoryDevices` | int, null |  |  |
| `MemoryType` | int, null |  |  |
| `txtMemoryTypeDesc` | nvarchar(255), null |  |  |
| `MinRefreshRate` | int, null |  |  |
| `Model` | nvarchar(255), null |  |  |
| `MonitorManufacturer` | nvarchar(255), null |  |  |
| `Monochrome` | bit, null |  |  |
| `PartOfDomain` | bit, null |  |  |
| `Prop_Name` | nvarchar(255), null |  |  |
| `NetConnectionID` | nvarchar(255), null |  |  |
| `Organization` | nvarchar(255), null |  |  |
| `OSLanguage` | int, null |  |  |
| `PNPDeviceID` | nvarchar(255), null |  |  |
| `PortName` | nvarchar(255), null |  |  |
| `ProcessorId` | nvarchar(255), null |  |  |
| `Prop_Product` | nvarchar(255), null |  |  |
| `RegisteredUser` | nvarchar(255), null |  |  |
| `ScreenHeight` | int, null |  |  |
| `ScreenWidth` | int, null |  |  |
| `SerialNumber` | nvarchar(255), null |  |  |
| `Prop_Size` | float, null |  |  |
| `Service` | nvarchar(255), null |  |  |
| `ServiceName` | nvarchar(255), null |  |  |
| `SMBIOSBIOSVersion` | nvarchar(255), null |  |  |
| `SocketDesignation` | nvarchar(255), null |  |  |
| `Speed` | nvarchar(255), null |  |  |
| `StatusInfo` | int, null |  |  |
| `txtStatusInfoDesc` | nvarchar(255), null |  |  |
| `SystemDirectory` | nvarchar(255), null |  |  |
| `SystemType` | nvarchar(255), null |  |  |
| `TotalPhysicalMemory` | bigint, null |  |  |
| `TypeDetail` | int, null |  |  |
| `txtTypeDetailDesc` | nvarchar(255), null |  |  |
| `UPSPort` | nvarchar(255), null |  |  |
| `UserName` | nvarchar(255), null |  |  |
| `Version` | nvarchar(255), null |  |  |
| `VideoModeDescription` | nvarchar(255), null |  |  |
| `VolumeSerialNumber` | nvarchar(255), null |  |  |
| `WakeUpType` | int, null |  |  |
| `txtWakeUpTypeDesc` | nvarchar(255), null |  |  |
| `AlvaoVirtualMachineHostname` | nvarchar(128), null |  |  |
| `NumberOfLogicalProcessors` | int, null |  |  |
| `Active` | bit, null |  |  |
| `MaxHorizontalImageSize` | int, null |  |  |
| `MaxVerticalImageSize` | int, null |  |  |
| `DriveLetter` | nvarchar(16), null |  | Drive letter. |
| `ProtectionStatus` | int, null |  | The status of drive section encryption by the BitLocker tool. 0 = off, 1 = on, 2 = unknown. |
| `NumberOfCores` | int, null |  | Number of physical CPU cores. |
| `IsActivated` | bit, null |  |  |
| `IsEnabled` | bit, null |  |  |
| `IsOwned` | bit, null |  |  |
| `ManufacturerVersion` | nvarchar(128), null |  |  |
| `ManufacturerVersionFull20` | nvarchar(128), null |  |  |
| `ManufacturerVersionInfo` | nvarchar(128), null |  |  |
| `PhysicalPresenceVersionInfo` | nvarchar(128), null |  |  |
| `SpecVersion` | nvarchar(128), null |  |  |
| `UniqueId` | nvarchar(255), null |  | Unique identifier for the hardware object. |
| `DnsDomain` | nvarchar(255), null |  | DNS domain of the computer. |

## dbo.tblWbemObjectProcess

Hardware "Blacklist".

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `txtCLASS` | nvarchar(255), null |  |  |
| `txtPropName` | nvarchar(255), null |  |  |
| `txtPropValue` | nvarchar(255), null |  |  |
| `bolSetObjectAsVirtual` | bit, not null |  |  |
| `bolClearObjectProp` | bit, not null |  |  |

## dbo.tblWbemObjectRel

Links between the detected components of the computers.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `lintWbemObjectId1` | bigint, not null | `dbo.tblWbemObject` |  |
| `lintWbemObjectId2` | bigint, not null | `dbo.tblWbemObject` |  |

## dbo.tColumn

List of custom fields and certain system fields.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iColumnId` | int, not null |  | Item ID. |
| `sTable` | nvarchar(128), null |  | Name of the table where the values of the item are stored. |
| `sColumn` | nvarchar(128), null |  | Name of the column in the table where the values of the item are stored. |
| `sTitle` | nvarchar(255), not null |  | Displayed item name. |
| `mDescription` | nvarchar(max), null |  | Item description. |
| `nOrder` | float, not null |  | The order of items as they are described on the forms. |
| `bUseColumnValue` | bit, not null |  | Use the value list. |
| `Removed` | datetime, null |  | Date of item removal. |
| `Multiline` | bit, not null |  | Multi-row text. |
| `Localize` | bit, not null |  | The flag specifying whether translation of value lists of a custom field into other languages is enabled / allowed. |
| `Type` | nvarchar(128), null |  | Custom field data type. May contain basic types (i.e. nvarchar, bit, int, datetime, float) or advanced data types: user â int representing foreign key to tPerson (i.e. tPerson.iPersonId) |
| `MaxLength` | int, null |  | The maximum length of a custom field in characters. |
| `RoleId` | int, null |  | Source group of field type User (tRole.iRoleId). |
| `Precision` | int, null |  | Precision of the decimal part of the number. |
| `IncludeInIntegrations` | bit, not null |  |  |

## dbo.tColumnValue

Value lists for custom fields.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iColumnValueId` | int, not null |  | Record ID. |
| `liColumnId` | int, not null | `dbo.tColumn` | Link to custom field record. |
| `liHdSectionId` | int, null | `dbo.tHdSection` | NULL represents an item on the list of values applies to all services. The view is otherwise limited only to the configured service. |
| `mColumnValue` | nvarchar(max), not null |  | Displayed item name. |
| `nOrder` | float, not null |  | Order for displaying items, sorted from lowest to highest number. |
| `sExtra1` | nvarchar(255), null |  |  |
| `ParentValue` | int, null | `dbo.tColumnValue` | Parent tree item. |
| `ColumnValueShort` | nvarchar(max), not null |  | Full name including path via parent items. |

## dbo.tDay

Calendar of days

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `dDay` | datetime, not null |  |  |

## dbo.tDb

Database version, database language ID, activation keys for the entire ALVAO.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iDbVersion` | int, null |  |  |
| `sDb` | nvarchar(255), null |  |  |
| `sDbActivation` | nvarchar(max), null |  |  |
| `iDbLocaleId` | int, not null |  |  |
| `Version` | nvarchar(32), not null |  |  |
| `AlvaoVersion` | nvarchar(50), null |  | Product version for which the database is intended. |

## dbo.tDocument

Attachments (to documents, notes, events, emails, ...) concerning the entire ALVAO system.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iDocumentId` | int, not null |  | Record ID. |
| `sDocument` | nvarchar(255), null |  | File name. |
| `sDocumentContentType` | nvarchar(255), null |  | MIME file type. |
| `oDocument` | varbinary, null |  | Binary data set if a file is attached. This column is NULL for a reference attachment |
| `liDocumentActId` | int, null | `dbo.tAct` | Event ID in the ticket log (tAct) to which the attachment belongs. |
| `liDocumentArticleId` | int, null | `dbo.tArticle` | Article ID in the Knowledge Base (tArticle) to which the attachment belongs. |
| `Url` | nvarchar(max), null |  | URL address if it is the attachment of the link type. The column is NULL at the attachments of the file type. |
| `AMDocumentId` | int, null | `dbo.tblDocument` | Document ID in ALVAO Asset Management (tblDocument), to which the attachment belongs. |
| `AMNoticeId` | int, null | `dbo.tblNotice` | Object notice ID (tblNotice) to which the attachment belongs. |
| `TicketTemplateId` | int, null | `dbo.TicketTemplate` | ID of the ticket template (TicketTemplate) to which the attachment belongs. |
| `NewsId` | int, null | `dbo.News` | News post ID (News.id) to which the attachment belongs. |
| `EmailSignatureId` | int, null | `dbo.tEmailSignature` | User signature ID (tEmailSignature) to which the attachment belongs. |
| `HdTicketApprovalItemId` | int, null | `dbo.tHdTicketApprovalItem` | ID of the approval step (tHdTicketApprovalItem) to which the attachment belongs. |
| `EmbededImage` | bit, not null |  | If the value is 1, it is not an attachment but an image inserted directly into the formatted text. |
| `PrintReportTemplateId` | int, null | `dbo.PrintReportTemplate` | ID of the print report template (PrintReportTemplate) to which the attachment belongs. |
| `SolverInstructionsTicketStateId` | int, null | `dbo.TicketState` | Ticket status (TicketState.id) to whose instructions for resolvers this file belongs. |
| `NodeId` | int, null | `dbo.tblNode` | Id of the object (tblNode.intNodeId), to which the attachment belongs. |
| `Created` | datetime, null |  | Date and time on which was the document added. |
| `CreatedByPersonId` | int, null | `dbo.tPerson` | Id of the person (tPerson.iPersonId), who added the document. |
| `NewTicketFormTextBlockId` | int, null | `dbo.NewTicketFormTextBlock` | Text block (NewTicketFormTextBlock.Id) to whose this file belongs. |
| `UniqueGUID` | uniqueidentifier, not null |  |  |
| `OcrText` | nvarchar(max), null |  | Textual content of the image recognized by OCR |
| `OcrLastError` | nvarchar(max), null |  | Last error message returned by OCR |
| `RelatedTicketRuleId` | int, null |  | Related ticket rule ID to which the attachment belongs. |
| `TicketStatusTransitionFormTextBlockId` | int, null | `dbo.TicketStatusTransitionFormTextBlock` | Text block (TicketStatusTransitionFormTextBlock.Id) to whose this file belongs. |

## dbo.TeamsSchedule

Solvers schedules imported from MS Teams.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `PersonId` | int, not null | `dbo.tPerson` | Person ID (tPerson.iPersonId). |
| `LastUpdate` | datetime, not null |  | Last update timestamp (UTC). |

## dbo.TeamsShift

Solvers shifts imported from MS Teams.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | bigint, not null |  | Record ID. |
| `TeamsScheduleId` | int, not null | `dbo.TeamsSchedule` | Teams schedule ID (TeamsSchedule.Id). |
| `GraphShiftId` | nvarchar(255), not null |  | Shift ID in Graph API. |
| `Start` | datetime, not null |  | Start of the shift (UTC). |
| `End` | datetime, not null |  | End of the shift (UTC). |

## dbo.tEmailSignature

Signatures for email messages.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iEmailSignatureId` | int, not null |  |  |
| `liEmailSignaturePersonId` | int, null | `dbo.tPerson` |  |
| `sEmailSignature` | nvarchar(255), not null |  |  |
| `mEmailSignatureText` | nvarchar(max), null |  |  |
| `EmailSignatureHtml` | nvarchar(max), null |  | Description in HTML |

## dbo.tEmailTemplate

Templates of custom notifications and alerts sent by the ALVAO SAM Assistant module.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liHdSectionId` | int, null | `dbo.tHdSection` |  |
| `sNotificationKind` | nvarchar(64), null |  |  |
| `bActive` | bit, not null |  |  |
| `mSubject` | nvarchar(max), null |  |  |
| `mTextBody` | nvarchar(max), null |  |  |
| `SamAlertRuleId` | int, null | `dbo.SamAlertRule` |  |
| `TransferConfirmAlertRuleId` | int, null | `dbo.TransferConfirmAlertRule` | Kind of alert to sign the handover protocol. |
| `id` | int, not null |  | Template Id. |

## dbo.TenantDiagnosticsLog

Tenant diagnostics log records

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `LoggedDate` | datetime, not null |  | Time stamp of created log record (UTC by default). |
| `LogLevelId` | int, not null | `dbo.LogLevel` | Log level of the record |
| `Message` | nvarchar(max), null |  | Log message |
| `Application` | nvarchar(250), null |  | Name of application that generated the log record. |
| `Callsite` | nvarchar(max), null |  | Context of the logged event (e.g., a source code class name, method name, etc.) |
| `Exception` | nvarchar(max), null |  | Occurred exception information |
| `Parameters` | nvarchar(max), null |  | Additional detailed text parameters of the log record. |

## dbo.TenantSecurityChangeLog

Tenant security-change log records

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `LoggedDate` | datetime, not null |  | Time stamp of created log record (UTC by default). |
| `LogLevelId` | int, not null | `dbo.LogLevel` | Log level of the record |
| `Message` | nvarchar(max), null |  | Log message |
| `Application` | nvarchar(250), null |  | Name of application that has generated log record. |
| `Parameters` | nvarchar(max), null |  | Additional detailed text parameters of the log record. |

## dbo.TenantSigninLog

User sign in log records

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `LoggedDate` | datetime, not null |  | Time stamp of created log record (UTC by default). |
| `LogLevelId` | int, not null | `dbo.LogLevel` | Log level of the record |
| `Message` | nvarchar(max), null |  | Log message |
| `Application` | nvarchar(250), null |  | Name of application that has generated log record. |
| `Parameters` | nvarchar(max), null |  | Additional detailed text parameters of the log record. |

## dbo.tHdSection

ALVAO Service Desk product services.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdSectionId` | int, not null |  | Record ID. |
| `sHdSection` | nvarchar(1024), null |  | Full service name, including location. For example "Helpdesk/Technical Support". |
| `sHdSectionShort` | nvarchar(255), null |  | Service short name. For example "Technical Support". |
| `mHdSectionDesc` | nvarchar(max), null |  | Description of service. |
| `DescriptionHtml` | nvarchar(max), null |  |  |
| `ObjectsFieldName` | nvarchar(255), null |  | Custom objects field name |
| `nHdSectionOrder` | float, null |  | Order in which services are displayed. |
| `liHdSectionParentHdSectionId` | int, null | `dbo.tHdSection` | Link to ancestor in tree. |
| `sHdSectionEmail` | nvarchar(255), null |  | Service email. |
| `sHdSectionMessageTagPrefix` | nvarchar(255), null |  | Prefix in ticket number. |
| `sHdSectionMessageTagSuffix` | nvarchar(255), null |  | Suffix in ticket number. |
| `bHdSectionDefault` | bit, not null |  | Flaf to determine whether the service is default. 1 - service is default 0 - service is not default NULL - service is not default. Only one service can be default. |
| `sHdSectionPhone` | nvarchar(255), null |  | Phone number. |
| `sHdSectionImapServer` | nvarchar(255), null |  | Address of IMAP server for loading messages. |
| `sHdSectionUserShowFields` | nvarchar(1024), null |  | List of optional items that shall be displayed on the portal during the process of editing/viewing the ticket. |
| `nHdSectionUserReopenDays` | float, null |  | The number of days when the requester may reopen their ticket until the ticket is resolved. |
| `bHdSectionMessageRemove` | bit, not null |  | If the value is 1, processed messages are removed from the server. |
| `sHdSectionMailboxLogin` | nvarchar(255), null |  | Username for loading messages. |
| `sHdSectionMailboxPassword` | nvarchar(255), null |  | Password for loading messages. |
| `bHdSectionHdTicketUserRead` | bit, not null |  | If this is 1, the user can view the tickets of other users from the same organization in this service. |
| `UserManagerCanReadTickets` | bit, not null |  | Managers can read the tickets of their reports. |
| `bHdSectionFolder` | bit, not null |  | If the service is only a folder containing other services and the user cannot insert tickets, the value is 1. The button for creating a ticket for this service is not displayed in the portal. |
| `sHdSectionNewHdTicketUrl` | nvarchar(1024), null |  | URL of the custom form to create a new ticket. |
| `sHdSectionHdTicketCustomWorkflowUrl` | nvarchar(1024), null |  | Custom workflow URL. |
| `dHdSectionRemoved` | datetime, null |  | Time at which the service was removed. The service is not removed for NULL. |
| `bHdSectionMessageReadOnlyUnread` | bit, not null |  | If the value is 1, only unread messages are read. |
| `bHdSectionMessageMarkRead` | bit, not null |  | If the value is 1, messages are marked as read once the message is loaded. |
| `sHdSectionMessageFolder` | nvarchar(255), null |  | Target folder for moving loaded messages. |
| `bHdSectionImapSsl` | bit, not null |  | If the value is 1, SSL will be used for connecting to the IMAP server. |
| `TicketTypeId` | int, not null | `dbo.TicketType` |  |
| `ImapPort` | int, null |  |  |
| `UseFeedback` | bit, not null |  |  |
| `CustomFeedbackUrl` | nvarchar(max), null |  |  |
| `TileColor` | int, null |  |  |
| `TileType` | int, not null |  |  |
| `DefaultLanguageId` | int, null |  | Service local language. |
| `DefaultTimeZone` | nvarchar(64), null |  | Service local time zone. |
| `CreateNewFollowingRequest` | bit, not null |  |  |
| `CreateNewFollowingRequestToSection` | int, null |  |  |
| `ShowInServiceCatalog` | bit, not null |  | Column for the "View in the Service catalog" option. |
| `ForceUseSolverLicense` | bit, not null |  |  |
| `Keywords` | nvarchar(max), null |  | Service keywords. |
| `DefaultTicketTemplateId` | int, null | `dbo.TicketTemplate` | Default ticket template. |
| `TargetHdSectionId` | int, null | `dbo.tHdSection` | Target service of the service shortcut. |
| `IconName` | nvarchar(255), null |  | If the service icon was not loaded from the disk when upgrading to A10.2, this column displays "Upload failed <icon name>". This value in the service table overloads the display name of the icon from the icon library. Otherwise, this column is NULL. |
| `LibraryIconId` | int, not null | `dbo.LibraryIcon` |  |
| `TicketNameTemplate` | nvarchar(1023), null |  | Ticket name template. |
| `HomePage` | bit, not null |  | Service flag for setting the tiles on the home page. |
| `KnowledgeSharepointFolders` | nvarchar(max), null |  | List of SharePoint folder URLs relative to root folder. |
| `EwsServerName` | nvarchar(255), null |  | Name of Exchange server. |
| `EwsClientId` | nvarchar(255), null |  | Application ID. |
| `EwsTenantId` | nvarchar(255), null |  | Folder ID. |
| `EwsClientSecret` | nvarchar(255), null |  | Secret client code. |
| `SlaRightsSectionId` | int, not null | `dbo.tHdSection` | Id of the service (tHdSection.iHdSectionId) from which this service inherits SLA assignments. If this service doesnât inherit SLA assignments, this column contains the same value as the iHdSectionId column. If this record represents a service shortcut this column contains the same value as the TargetHdSectionId column or id of the service the target service inherits SLA assignments from. |
| `MailServerConnectionTypeId` | int, not null | `dbo.MailServerConnectionType` | Id of the mail server connection type (MailServerConnectionType.Id). |
| `GraphChangeNotificationEnabled` | bit, not null |  | Enable or disable using of Microsoft Graph API change notifications. |
| `GuestCanSeeTickets` | bit, not null |  | Enable if you want to allow non registered users (guests) to view ticket detail using a link sent in email notifications. |
| `DescriptionFieldName` | nvarchar(255), null |  |  |
| `UseDescriptionFieldName` | bit, not null |  |  |

## dbo.tHdSectionCust

Services custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liHdSectionId` | int, null | `dbo.tHdSection` |  |
| `RequestForHwCatalogPath` | nvarchar(max), null |  |  |
| `RequestForHwCategories` | nvarchar(max), null |  |  |
| `RequestForHwCurrency` | nvarchar(256), null |  |  |
| `ServiceCi` | int, null |  |  |
| `cause` | nvarchar(256), null |  |  |
| `ServiceClass` | int, null |  |  |
| `ServiceKind` | nvarchar(256), null |  |  |
| `ServiceNodeId` | int, null |  |  |
| `ExtAppSettings` | nvarchar(max), null |  |  |
| `SectionSimilarityVector` | nvarchar(max), null |  |  |
| `CreateSolutionProposal` | bit, null |  |  |
| `MajorIncidentScore` | float, null |  |  |
| `LastVectorTicketId` | int, null |  |  |
| `CommunicationVector` | nvarchar(max), null |  |  |
| `FieldsVector` | nvarchar(max), null |  |  |
| `ObjectsVector` | nvarchar(max), null |  |  |
| `ExpectedCost` | int, null |  |  |
| `ExpectedRiskLevel` | int, null |  |  |
| `ServiceOwner` | int, null |  |  |

## dbo.tHdSectionPerson

Setting of notifications from the services to individual persons.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdSectionPersonId` | int, not null |  |  |
| `liHdSectionPersonHdSectionId` | int, null | `dbo.tHdSection` |  |
| `liHdSectionPersonPersonId` | int, null | `dbo.tPerson` |  |
| `bHdSectionPersonNotifySolverOnHdTicketPassed` | bit, null |  |  |
| `bHdSectionPersonNotifySolverOnHdTicketCreated` | bit, null |  |  |
| `bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged` | bit, null |  |  |
| `bHdSectionPersonNotifySolverOnHdTicketOpen` | bit, null |  |  |
| `bHdSectionPersonNotifySolverOnNewMessageReceived` | bit, null |  |  |
| `bHdSectionPersonNotifyUserOnHdTicketCreated` | bit, null |  |  |
| `bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged` | bit, null |  |  |
| `bHdSectionPersonNotifyUserOnHdTicketResolved` | bit, null |  |  |
| `bHdSectionPersonNotifyUserOnHdTicketSolverOpen` | bit, null |  |  |
| `bNotifySolverOnHdTicketReturnedToOperators` | bit, null |  |  |

## dbo.tHdSectionRights

Permissions individuals and groups have in services (Main solver, Solver, ...).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdSectionRightsId` | int, not null |  |  |
| `liHdSectionRightsHdSectionId` | int, not null | `dbo.tHdSection` |  |
| `liHdSectionRightsRoleId` | int, null | `dbo.tRole` |  |
| `liHdSectionRightsPersonId` | int, null | `dbo.tPerson` |  |
| `MainSolver` | bit, not null |  |  |
| `Solver` | bit, not null |  |  |
| `Manager` | bit, not null |  |  |
| `Reader` | bit, not null |  |  |
| `ExceptionalSolver` | bit, not null |  |  |
| `TicketReporter` | bit, not null |  |  |
| `SolverGroup` | bit, not null |  |  |
| `RequesterRoleId` | int, not null | `dbo.tRole` | ID of the group of requesters associated with the permissions (mapping of requesters to the solver team). |

## dbo.tHdTicket

Tickets.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `sHdTicket` | nvarchar(1024), null |  | Ticket name |
| `mHdTicketNotice` | nvarchar(max), null |  | Notes to the ticket. |
| `liHdTicketUserPersonId` | int, not null | `dbo.tPerson` | Link to requester. |
| `dHdTicket` | datetime, null |  | Time at which the ticket was created. When the ticket was created by an email, it is the moment the message was sent. |
| `dHdTicketDeadline` | datetime, null |  | Deadline. |
| `sHdTicketGroup` | nvarchar(255), null |  | Group. |
| `liHdTicketSolverPersonId` | int, null | `dbo.tPerson` | ID of the ticket solver (see tPerson.iPersonId). If this is NULL, the ticket has no solver. |
| `dHdTicketReceived` | datetime, null |  | Time at which the ticket was received. When the ticket was created by an email, it is the moment the message was read from the mailbox. |
| `dHdTicketResolved` | datetime, null |  | Time to solve ticket by solver. |
| `sHdTicketDeviceCode` | nvarchar(255), null |  | Device number. |
| `Priority` | int, null | `dbo.tColumnValue` | Link to priority. |
| `sHdTicketUser` | nvarchar(255), null |  | Requester name. |
| `sHdTicketUserEmail` | nvarchar(255), null |  | Requester email. |
| `sHdTicketUserPhone` | nvarchar(255), null |  | Requester's phone. |
| `mHdTicketUserContact` | nvarchar(max), null |  | Requester contact details. |
| `liHdTicketHdSectionId` | int, not null | `dbo.tHdSection` | Link to service in which the ticket is found. |
| `sHdTicketUserMobile` | nvarchar(255), null |  | Requester cell phone |
| `sHdTicketUserOffice` | nvarchar(255), null |  | Requester office. |
| `sHdTicketUserDepartment` | nvarchar(255), null |  | Requester's department. |
| `sHdTicketUserWorkPosition` | nvarchar(255), null |  | Requester's job. |
| `sHdTicketUserCompany` | nvarchar(255), null |  | Requester's company. |
| `liHdTicketStartingActId` | int, null | `dbo.tAct` | Link to event that establishes the ticket. |
| `sHdTicketMessageTag` | nvarchar(255), null |  | Ticket number. Contains the prefix and suffix of the service in which the ticket is found as the root of the record ID. |
| `dHdTicketRemoved` | datetime, null |  | Time at which the ticket was deleted. |
| `liHdTicketSlaId` | int, not null | `dbo.tSla` | Link to SLA, used for this ticket. |
| `liHdTicketResolvedPersonId` | int, null | `dbo.tPerson` |  |
| `iHdTicketSolverOrder` | int, null |  |  |
| `sHdTicketWaitingForEmail` | nvarchar(255), null |  |  |
| `Impact` | int, not null | `dbo.tColumnValue` |  |
| `Urgency` | int, not null | `dbo.tColumnValue` |  |
| `UserEmail2` | nvarchar(255), null |  |  |
| `UserPhone2` | nvarchar(255), null |  |  |
| `RelatedAccountId` | int, null | `dbo.tAccount` | Organization for which the ticket is implemented. |
| `FeedbackLinkId` | uniqueidentifier, null |  | Contains a unique guid ticket identifier. |
| `FeedbackSolveSpeed` | int, null |  | The "Resolution speed" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score. |
| `FeedbackProfessionality` | int, null |  | The "Professionalism" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score. |
| `FeedbackExpertise` | int, null |  | The "Expertise" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score. |
| `FeedbackComment` | nvarchar(max), null |  | "Comments and notes" item on satisfaction survey. |
| `ClosedDate` | datetime, null |  | Ticket close date |
| `ClosedByPersonId` | int, null | `dbo.tPerson` | ID of the person who closed the ticket |
| `FirstReactionDeadline` | datetime, null |  |  |
| `LastActionDate` | datetime, null |  | Date of the last reaction |
| `WaitingActId` | int, null | `dbo.tAct` | If the ticket is waiting for requester, the value is tAct.iActId of the event that initiated waiting. Otherwise NULL. |
| `WaitedForUserHours` | float, null |  | Number of hours waited for the requester. The sum does not include an interval from the last event to the present; it is to be added after the vHdTicket view is called. |
| `WorkHours` | float, null |  | Number of hours worked in relation to the ticket. |
| `TravelHours` | float, null |  | Number of hours spent on the way in respect of the ticket. |
| `TravelKm` | float, null |  | Number of kms reported in relation to the ticket. |
| `NextActionDeadline` | datetime, null |  | The current target date of the ticket. |
| `iHdTicketId` | int, not null |  |  |
| `OriginalDeadline` | datetime, null |  | Original deadline for resolving tickets set according to SLA. |
| `ShiftedDeadline` | datetime, null |  | Ticket resolution deadline shifted by the SLA pause period (does not include the interval from the last event in the ticket log to the present). |
| `InternalTarget` | nvarchar(255), null |  | Internal target name. |
| `InternalTargetDeadline` | datetime, null |  | Internal target date. |
| `TicketStateId` | int, not null | `dbo.TicketState` | Ticket status ID. |
| `FeedbackGeneral` | int, null | `dbo.tColumnValue` | The "Overall satisfaction" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score. |
| `SumOfAllOpeningHoursIntervalsToCurrentTarget` | float, null |  | Time elapsed from the beginning of the next interval of the operating time up to the due date of the current target (in the operating hours). |
| `FullTextSearch` | nvarchar(max), null |  | Column is used for full-text search and contains ticket tag, ticket name, requester name, solver name and service name. |
| `ShiftedFirstReactionDeadline` | datetime, null |  | First response deadline shifted by the SLA pause period (does not include the interval from the last event in the ticket log to the present). |
| `SlaPausedHours` | float, null |  | Total SLA pause time within a specific requirement in hours (does not include an interval from the last event in the ticket log until present). |
| `CurrentSlaPauseStart` | datetime, null |  | Date and time of the running SLA pause. |
| `TopTicketAlertId` | int, null | `dbo.TicketAlert` | Most important alert of the ticket (TicketAlert.id). |
| `ApprovalId` | int, null | `dbo.tHdTicketApproval` | ID of the record on the ongoing approval process (tHdTicketApproval.iHdTicketApprovalId). |
| `RequestedForPersonId` | int, not null | `dbo.tPerson` | The person for whom the ticket is created (tPerson.iPersonId). |
| `FirstReactionActId` | int, null | `dbo.tAct` | The event ID that represents the first response (tAct.iActId). |
| `FirstReactionTriggeredByActId` | int, null | `dbo.tAct` | The event ID that caused the first response. This is usually the same event as FirstReactionActId. In the case that FirstReactionActId is an automatically created event, such as a requester's notification of a change in the ticket status, this column indicates the event that triggered the submission of the notification, such as a change in the ticket status, a new ticket to the solver, etc. (tAct.iActId). |
| `SolverGroupRoleId` | int, null | `dbo.tRole` |  |
| `Keywords` | nvarchar(max), null |  | List of keywords extracted from ticket comunication separated by comma. |
| `AIDescription` | nvarchar(max), null |  | Description of the problem and solution of the current ticket created by AI. |
| `IsSample` | bit, not null |  | Is data sample. |

## dbo.tHdTicketAltMessageTag

Alternative ticket tags. Upon merging tickets, the final ticket uses tags from original tickets as alternative tags.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdTicketAltMessageTagId` | int, not null |  |  |
| `liHdTicketAltMessageTagHdTicketId` | int, not null | `dbo.tHdTicket` |  |
| `sHdTicketAltMessageTag` | nvarchar(255), null |  |  |

## dbo.tHdTicketApproval

Ticket approval process instance - main record.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdTicketApprovalId` | int, not null |  |  |
| `liHdTicketApprovalHdTicketId` | int, not null | `dbo.tHdTicket` |  |
| `dHdTicketApprovalStarted` | datetime, null |  |  |
| `liHdTicketApprovalStartedPersonId` | int, null | `dbo.tPerson` |  |
| `liHdTicketApprovalApprovalSchemaId` | int, null | `dbo.tApprovalSchema` |  |
| `CanceledPersonId` | int, null | `dbo.tPerson` | ID of the person who canceled approving. |
| `TicketStateId` | int, null | `dbo.TicketState` |  |

## dbo.tHdTicketApprovalItem

Ticket approval step.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdTicketApprovalItemId` | int, not null |  | Record ID |
| `dHdTicketApprovalItem` | datetime, null |  | Date and time of step completion |
| `liHdTicketApprovalItemPersonId` | int, null | `dbo.tPerson` | Approver (see tPerson.iPersonId) |
| `liHdTicketApprovalItemHdTicketApprovalItemResultId` | int, not null | `dbo.tHdTicketApprovalItemResult` | Status and/or results of approval (see tHdTicketApprovalItemResult) |
| `mHdTicketApprovalItemNotes` | nvarchar(max), null |  | Approverâs comment |
| `liHdTicketApprovalItemApprovalSchemaItemId` | int, null | `dbo.tApprovalSchemaItem` | Step of the approval scheme governing this approval step, see tHdTicketApprovalSchemaItem. |
| `liHdTicketApprovalItemHdTicketApprovalId` | int, not null | `dbo.tHdTicketApproval` | Record of ongoing approval in a ticket, see tHdTicketApproval. |
| `dExpiration` | datetime, null |  | Date and time after which approval should expire. |
| `ApprovalItemNotesHtml` | nvarchar(max), null |  | Approverâs comment in HTML |
| `Started` | datetime, null |  | Date and time of commencement of step approval. |
| `MessageForApproverActId` | int, not null | `dbo.tAct` | Report for approvers (see tAct.iActId) |
| `DeputyApproverPersonId` | int, null | `dbo.tPerson` | Identifier of the substitute who actually made the approval in the approverâs absence (see tPerson.iPersonId) |

## dbo.tHdTicketApprovalItemResult

List of approval step statuses.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iHdTicketApprovalItemResultId` | int, not null |  |  |
| `sHdTicketApprovalItemResult` | nvarchar(255), null |  |  |

## dbo.tHdTicketCust

Ticket custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liHdTicketId` | int, not null | `dbo.tHdTicket` | Link to ticket to which the values belong. |
| `ProblemCandidate` | bit, null |  |  |
| `IncidentClosureCode` | int, null |  |  |
| `AccessToInternalSyst` | bit, null |  |  |
| `vendorSecCompliance` | int, null |  |  |
| `vendorRiskAnalysis` | int, null |  |  |
| `vendorNDA` | int, null |  |  |
| `changeDocUrl` | nvarchar(256), null |  |  |
| `NadrizenyPracovnik` | int, null |  |  |
| `IssuesFound` | nvarchar(256), null |  |  |
| `severityOfVulnerability` | int, null |  |  |
| `Changeend` | datetime, null |  |  |
| `Changestart` | datetime, null |  |  |
| `RiskLevel` | int, null |  |  |
| `changeEndActual` | datetime, null |  |  |
| `changeStartActual` | datetime, null |  |  |
| `RiskDescription` | nvarchar(256), null |  |  |
| `successfulChange` | bit, null |  |  |
| `overranChangeWindow` | bit, null |  |  |
| `symptoms` | nvarchar(max), null |  |  |
| `diagnosis` | nvarchar(max), null |  |  |
| `rootCause` | nvarchar(max), null |  |  |
| `workaround` | nvarchar(max), null |  |  |
| `methodOfResolution` | nvarchar(max), null |  |  |
| `ProblemClosureCode` | int, null |  |  |
| `FiveWhys` | nvarchar(256), null |  |  |
| `UserName` | nvarchar(256), null |  |  |
| `UserSurname` | nvarchar(256), null |  |  |
| `TripDeparture` | datetime, null |  |  |
| `TripReturn` | datetime, null |  |  |
| `TripPurpose` | nvarchar(256), null |  |  |
| `TripTransport` | nvarchar(256), null |  |  |
| `Department` | int, null |  |  |
| `PositionName` | int, null |  |  |
| `Manager` | int, null |  |  |
| `Locality` | int, null |  |  |
| `FirstDay` | date, null |  |  |
| `ContractAgreementOn` | int, null |  |  |
| `NumberOfMonths` | int, null |  |  |
| `Laptop` | bit, null |  |  |
| `StandardDesktopKit_i` | bit, null |  |  |
| `MobilePhone` | bit, null |  |  |
| `Car` | bit, null |  |  |
| `OtherTraining` | nvarchar(256), null |  |  |
| `DescribePotentialSpe` | nvarchar(max), null |  |  |
| `ContractType` | int, null |  |  |
| `MobilePackage` | int, null |  |  |
| `LostOrStolen` | int, null |  |  |
| `Url` | nvarchar(256), null |  |  |

## dbo.TicketAlert

Cache for storing alerts.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `TicketAlertTypeId` | int, not null | `dbo.TicketAlertType` | Alert type: 0 = ticket not being resolved, 1 = first reaction due date, 2 = resolution due date, 3 = internal target date. |
| `TicketId` | int, not null | `dbo.tHdTicket` | Ticket (tHdTicket.Id). |
| `SeverityId` | int, not null | `dbo.TicketAlertSeverity` | Severity (TicketAlertSeverity.id). |
| `Raised` | datetime, not null |  | Alert date and time |
| `Param1` | float, null |  | A parameter which is inserted into the alert text. |

## dbo.TicketAlertSeverity

Alert severity.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `TicketAlertSeverity` | nvarchar(255), not null |  | Localised name of alert severity. |

## dbo.TicketAlertSeverityLoc

Language localisation cache for alert severity, see TicketAlertSeverity.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketAlertSeverityId` | int, not null | `dbo.TicketAlertSeverity` | Alert ID (TicketAlertSeverity.id). |
| `LocaleId` | int, not null |  | Language ID. |
| `TicketAlertSeverity` | nvarchar(255), null |  | Localised name of alert severity. |

## dbo.TicketAlertType

SLA alert type

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `Name` | nvarchar(max), not null |  | Alert name |
| `MsgTemplateNoParams` | nvarchar(max), null |  | Alert text without parameter |
| `MsgTemplateParam1` | nvarchar(max), null |  | Alert text with parameter |

## dbo.TicketAlertTypeLoc

Language localization cache of SLA alert type, see TicketAlertType

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketAlertTypeId` | int, not null | `dbo.TicketAlertType` |  |
| `LocaleId` | int, not null |  | Language ID |
| `MsgTemplateNoParams` | nvarchar(max), null |  | Localized alert text without parameter |
| `MsgTemplateParam1` | nvarchar(max), null |  | Localized alert text with parameter |

## dbo.TicketChange

Ticket log record for changes to the ticket field value.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketId` | int, not null | `dbo.tHdTicket` | Ticket ID (tHdTicket.iHdTicketId) |
| `PersonId` | int, not null | `dbo.tPerson` | Author of the change (tPerson.iPersonId) |
| `ChangeDate` | datetime, not null |  | Change date and time (UTC) |
| `ColumnId` | int, not null | `dbo.tColumn` | Changed field (tColumn.iColumnId) |
| `ValueOldNvarchar` | nvarchar(max), null |  | Old string value |
| `ValueNewNvarchar` | nvarchar(max), null |  | New string value |
| `ValueOldBit` | bit, null |  | Old bit value |
| `ValueNewBit` | bit, null |  | New bit value |
| `ValueOldDate` | date, null |  | Old date value |
| `ValueNewDate` | date, null |  | New date value |
| `ValueOldDatetime` | datetime, null |  | Old datetime value |
| `ValueNewDatetime` | datetime, null |  | New datetime value |
| `ValueOldFloat` | float, null |  | Old float value |
| `ValueNewFloat` | float, null |  | New float value |
| `ValueOldInt` | int, null |  | Old int value (could be foreign key to various tables) |
| `ValueNewInt` | int, null |  | New int value (could be foreign key to various tables) |

## dbo.TicketEmbedding

Embeddings for tickets.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null | `dbo.tHdTicket` | Ticket ID. |
| `EmbeddingModelId` | int, not null | `dbo.EmbeddingModel` | Used embedding model for vectors. |
| `PresentFlag` | int, not null |  | Present vector bit flag 0 â no valid vector present 1 â Communication 2 â Fields 4 - Objects 8 - Description |
| `CommunicationTime` | datetime, null |  | Time of CommunicationVector change. |
| `DescriptionTime` | datetime, null |  | Time of DescriptionVector change. |
| `FieldsTime` | datetime, null |  | Time of FieldsVector change. |
| `ObjectsTime` | datetime, null |  | Time of ObjectsVector change. |
| `CommunicationVector` | vector, null |  | Vector used to compare the similarity of ticket communication. |
| `DescriptionVector` | vector, null |  | Vector used to compare the similarity of ticket description and solution. |
| `FieldsVector` | vector, null |  | Vector used to compare the similarity of ticket fields. |
| `ObjectsVector` | vector, null |  | Vector used to compare ticket objects. |

## dbo.TicketNode

Objects associated to the ticket over the ticket "Objects" item.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketId` | int, not null | `dbo.tHdTicket` | Ticket ID (tHdTicket.iHdTicketId) |
| `NodeId` | int, not null | `dbo.tblNode` | Object ID (tblNode.intNodeId) |
| `Created` | datetime, null |  | Link creation date and time (UTC) |
| `Removed` | datetime, null |  | Link removal date and time (UTC) |
| `CreatedByPersonId` | int, null | `dbo.tPerson` | User ID of a person who created the link (tPerson.iPersonId). |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | User ID of a person who deleted the link (tPerson.iPersonId). |

## dbo.TicketRelation

Links Between Tickets.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `BeginHdTicketId` | int, not null | `dbo.tHdTicket` | The ticket ID at the beginning of the link, see tHdTicket.iHdTicket. |
| `EndHdTicketId` | int, not null | `dbo.tHdTicket` | The ticket ID at the end of the link, see tHdTicket.iHdTicket. |
| `TicketRelationTypeId` | int, not null | `dbo.TicketRelationType` | Link kind ID, see TicketRelationType.id. |
| `Created` | datetime, null |  | Link creation date and time |
| `Removed` | datetime, null |  | Link removal date and time |
| `CreatedByPersonId` | int, null | `dbo.tPerson` | Link author ID, see tPerson.iPersonId. |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | User ID of a person who deleted the link - see tPerson.iPersonId. |

## dbo.TicketRelationType

Types of links between tickets.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `BeginName` | nvarchar(30), not null |  | The name of the link from the ticket view at the beginning of the link |
| `EndName` | nvarchar(30), not null |  | The name of the link from the ticket view at the end of the link |
| `Directional` | bit, not null |  | Permitted values are 0 and 1. If set to 1, the link is directional, i.e. links "Link A to B" and "Link B to B" are two different links. |
| `Cyclic` | bit, not null |  | Permitted values are 0 and 1. If set to 1, the link may not create a cycle. Example of a cycle: A is linked to B, B is linked to C, and C is linked to A. |
| `OneToMany` | bit, not null |  | Permitted values are 0 and 1. If set to 1, the target ticket may not contain more than one link. |
| `MenuOrder` | int, not null |  | The order of link types in menus |
| `TicketRelationTypeBehaviorId` | int, not null | `dbo.TicketRelationTypeBehavior` | System link type. When defining a custom link type, always use the value 1. |
| `CustomField1` | int, null |  | Custom field |

## dbo.TicketRelationTypeBehavior

System types of links between tickets.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketRelationTypeBehavior` | nvarchar(50), null |  | Link name |

## dbo.TicketRequestParticipant

Ticket participant for the ticket

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketId` | int, not null | `dbo.tHdTicket` | Ticket ID (tHdTicket.iHdTicketId). |
| `PersonId` | int, not null | `dbo.tPerson` | User ID of the ticket participant (tPerson.iPersonId). |

## dbo.TicketSequence

A table containing the next ticket number.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `NextTicketId` | int, not null |  | Next ticket number |

## dbo.TicketState

Ticket statuses. Statuses are defined in the process (see dbo.TicketType).

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketTypeId` | int, null | `dbo.TicketType` |  |
| `TicketState` | nvarchar(64), not null |  | State text |
| `Description` | nvarchar(max), null |  |  |
| `SolverInstructions` | nvarchar(max), null |  |  |
| `Order` | int, not null |  |  |
| `TicketStateBehaviorId` | int, not null | `dbo.TicketStateBehavior` |  |
| `CustomField1` | int, null |  |  |
| `TransitToAllStates` | bit, not null |  |  |
| `ApprovalAutoStart` | bit, not null |  |  |
| `IsApprovalState` | bit, not null |  |  |
| `OnRejectedStateId` | int, null | `dbo.TicketState` |  |
| `OnApprovalStateId` | int, null | `dbo.TicketState` |  |
| `OnCanceledStateId` | int, null | `dbo.TicketState` |  |
| `OnExpiredStateId` | int, null | `dbo.TicketState` |  |
| `ApprovalSchemaId` | int, null | `dbo.tApprovalSchema` |  |
| `ApprovalPersonId` | int, null | `dbo.tPerson` |  |
| `ApprovalExpirationHours` | float, null |  |  |
| `CloseAfterSolution` | bit, not null |  | Automatic closing of ticket after changing to status - value = 1 is only possible in the Solved status. |
| `CustomMessageForApproverTemplate` | nvarchar(max), null |  | Custom message template for approvers. If the record has a value of NULL, then the default template is used (available in tString). |
| `Removed` | datetime, null |  | Date of status deletion. If the value is NULL here, the status was not deleted. |
| `SendNotificationForRequester` | bit, not null |  | Send a notification to the requester when transitioning to status. |
| `CustomNotificationForRequesterTemplate` | nvarchar(max), null |  | Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString). |
| `PauseSla` | bit, not null |  | SLA is paused at this status |
| `DisplayCommandMoveToService` | bit, not null |  | Display the command "Transfer To Another Service" at the top of the command panel: 0 - off, 1 - on |
| `DisplayCommandAssignToSolver` | bit, not null |  | In the tickets in this status, display the Assign to solver command first in the Command bar. |
| `DisplayCommandNewObject` | bit, not null |  | Display the command "New object" at the top of the command panel: 0 - off, 1 - on |
| `DisplayCommandMoveObjects` | bit, not null |  | Display the command "Move objects" at the top of the command panel: 0 - off, 1 - on |
| `SolverGroupRoleId` | int, null | `dbo.tRole` | Assign ticket to a solver group during transition to this status. |

## dbo.TicketStateBehavior

System ticket statuses, see dbo.TicketState.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `TicketStateBehavior` | nvarchar(50), not null |  |  |

## dbo.TicketStateCust

Ticket state custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketStateId` | int, not null | `dbo.TicketState` | Link to ticket state to which the values belong. |

## dbo.TicketStateLoc

Cache of the localizations of ticket states.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketStateId` | int, not null |  | Ticket status ID. |
| `LocaleId` | int, not null |  | Language ID. |
| `TicketState` | nvarchar(64), null |  | Localized ticket status name. |
| `Description` | nvarchar(max), null |  | Localized ticket status description. |
| `SolverInstructions` | nvarchar(max), null |  | Localized instructions for solver. |
| `CustomMessageForApproverTemplate` | nvarchar(max), null |  | Localized customer message template for approvers. If the record has a value of NULL, then the default template is used (available in tString). |
| `CustomNotificationForRequesterTemplate` | nvarchar(max), null |  | Localized custom template of notifications to requester about the change of ticket status. If the record has a value of NULL, then the default template is used (saved in tString). |

## dbo.TicketStateRelation

Allowed transitions among ticket statuses, see dbo.TicketState.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `BeginTicketStateId` | int, not null | `dbo.TicketState` |  |
| `EndTicketStateId` | int, not null | `dbo.TicketState` |  |

## dbo.TicketStatusTransitionFormColumn

Column order on a Ticket status transition form

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Entity ID |
| `StatusId` | int, not null | `dbo.TicketState` | Id of the status (TicketState.id) |
| `ColumnId` | int, not null | `dbo.tColumn` | Link to column (tColumn.iColumnId) |
| `Order` | int, not null |  | Row on which the item is displayed |
| `Required` | bit, not null |  | Marking the item obligation. |
| `Column` | int, null |  | Column on which the item is displayed (0 left, 1 right) |

## dbo.TicketStatusTransitionFormSection

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `Name` | nvarchar(255), not null |  |  |
| `Order` | int, not null |  |  |
| `StatusId` | int, not null | `dbo.TicketState` |  |
| `Expand` | bit, not null |  |  |

## dbo.TicketStatusTransitionFormTextBlock

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  |  |
| `TextHtml` | nvarchar(max), null |  |  |
| `Order` | int, not null |  |  |
| `StatusId` | int, not null | `dbo.TicketState` |  |
| `Column` | int, null |  |  |
| `ColSpan` | int, null |  |  |

## dbo.TicketTag

User tag of the ticket

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `PersonId` | int, not null | `dbo.tPerson` | Person (tPerson.iPersonId) |
| `TicketId` | int, not null | `dbo.tHdTicket` | Ticket (tHdTicket.iHdTicketId) |
| `TicketTagTypeId` | int, not null | `dbo.TicketTagType` | Tag type (TicketTagType.id) |

## dbo.TicketTagType

Ticket tag type

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(70), not null |  | Tag name |
| `Color` | nvarchar(10), not null |  | Tag color |

## dbo.TicketTagTypeLoc

Cache of tag types localizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketTagTypeId` | int, not null | `dbo.TicketTagType` | Id of tag type (see TicketTagType.id) |
| `LocaleId` | int, not null |  | Language ID |
| `Name` | nvarchar(70), not null |  | Localized tag name |

## dbo.TicketTask

Tasks for tickets

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketId` | int, not null | `dbo.tHdTicket` | Ticket ID (tHdTicket.iHdTicketId) |
| `Title` | nvarchar(1024), not null |  | Task title |
| `DisplayOrder` | int, null |  | Display order of the task |
| `SolverPersonId` | int, null | `dbo.tPerson` | ID of the person assigned to solve the task (tPerson.iPersonId) |
| `CreatedDate` | datetime, not null |  | Date and time when the task was created (UTC) |
| `CreatedByPersonId` | int, not null | `dbo.tPerson` | ID of the person who created the task (tPerson.iPersonId) |
| `DueDate` | datetime, null |  | The date and time of the deadline (UTC) |
| `CompletedDate` | datetime, null |  | Date and time when the task was completed (UTC) |
| `CompletedByPersonId` | int, null | `dbo.tPerson` | ID of the person who completed the task (tPerson.iPersonId) |
| `RemovedDate` | datetime, null |  | Date and time when the task was removed (UTC) |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | ID of the person who removed the task (tPerson.iPersonId) |
| `IsCurrent` | bit, not null |  | Indicates if the task has the closest deadline |

## dbo.TicketTemplate

List of ticket templates

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), null |  | Template name (must be unique). |
| `Description` | nvarchar(max), null |  | Description of template. |
| `HdSectionId` | int, not null | `dbo.tHdSection` | ID of service in which the template is created. |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | Link to user that deleted the template. The template is not deleted for NULL. |
| `RemovedDate` | datetime, null |  | Date on which the template was deleted. The template is not deleted for NULL. |
| `LastTicketId` | int, null | `dbo.tHdTicket` | ID of the last ticket automatically created based on this template (FK). |
| `LastTicketCreationDate` | datetime, null |  | Creation date of the last ticket automatically created based on this template. |
| `NextDate` | datetime, null |  | Next deadline for the planned ticket - only date (you cannot work with time). |
| `Planning` | bit, not null |  | Planning (0 - off, 1 - on). |
| `UserId` | int, null | `dbo.tPerson` | Requester ID (FK). |
| `StartDate` | datetime, null |  | Beginning of repetition - only date (time is ignored). |
| `EndAfter` | int, null |  | Number of occurrences upon which planning is finished. |
| `TicketCreatedCount` | int, not null |  | Number of created tickets based on this template in the current planning. |
| `EndDate` | datetime, null |  | End of repetition - only the date of the last available creation (you cannot work with time). |
| `Daily` | bit, not null |  | Daily (0 - off, 1 - on). |
| `DailyEveryXDays` | int, null |  | Repetition period in days. |
| `DailyEveryWeekday` | bit, not null |  | On weekdays (0 - off, 1 - on). |
| `DailyAfterClosing` | int, null |  | Upon closing the previous. |
| `Weekly` | bit, not null |  | Weekly (0 - off, 1 - on). |
| `WeeklyEveryXDays` | int, null |  | Repetition period in weeks. |
| `WeeklyMonday` | bit, not null |  | On Mondays. |
| `WeeklyTuesday` | bit, not null |  | On Tuesdays. |
| `WeeklyWednesday` | bit, not null |  | On Wednesdays. |
| `WeeklyThursday` | bit, not null |  | On Thursdays. |
| `WeeklyFriday` | bit, not null |  | On Fridays. |
| `WeeklySaturday` | bit, not null |  | On Saturdays. |
| `WeeklySunday` | bit, not null |  | On Sundays. |
| `WeeklyAfterClosing` | int, null |  | Upon closing the previous. |
| `Monthly` | bit, not null |  | Monthly (0 - off, 1 - on). |
| `MonthlyDayInMonth` | int, null |  | Which day in the month. |
| `MonthlyDayInMonthEveryXMonths` | int, null |  | Every X month. |
| `MonthlyEveryXDayInWeek` | int, null |  | Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last). |
| `MonthlyDayInWeek` | int, null |  | Which weekday (1 - Monday, â¦, 8 - day, 9 - weekday). |
| `MonthlyDayInWeekEveryXMonths` | int, null |  | Every X month. |
| `MonthlyAfterClosing` | int, null |  | Upon closing the previous. |
| `Yearly` | bit, not null |  | Yearly (0 - off, 1 - on). |
| `YearlyDayInMonth` | int, null |  | Which day in the month. |
| `YearlyDayInMonthOnMonth` | int, null |  | Which month (1 - January, â¦). |
| `YearlyEveryXDayInWeek` | int, null |  | Which weekday in the month (1 - first, 2 - second, 3 - third, 4 - fourth, 5 - last). |
| `YearlyDayInWeek` | int, null |  | Which weekday (1 - Monday, â¦). |
| `YearlyDayInWeekOnMonth` | int, null |  | Which month (1 - January, â¦). |
| `YearlyAfterClosing` | int, null |  | Upon closing the previous. |
| `SolverId` | int, null | `dbo.tPerson` | Solver ID (FK). |
| `SolverGroupId` | int, null | `dbo.tRole` |  |
| `IsSample` | bit, not null |  |  |

## dbo.TicketTemplateColumnValue

column values on ticket template.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketTemplateId` | int, not null | `dbo.TicketTemplate` | Id of template to which the column belongs. |
| `ColumnId` | int, not null | `dbo.tColumn` | Column Id. |
| `DefaultValue` | nvarchar(max), not null |  | Value stored in the column. |
| `DefaultValueHtml` | nvarchar(max), null |  | Value saved in a column in HTML. |

## dbo.TicketTemplateNode

Objects linked to the ticket templates.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketTemplateId` | int, not null | `dbo.TicketTemplate` | ID of the ticket template (TicketTemplate.Id) |
| `NodeId` | int, not null | `dbo.tblNode` | Object ID (tblNode.intNodeId) |

## dbo.TicketType

Processes. Among others, the process defines possible ticket statuses, workflow, ticket custom fields, etc.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `TicketType` | nvarchar(255), not null |  | Process name |
| `Description` | nvarchar(max), null |  | Description of the process |
| `TicketTypeBehaviorId` | int, not null | `dbo.TicketTypeBehavior` | Process type ID (TicketTypeBehavior.id) |
| `CustomField1` | int, null |  |  |
| `BackResolveDeadlineHours` | float, null |  |  |
| `TicketTypeNodeHealthImpactId` | int, not null | `dbo.TicketTypeNodeHealthImpact` | ID of the effect of tickets with this process on the health of objects in the given tickets (TicketTypeNodeHealthImpact.id). 1=no effect, 2=incident, 3=change. |

## dbo.TicketTypeBehavior

System processes.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `TicketTypeBehavior` | nvarchar(255), not null |  |  |

## dbo.TicketTypeColumn

Ticket items used by the process.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `TicketTypeId` | int, not null | `dbo.TicketType` |  |
| `ColumnId` | int, not null | `dbo.tColumn` |  |

## dbo.TicketTypeLoc

Cache of process localizations.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TicketTypeId` | int, not null |  | Process ID. |
| `LocaleId` | int, not null |  | Language ID. |
| `TicketType` | nvarchar(255), null |  | Localized process name. |
| `TicketTypeDesc` | nvarchar(max), null |  | Localized process description. |

## dbo.TicketTypeNodeHealthImpact

For the effect on object health requirements, see TicketType.TicketTypeNodeHealthImpactId.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(70), not null |  | Record name |

## dbo.tIdSeqClass

Numeric sequences - definitions for types of objects.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liIdSeqId` | int, not null | `dbo.tblIdSeq` |  |
| `liClassId` | int, null | `dbo.tblClass` |  |

## dbo.TimeZone

Time zone list.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `uid` | nvarchar(128), not null |  | Unique identifier (matches the key in the registry). |
| `DisplayName` | nvarchar(128), not null |  | Localized name. |

## dbo.TimeZoneBias

Time zone shifts compared to UTC for each year

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `TimeZoneId` | int, not null | `dbo.TimeZone` | Link to time zone. |
| `FromDate` | datetime, null |  | From date. |
| `ToDate` | datetime, null |  | Until. |
| `Bias` | int, not null |  | Shift compared to UTC in minutes. |

## dbo.tLocale

Language environments.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iLocaleId` | int, not null |  | Locale ID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx. |
| `sLocale` | nvarchar(255), not null |  | Language name in Czech. |
| `bLocaleEnabled` | bit, not null |  | If set to 1, the language is used and is displayed in menus. |
| `sLangAbbr` | nvarchar(10), null |  | Two letter ISO language name. |
| `CultureCode` | nvarchar(16), not null |  | Culture code of the language. |

## dbo.tLocalization

Language localization for selected database values. The following items are supported: tHdSection.sHdSectionShort, tHdSection.mHdSectionDesc.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iLocalizationId` | int, not null |  | Record ID. |
| `sTable` | nvarchar(128), null |  | Name of table. |
| `sAttribute` | nvarchar(128), null |  | Column name. |
| `iRecordId` | int, not null |  | ID of record in target table designated for localization. |
| `iLocaleId` | int, not null |  | LCID of the language for which the localization is being executed. |
| `mLocalization` | nvarchar(max), null |  | Localized text. |
| `NeedsUpdate` | bit, not null |  | If there is 1, this translation needs to be updated because the original text has been modified since last translation. |

## dbo.tNodeProduct

Software profiles - exceptions for the computer.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liNodeId` | int, null | `dbo.tblNode` |  |
| `liProductId` | int, null | `dbo.tblProduct` |  |
| `liSwPresenceId` | int, not null | `dbo.tSwPresence` |  |

## dbo.Token

For internal use

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `PersonId` | int, not null | `dbo.tPerson` |  |
| `Scope` | nvarchar(2048), not null |  |  |
| `AccessToken` | nvarchar(max), not null |  |  |
| `Expiration` | datetime, not null |  |  |

## dbo.tOpeningHours

Service operating hours.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iOpeningHoursId` | int, not null |  |  |
| `sOpeningHours` | nvarchar(255), null |  |  |
| `mDescription` | nvarchar(max), null |  |  |
| `mNotes` | nvarchar(max), null |  |  |
| `TimeZoneId` | int, null | `dbo.TimeZone` |  |
| `ActualOpeningHoursEnd` | datetime, null |  | End of the current operating hours interval. |
| `NextOpeningHoursStart` | datetime, null |  | Beginning of the next operating hours interval. |
| `BankHolidayRegionId` | int, null | `dbo.tBankHolidayRegion` | Public holiday region. A foreign key on the tBankHolidayRegion table. |

## dbo.tOpeningHoursCache

Auxiliary records for optimizing time calculations according to service operating hours.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liOpeningHoursId` | int, not null |  |  |
| `dFrom` | datetime, not null |  |  |
| `dTo` | datetime, not null |  |  |
| `nTotalDays` | float, not null |  |  |

## dbo.tOpeningHoursException

Exceptions in service operating hours.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iOpeningHoursExceptionId` | int, not null |  |  |
| `liOpeningHoursId` | int, not null | `dbo.tOpeningHours` |  |
| `dFrom` | datetime, not null |  |  |
| `dTo` | datetime, not null |  |  |
| `bOpen` | bit, not null |  |  |
| `mNotes` | nvarchar(max), null |  |  |

## dbo.tPerson

Persons in the ALVAO system.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iPersonId` | int, not null |  | Record ID |
| `sPerson` | nvarchar(255), null |  | displayed username |
| `sPersonLogin` | nvarchar(255), null |  | User name |
| `sPersonAdGuid` | nvarchar(255), null |  |  |
| `sPersonEmail` | nvarchar(255), null |  | Email |
| `sPersonPhone` | nvarchar(255), null |  | phone |
| `sPersonMobile` | nvarchar(255), null |  | mobile phone |
| `sPersonOffice` | nvarchar(255), null |  | office |
| `sPersonDepartment` | nvarchar(255), null |  | department |
| `dPersonCreated` | datetime, null |  | date on which the user was created |
| `bPersonSystem` | bit, not null |  | system user |
| `sPersonWorkPosition` | nvarchar(255), null |  | job |
| `bHidden` | bit, not null |  | Hide in menus |
| `sPersonPswd` | nvarchar(255), null |  |  |
| `bPersonShared` | bit, not null |  | Shared account |
| `bPersonAccountDisabled` | bit, not null |  | Account is disabled |
| `mPersonContact` | nvarchar(max), null |  | Other contacts |
| `sPersonUrgentEmail` | nvarchar(255), null |  | Email for urgent messages |
| `bPersonGuest` | bit, not null |  |  |
| `dPersonRemoved` | datetime, null |  | date on which the user was removed |
| `mPersonNotes` | nvarchar(max), null |  |  |
| `sPersonCountry` | nvarchar(255), null |  |  |
| `sPersonCountryAbbr` | nvarchar(2), null |  |  |
| `iPersonCountryCode` | int, null |  |  |
| `sPersonPreferredLanguage` | nvarchar(2), null |  |  |
| `sPersonCity` | nvarchar(255), null |  |  |
| `oPersonSID` | image, null |  |  |
| `sPersonAdPath` | nvarchar(1024), null |  |  |
| `dPersonAdCreated` | datetime, null |  |  |
| `sPersonSID` | nvarchar(255), null |  |  |
| `liPersonManagerPersonId` | int, null | `dbo.tPerson` |  |
| `sPersonPersonalNumber` | nvarchar(255), null |  |  |
| `liPersonDelegatePersonId` | int, null | `dbo.tPerson` |  |
| `OutOfOfficeSince` | datetime, null |  | Starting date and time of absence. |
| `iPersonLocaleId` | int, null |  | Language number. This is the Microsoft LocaleID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx. The list of similar Locale ID can be found in the tLocale table |
| `sPersonAdName` | nvarchar(255), null |  |  |
| `liAccountId` | int, null | `dbo.tAccount` |  |
| `sFirstName` | nvarchar(255), null |  |  |
| `sLastName` | nvarchar(255), null |  |  |
| `sImportSystem` | nvarchar(255), null |  |  |
| `sImportRecordId` | nvarchar(255), null |  |  |
| `sAdDisplayName` | nvarchar(255), null |  |  |
| `TimeZone` | nvarchar(64), null |  |  |
| `Email2` | nvarchar(255), null |  |  |
| `Phone2` | nvarchar(255), null |  |  |
| `PersonPortrait` | varbinary, null |  |  |
| `PersonPortraitHash` | varchar, null |  |  |
| `PersonBehaviorId` | int, not null | `dbo.PersonBehavior` | For user type, see the PersonBehavior table. |
| `OutOfOfficeUntil` | datetime, null |  | Ending date and time of absence. |
| `IsOutOfOffice` | bit, not null |  | Identifier specifying whether the user is absent. Automatically calculated column. |
| `ImportAdLastFound` | datetime, null |  | Date and time when the user was last found during AD import. |
| `AzureAdObjectId` | nvarchar(40), null |  | User ID in the Azure Active Directory |
| `AzureAdTenantId` | int, null | `dbo.AzureAdTenant` | The tenantâs ID Azure Active Directory which the user belongs to. |
| `SamAccountName` | nvarchar(255), null |  | Username for systems older than Windows 2000 |
| `AadAppClientId` | nvarchar(255), null |  | Application (client) ID in AAD |
| `AadAppTenantId` | nvarchar(255), null |  | Directory (tenant) ID in AAD |
| `TeamsConversationId` | nvarchar(255), null |  |  |
| `App` | bit, not null |  | Application account |
| `RefreshToken` | nvarchar(3000), null |  | For internal use |
| `PersonPortraitETag` | nvarchar(1024), null |  | ETag value of portrait in Azure Active Directory |
| `IsSample` | bit, not null |  |  |

## dbo.tPersonCust

Persons in the ALVAO system - own items.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liPersonId` | int, null | `dbo.tPerson` |  |

## dbo.tProperty

ALVAO system settings.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `sProperty` | nvarchar(255), not null |  | Name of settings. |
| `sPropertyValue` | nvarchar(2048), null |  | Text value |
| `bPropertyValue` | bit, null |  | Truth value. |
| `iPropertyValue` | int, null |  | Integer value. |
| `nPropertyValue` | float, null |  | Real value |
| `dPropertyValue` | datetime, null |  | Time value |
| `id` | int, not null |  | Record ID |

## dbo.TransferConfirmAlert

Sent alerts to sign the handover protocols.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID. |
| `DocumentId` | int, not null | `dbo.tblDocument` | Document ID. |
| `RuleId` | int, not null | `dbo.TransferConfirmAlertRule` | Kind of alert. |
| `SentDate` | datetime, not null |  | Date of sending the alert. |

## dbo.TransferConfirmAlertConfig

Setting time of sending an alert and the period of the last alert repetition.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `SendTimeHour` | float, not null |  | Alert send time. |
| `RepeatTeamAlertAfterDays` | int, null |  | Repetition period of the last alert. |
| `RequireUserAuthentication` | bit, not null |  | Require user verification during signature. |

## dbo.TransferConfirmAlertRule

Settings of rules for sending alerts of not yet signed handover protocols.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Rule ID. |
| `Active` | bit, not null |  | A flag indicating whether or not the alert is active. |
| `AlertAfterDays` | int, null |  | Send an alert after a specified number of days. |
| `AlertRoleId` | int, null | `dbo.tRole` | The group to which the last alert is sent. |

## dbo.TransferConfirmType

Method of the assets takeover signing.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Item ID. |
| `Name` | nvarchar(32), not null |  | Name. |

## dbo.tRole

Groups of persons for the entire ALVAO.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iRoleId` | int, not null |  | Record ID. |
| `sRole` | nvarchar(255), null |  | Group name. |
| `sRoleAdGuid` | nvarchar(255), null |  | GUID in Active Directory |
| `bRoleEveryone` | bit, not null |  | Only one group "all", which has a value of 1, exists in ALVAO. |
| `dRoleCreated` | datetime, null |  | Time at which the group was created. |
| `sDesc` | nvarchar(max), null |  |  |
| `RoleBehaviorId` | int, not null | `dbo.RoleBehavior` |  |
| `AdDistributionGroup` | bit, not null |  | Group type in Active Directory. True means that it is a distribution group. Otherwise it is a security group. |
| `AdPath` | nvarchar(1024), null |  | Path to the group in Active Directory. |
| `DistributionEmail` | nvarchar(255), null |  | Distribution group email (Active Directory - mail attribute). |
| `LastImport` | datetime, null |  | Last import time from Active Directory. |
| `AdCreated` | datetime, null |  | Time of group creation in Active Directory (Active Directory - whenCreated attribute). |
| `AzureAdObjectId` | nvarchar(40), null |  | Group ID in the Azure Active Directory |
| `AzureAdTenantId` | int, null | `dbo.AzureAdTenant` | The tenantâs ID Azure Active Directory which the group belongs to. |
| `IsSample` | bit, not null |  |  |

## dbo.tRolePerson

Persons' membership in groups.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iRolePersonId` | int, not null |  | Record ID. |
| `liRolePersonRoleId` | int, not null | `dbo.tRole` | Link to group. |
| `liRolePersonPersonId` | int, not null | `dbo.tPerson` | Link to user within group. |
| `liRolePersonIncludedRoleId` | int, null | `dbo.tRole` | ID of the group from which the membership is promoted. NULL if the user has direct group membership. |

## dbo.tRoleRole

Groups' membership in groups.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iRoleRoleId` | int, not null |  | Record ID. |
| `liRoleRoleRoleId` | int, not null | `dbo.tRole` | Link to group owners. |
| `liRoleRoleMemberRoleId` | int, not null | `dbo.tRole` | Link to owned group. |

## dbo.tSla

SLA.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iSlaId` | int, not null |  |  |
| `sSla` | nvarchar(255), null |  |  |
| `mSlaDesc` | nvarchar(max), null |  |  |
| `nSlaDeadlineHours` | float, null |  |  |
| `dSlaRemoved` | datetime, null |  |  |
| `nSlaReactionHours` | float, null |  |  |
| `sSlaContract` | nvarchar(255), null |  |  |
| `mSlaNotes` | nvarchar(max), null |  |  |
| `nSlaQuality` | float, null |  |  |
| `liOpeningHoursId` | int, null | `dbo.tOpeningHours` |  |
| `Pause` | bit, not null |  |  |

## dbo.tSlaAlert

Ticket log records for notification sent for an unresolved issue or upcoming deadline.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `liHdTicketId` | int, not null | `dbo.tHdTicket` |  |
| `liSlaAlertRuleId` | int, null | `dbo.tSlaAlertRule` |  |
| `dHdTicketDeadline` | datetime, null |  |  |
| `dSent` | datetime, not null |  |  |
| `sTo` | nvarchar(1024), not null |  |  |
| `sError` | nvarchar(max), null |  |  |
| `InternalTargetDeadline` | datetime, null |  | Internal target date. |
| `FirstReactionDeadline` | datetime, null |  | The expiration deadline of first response. |

## dbo.tSlaAlertRule

Rule for sending notifications for unresolved issues or an upcoming deadline.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  |  |
| `liSlaId` | int, not null | `dbo.tSla` |  |
| `liToRoleStringId` | int, null | `dbo.tString` |  |
| `liInactiveRoleStringId` | int, null | `dbo.tString` |  |
| `fInactiveHours` | float, null |  |  |
| `fDeadlineExpireHours` | float, null |  |  |
| `fRepeatEveryHours` | float, null |  |  |
| `fSummarySendHour` | float, null |  |  |
| `dSummaryLastSent` | datetime, null |  |  |
| `InternalTargetExpireHours` | float, null |  | Number of hours until the expiry of the internal target date. |
| `FirstReactionExpireHours` | float, null |  | Number of hours until the expiry of the internal target date. |
| `TicketAlertSeverityId` | int, not null | `dbo.TicketAlertSeverity` | Alert severity (TicketAlertSeverity.id). |
| `SendByEmail` | bit, not null |  | If the value is 1, an alert is sent by email. |

## dbo.tSlaCust

SLA custom fields values.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liSlaId` | int, null | `dbo.tSla` |  |

## dbo.tSlaRights

Assigning SLA to individuals and groups.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iSlaRightsId` | int, not null |  |  |
| `liSlaRightsSlaId` | int, not null | `dbo.tSla` |  |
| `liSlaRightsRoleId` | int, null | `dbo.tRole` |  |
| `liSlaRightsPersonId` | int, null | `dbo.tPerson` |  |
| `bSlaRightsDefault` | bit, not null |  | 1 = SLA is set as the default; 0 = SLA is not default |
| `liHdSectionId` | int, not null | `dbo.tHdSection` |  |

## dbo.tSmtp

Configuration of the SMTP server for ALVAO.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `sSmtpAddress` | nvarchar(255), null |  | SMTP server address. |
| `nSmtpPort` | int, null |  | SMTP Server port. |
| `sSmtpLogin` | nvarchar(255), null |  | Username for SMTP server access. |
| `sSmtpPswd` | nvarchar(255), null |  | Password for SMTP server access. |
| `bSmtpSsl` | bit, not null |  | 1, should SSL be used for connecting to the SMTP server. |
| `ClientId` | nvarchar(255), null |  | OAuth - Application (client) ID |
| `TenantId` | nvarchar(255), null |  | OAuth - Directory (tenant) ID |
| `ClientSecret` | nvarchar(255), null |  | OAuth - Client secret |
| `SendEmailMethodTypeId` | int, not null | `dbo.SendEmailMethodType` | ID of the send email method type (SendEmailMethodType.Id) |

## dbo.tString

System code list for texts.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iStringId` | int, not null |  |  |
| `mString` | nvarchar(max), null |  |  |

## dbo.tSwLibAddUnknown

Sending unrecognized records, request for adding product to the standard software product library.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iSwLibAddUnknownId` | int, not null |  |  |
| `dCreated` | datetime, not null |  |  |
| `liCreatedPersonId` | int, not null | `dbo.tPerson` |  |
| `Comments` | nvarchar(max), null |  |  |
| `sAttachmentName` | nvarchar(255), null |  |  |
| `oAttachment` | image, null |  |  |
| `dNextTry` | datetime, null |  |  |
| `sEmail` | nvarchar(255), null |  |  |
| `bInform` | bit, not null |  |  |
| `liProductId` | int, null | `dbo.tblProduct` |  |
| `iRequestUID` | int, null |  |  |
| `iNewProductUID` | int, null |  |  |
| `IsSwScanIssue` | bit, not null |  | 1 = reported software issue, 0 = unkown software |

## dbo.tSwPresence

Software profiles - product statuses.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iSwPresenceId` | int, not null |  |  |
| `sSwPresence` | nvarchar(255), not null |  |  |

## dbo.tSwProfile

Software profiles - list.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iSwProfileId` | int, not null |  |  |
| `sSwProfile` | nvarchar(255), null |  |  |
| `bMemberSwProfile` | bit, not null |  |  |
| `mDescription` | nvarchar(max), null |  |  |
| `mNotes` | nvarchar(max), null |  |  |

## dbo.tSwProfileProduct

Software profiles - membership of products in profiles.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liSwProfileId` | int, not null | `dbo.tSwProfile` |  |
| `liProductId` | int, not null | `dbo.tblProduct` |  |
| `liSwPresenceId` | int, not null | `dbo.tSwPresence` |  |
| `liMemberSwProfileId` | int, null | `dbo.tSwProfile` |  |

## dbo.tSwProfileSwProfile

Software profiles - sub-profiles.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `liSwProfileId` | int, not null | `dbo.tSwProfile` |  |
| `liMemberSwProfileId` | int, not null | `dbo.tSwProfile` |  |

## dbo.tTimeOff

Employee absence records.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iTimeOffId` | int, not null |  |  |
| `liPersonId` | int, not null | `dbo.tPerson` |  |
| `liTimeOffKindId` | int, not null | `dbo.tTimeOffKind` |  |
| `dTimeOff` | datetime, not null |  |  |
| `bHalf` | bit, not null |  |  |
| `mNotes` | nvarchar(max), null |  |  |
| `dCreated` | datetime, not null |  |  |
| `liCreatedPersonId` | int, null | `dbo.tPerson` |  |
| `dModified` | datetime, not null |  |  |
| `liModifiedPersonId` | int, null | `dbo.tPerson` |  |

## dbo.tTimeOffKind

Types of employee absence records.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iTimeOffKindId` | int, not null |  |  |
| `sTimeOffKind` | nvarchar(255), not null |  |  |

## dbo.tWeekOpeningHours

Item in the definition of service operating hours.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iWeekOpeningHoursId` | int, not null |  |  |
| `liOpeningHoursId` | int, not null | `dbo.tOpeningHours` |  |
| `nOpeningHour` | float, not null |  |  |
| `nClosingHour` | float, not null |  |  |
| `bSunday` | bit, not null |  |  |
| `bMonday` | bit, not null |  |  |
| `bTuesday` | bit, not null |  |  |
| `bWednesday` | bit, not null |  |  |
| `bThursday` | bit, not null |  |  |
| `bFriday` | bit, not null |  |  |
| `bSaturday` | bit, not null |  |  |
| `dValidSince` | datetime, not null |  |  |
| `dInvalidSince` | datetime, null |  |  |

## dbo.tWorkLoad

Employee labor contracts.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iWorkLoadId` | int, not null |  | Record ID. |
| `liPersonId` | int, not null | `dbo.tPerson` | ID of the person assigned this labor contract |
| `dStart` | datetime, not null |  | Labor contract start date (UTC) |
| `dEnd` | datetime, null |  | Labor contract end date + 1 (UTC). NULL represents a labor contract for an indefinite period. |
| `iWorkHoursPerDay` | float, not null |  | Number of work hours per day. |

## dbo.tWorkTime

Employee attendance record created in the ALVAO Attendance module.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `iWorkTimeId` | int, not null |  | Record ID |
| `liPersonId` | int, not null | `dbo.tPerson` | User ID |
| `dStart` | datetime, not null |  | Time at which the work started |
| `dStop` | datetime, null |  | Time at which work started/finished |
| `mNotes` | nvarchar(max), null |  | Note |
| `dCreated` | datetime, not null |  | Time at which the record for starting work was inserted |
| `liCreatedPersonId` | int, null | `dbo.tPerson` | ID of the person that entered the record for starting work |
| `dStopped` | datetime, null |  | Time at which the record for finishing work was inserted |
| `liStoppedPersonId` | int, null | `dbo.tPerson` | ID of the person that entered the record for completing work |
| `dModified` | datetime, not null |  | Time at which the record was last updated |
| `liModifiedPersonId` | int, null | `dbo.tPerson` | ID of the last person to update the record |

## dbo.UserLogonLog

Logging users in/out to/from Asset Management Console.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Record ID. |
| `TimeStamp` | datetime, not null |  | Date and time of logon/logout. |
| `ActionId` | int, not null | `dbo.UserLogonLogAction` | Kind of action from UserLogonLogAction. |
| `PersonLogin` | nvarchar(255), not null |  | The username of the logged-in user. |
| `Person` | nvarchar(255), null |  | Logged-in user name. |
| `Computer` | nvarchar(255), null |  | Computer name. |
| `IsAdmin` | bit, not null |  | Identifier of whether or not the user was entitled to change the object security. |
| `ApplicationId` | int, not null | `dbo.UserLogonLogApplication` | Application to which the user has logged in. |

## dbo.UserLogonLogAction

Executed action which is logged.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Action ID. |
| `Name` | nvarchar(50), not null |  | Action name. |

## dbo.UserLogonLogApplication

Application name.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `Id` | int, not null |  | Application ID. |
| `Name` | nvarchar(50), not null |  | Application name. |

## dbo.WebAppActiveSession

Active session at ALVAO WebApp.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Session ID. |
| `PersonId` | int, not null | `dbo.tPerson` | Signed-in user ID. |
| `ExpireDate` | datetime, not null |  | Date and time of session expiration. |
| `TicketGUID` | uniqueidentifier, not null |  | Authentication ticket Id. |
| `ClientAddress` | nvarchar(50), null |  | IP address of the logged in user |

## dbo.Webhook

Registered webhooks integrating Alvao with other applications.

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), null |  | Webhook name |
| `Enabled` | bit, not null |  | 1 = the webhook is enabled, 0 = disabled. |
| `TopicId` | int, not null | `dbo.WebhookTopic` | Webhook topic ID (WebhookTopic.id) |
| `Url` | nvarchar(2048), not null |  | Webhook callback URL |
| `Created` | datetime, not null |  | Creation date |
| `LastInvoked` | datetime, null |  | Last invocation date |
| `ErrorMessage` | nvarchar(max), null |  | Error message at the last invocation. |
| `TicketStateId` | int, null | `dbo.TicketState` | Ticket status in which the webhook should be invoked (TicketState.id). |
| `SectionId` | int, null | `dbo.tHdSection` | Ticket service for which the webhook should be invoked (tHdSection.iHdSectionId). |
| `TicketTypeId` | int, null | `dbo.TicketType` | Ticket process for which the webhook should be invoked (TicketType.id). |
| `ColumnId` | int, null | `dbo.tColumn` | Ticket field ID for wich the webhook should be invoked (tColumn.iColumnId). |
| `NodeClassId` | int, null | `dbo.tblClass` | Object type in which the webhook should be invoked (tblClass.intClassId). |
| `ParentNodeId` | int, null | `dbo.tblNode` | ID of the parent object for whose subtree the webhook should be invoked (tblNode.intNodeId). |
| `NodePropertyKindId` | int, null | `dbo.tblKind` | Object property kind in which the webhook should be invoked (tblKind.intKindId). |
| `NodePropertyNewValue` | nvarchar(255), null |  | New object property value in which the webhook should be invoked. |
| `MovedFromNodeId` | int, null | `dbo.tblNode` | ID of the source object for whose subtree the webhook should be invoked (tblNode.intNodeId). |
| `MovedToNodeId` | int, null | `dbo.tblNode` | ID of the destination object for whose subtree the webhook should be invoked (tblNode.intNodeId). |

## dbo.WebhookTopic

Webhook topics

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `Name` | nvarchar(255), not null |  | Webhook topic name |

## dbo.WorkOvertimeDisposal

Table with list of paid overtime hours

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Record ID |
| `PersonId` | int, not null | `dbo.tPerson` | ID of the person who received payment for overtime hours |
| `Hours` | float, not null |  | Number of paid overtime hours |
| `Date` | datetime, not null |  | Date of overtime hour payment |
| `CreatedByPersonId` | int, not null | `dbo.tPerson` | ID of the person who paid for overtime hours |
| `Notes` | nvarchar(max), null |  | Notes |
| `RemovedByPersonId` | int, null | `dbo.tPerson` | ID of the person that deleted the record |
| `RemovedDate` | datetime, null |  | Date on which the record was deleted. |

## Perf.AppOperation

Measured operations in applications

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | int, not null |  | Operation identifier |
| `AppOperation` | nvarchar(255), null |  | Operation name |

## Perf.AppOperationRecord

Operation responses in applications

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | bigint, not null |  | Record identifier |
| `AppOperationId` | int, not null | `Perf.AppOperation` | Measured operation identifier. A foreign key to the AppOperation table. |
| `OperationStart` | datetime, not null |  | Operation start time |
| `ServerDurationSeconds` | float, null |  | Duration of the operation on the server in seconds |
| `ClientDurationSeconds` | float, null |  | Duration of the operation in the client in seconds |
| `UserPersonId` | int, not null | `dbo.tPerson` | User identifier of a person who performed the operation |

## Perf.AppOperationRecordData

Additional operation data in applications

| Column | Type | References | Description |
| :--- | :--- | :--- | :--- |
| `id` | bigint, not null |  | Data record identifier |
| `AppOperationRecordId` | bigint, not null | `Perf.AppOperationRecord` | Identifier of a record to which the data is related. A foreign key to the AppOperationRecord table. |
| `DataName` | nvarchar(255), null |  | Parameter name |
| `TextDataValue` | nvarchar(255), null |  | Parameter text value |
| `IntDataValue` | int, null |  | Integer parameter value |
| `FloatDataValue` | float, null |  | Real parameter value |

