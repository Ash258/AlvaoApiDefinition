using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers;

namespace AlvaoScrapper;

public static class MonkeyPatch {
    // Monkeypatch not documented classes to make project compilable
    public static void PatchUnDocumentedClasses(ILogger Logger) {
        var caution = "!!!CAUTION: This class is not documented. It was generated as empty, to make the project compilable";
        var cautionM = "!!!CAUTION: This member is not documented. It was generated as empty, to make the project compilable";
        var swLibraryNs = State.Namespaces.GetValueOrDefault("Alvao.API.AM.Model.SwLibrary");
        var commonModelDataseNs = State.Namespaces.GetValueOrDefault("Alvao.API.Common.Model.Database");
        var commonNs = State.Namespaces.GetValueOrDefault("Alvao.API.Common");
        var apiSd = State.Namespaces.GetValueOrDefault("Alvao.API.SD");
        var apiAm = State.Namespaces.GetValueOrDefault("Alvao.API.AM");
        var modelDet = State.Namespaces.GetValueOrDefault("Alvao.API.AM.Model.Detection");
        var contextNs = State.Namespaces.GetValueOrDefault("Alvao.Context");
        var appsApi = State.Namespaces.GetValueOrDefault("Alvao.Apps.API");
        if (
            null == swLibraryNs ||
            null == commonModelDataseNs ||
            null == apiSd ||
            null == apiAm ||
            null == modelDet ||
            null == contextNs ||
            null == commonNs ||
            null == appsApi
        ) {
            Logger.LogWarning("Cannot generate undocumented classes");
            return;
        }

        Logger.LogInformation("Monkeypatching undocumented classes");

        // swLibraryNs
        foreach (var name in new string[] { "ISwLibRepository", "ArchiveStream" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                swLibraryNs,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        // modelDet
        foreach (var name in new string[] { "ArchiveStream" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                modelDet,
                caution,
                $"public abstract class {name}",
                [],
                [],
                [],
                [
                    new DotnetPropertyOrFieldOrEvent() {
                        Name = "Unicode",
                        Summary = cautionM,
                        Definition = "public abstract bool IsUnicode { get; }",
                    }
                ],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        // commonModelDataseNs
        foreach (var name in new string[] { "IDocumentRepository", "IDetectionRepository", "IObjectPropertyRepository" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                commonModelDataseNs,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        // apiSd
        foreach (var name in new string[] { "AlvaoConfigurationXmlModel", "ImportViewModel" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                apiSd,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        // apiAm
        foreach (var name in new string[] { "IFormattedTextWriter" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                apiAm,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        // commonNs
        foreach (var name in new string[] { "LicenseModule", "ModuleInfo", "DocumentFieldDictionary", "AnalyzeResult", "AnalyzedDocument", "ServiceBase" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                commonNs,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            ) {
                Enums = [
                    new DotnetEnum() {
                        Name = "ModuleId",
                        Summary = cautionM,
                        Definition = "public enum ModuleId",
                    }
                ]
            };

            clazz.ProduceFinalCsFile();
        }

        // contextNs
        foreach (var name in new string[] { "IDbContextProvider" }) {
            var clazz = new AlvaoClass(
                name,
                "Class",
                contextNs,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        PatchManuallyDocumentedActions(appsApi);

        // Manual class copying as CopyNewPropertyValueToAnotherProperty is using ObjectPropertyEventArgs from Alvao.Apps.API namespace, which is not documented
        foreach (var name in new string[] { "ObjectPropertyEventArgs", "ObjectPropertyModifyResult", "CommandDesc" }) {
            var toCopy = State.Classes.GetValueOrDefault($"Alvao.API.Common.Model.CustomApps.{name}");
            if (toCopy == null) continue;

            Logger.LogInformation("Copying {} to {} namespace", name, appsApi.Name);
            toCopy.Namespace = appsApi;
            toCopy.Summary = $"{caution}<br/><br/>{toCopy.Summary}";

            if (toCopy.Name.Equals("CommandDesc")) {
                toCopy.Constructors.Add(new() {
                    Name = "CommandDesc",
                    Definition = "public CommandDesc(int id, string name, int position, string icon)",
                });
            }

            toCopy.ProduceFinalCsFile(rebuidlNamespaceInfo: true);
        }
    }

    public static void PatchManuallyDocumentedActions(AlvaoNamespace appsApi) {
        var ar = new[] {
            new {
                N = "IPeriodicAction",
                S = "By implementing the IPeriodicAction interface in a application script, you can define custom periodic actions. Custom actions can be run at a regular time interval. The system runs periodic custom actions every hour.<br/><br/>In the application, create a new script using the IPeriodicAction template and name it appropriately according to the functionality that the action performs. In the newly created script, set the value of the Name property (the name of the action itself) in the class constructor.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/periodic-custom-actions/",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnPeriod",
                        Summary = "In the method, define both the conditions for performing the operations and the operations themselves.",
                        Definition = "void OnPeriod(SqlConnection con);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/periodic-custom-actions/#onperiod",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                        ],
                    },
                },
            },
            new {
                N = "IEntityCommand",
                S = "By implementing this interface, you can define custom commands for an object or a ticket.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-command",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "Show",
                        Summary = "This method controls display of the command in command menus.",
                        Definition = " EntityCommandShowResult Show(int entityId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-command#show",
                        Parameters = [
                            ("entityId", "the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed."),
                            ("personId", "the ID of the user(tPerson.iPersonId) to whom the command should be displayed."),
                        ],
                        Returns = "An instance of the class EntityCommandShowResult with properties:<br/>- Name (string) - a display name of the command<br/>- Show (bool) - true = the command will be displayed, false = the command will not be displayed.<br/>- Position (int) - the position in UI at which the command will be displayed:<br/>- 1 = first position of the entity main menu<br/>- 2 = last position of the entity main menu<br/>- 3 = first position of the nested menu in the entity main menu<br/>- 4 = last position of the nested menu in the entity main menu<br/>- Icon(string) - a command icon name; Use the Microsoft fluent library viewer with “20 Regular” filter on. After finding the most suitable icon, copy its name without “fluent:” and replace “-“ characters with “_”.<br/>- Example: The icon fluent: edit - 20 - regular use in your code as edit_20_regular.",
                    },
                    new() {
                        Name = "Run",
                        Summary = "This method implements the command itself.",
                        Definition = "CommandResult Run(int entityId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-command#run",
                        Parameters = [
                            ("entityId", "the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command was run."),
                            ("personId", "the user ID(tPerson.iPersonId) who ran the command."),
                        ],
                        Returns = "An instance of the CommandResult class containing properties:<br/><br/><br/>- MessageType (MessageType) - specify whether a message should be displayed to the user as a result of the command execution:<br/>- None – no message will be displayed<br/>- Info - an information message will be displayed<br/>- Warning - a warning message will be displayed<br/>- Error - an error message will be displayed<br/>- MessageText(string) - specify a text of the message that will be displayed to the user.<br/>- NavigateToUrl(string) - optionally specify an URL to navigate to after the command execution.",
                    },
                },
            },
            new {
                N = "IGeneralCommand",
                S = @"
                By implementing the IGeneralCommand interface in a application script, you can define custom main menu commands.
                By placing a command in the main menu, you can give users access to frequently used pages and operations that are not tied to a specific ticket in ALVAO Service Desk or Asset Management function. Commands are displayed in the main menu of the Alvao WebApp application. In the Service Desk or Asset Management application, create a new script using the IGeneralCommand template and name it appropriately according to the functionality of the custom command. In the newly created script, set the id, name, position, and icon property values in the constructor of the command class:
                ",
                FU = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/general-custom-commands",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "Show",
                        Summary = "This method checks the defined conditions for displaying the command.",
                        Definition = "bool Show(SqlConnection con, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/general-custom-commands/#show",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("personId", "User ID (tPerson.iPersonId) to which the command should be displayed."),
                        ],
                        Returns = "The true value of whether the command should be displayed to the user in the main menu of the application.",
                    },
                    new() {
                        Name = "Run",
                        Summary = "This method runs the command itself.",
                        Definition = "Tuple<bool, string, string> Run(SqlConnection con, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/general-custom-commands/#run",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("personId", "The user ID (tPerson.iPersonId) that runs the command.")
                        ],
                        Returns = "- bool - the truth value of whether the command was executed.<br/>- string - text that can be displayed in the message to the user.<br/>- string - URL to open in the browser.",
                    },
                },
            },
            new {
                N = "ITicketAutoAction",
                S = "By implementing the ITicketAutoAction interface in a application script, you can define custom actions based on a change in the value of a ticket field or respond to a newly created ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions/",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnTicketChanged",
                        Summary = "Custom action based on a change in the value of a ticket field (custom/system). In the implemented method, define both the conditions for performing the operations and the operations themselves.",
                        Definition = "void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions/#onticketchanged",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the database transaction in progress."),
                            ("ticketId", "The ID of the ticket (tHdTicket.iHdTicketId) to which the custom action applies."),
                            ("personId", "The ID of the user (tPerson.iPersonId) who executed the event on the ticket.In some cases it could be the system, then the value is NULL."),
                            ("properties", "the changed ticket fields separated by a comma(table.column)."),
                        ],
                    },
                    new() {
                        Name= "OnTicketCreated",
                        Summary = "Custom action based on the creation of a ticket. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.",
                        Definition = "void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions/#onticketcreated",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the ongoing database transaction."),
                            ("ticketId", "New ticket ID (tHdTicket.iHdTicketId)."),
                            ("personId", "ID of the user (tPerson.iPersonId) who created the ticket (does not always have to be the requester)."),
                        ],
                    },
                },
            },
            new {
                N = "IActAutoAction",
                S = "By implementing the IActAutoAction interface in a application script, you can define custom actions when creating an event on a ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the constructor of the action class.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnActChanged",
                        Summary = "Custom action based on event modification. In the implemented method, define both the conditions for executing the operations and the event operations themselves.",
                        Definition = "void OnActChanged(SqlConnection con, SqlTransaction trans, int actId, int personId, string properties);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#onactchanged",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the database transaction in progress."),
                            ("actId", "The ID of the event (tAct.iActId) that was changed."),
                            ("personId", "The ID of the user (tPerson.iPersonId) who changed the event."),
                            ("properties", "the changed event fields separated by a comma(table.column)."),
                        ],
                    },
                    new() {
                        Name = "OnActCreated",
                        Summary = "Custom action based on event creation. In the implemented method, define both the conditions for executing the operations and the event operations themselves.",
                        Definition = "void OnActCreated(SqlConnection con, SqlTransaction trans, int actId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#onactcreated",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the database transaction in progress."),
                            ("actId", "The ID of the event (tAct.iActId) that was changed."),
                            ("personId", "The ID of the user (tPerson.iPersonId) who changed the event."),
                        ],
                    },
                    new() {
                        Name = "OnActRemoved",
                        Summary = "Custom action based on event removal. In the implemented method, define both the conditions for executing the operations and the event operations themselves.",
                        Definition = "void OnActRemoved(SqlConnection con, SqlTransaction trans, int actId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions#onactremoved",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the database transaction in progress."),
                            ("actId", "The ID of the event (tAct.iActId) that was changed."),
                            ("personId", "The ID of the user (tPerson.iPersonId) who changed the event."),
                        ],
                    },
                },
            },
            new {
                N = "ITicketApprovalAutoAction",
                S = "You can define custom actions by implementing the ITicketApprovalAutoAction interface in application scripts. Automatic actions are only called for manually triggered approvals with automatic status transition disabled. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnApproved",
                        Summary = "Custom action based on ticket approval. In the implemented method, define both the conditions for executing the operations and the operations themselves.",
                        Definition = "void OnApproved(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onapproved",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the ongoing database transaction."),
                            ("ticketId", "Ticket ID (tHdTicket.iHdTicketId)."),
                            ("approvalItemId", "approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId)."),
                        ],
                    },
                    new() {
                        Name = "OnRejected",
                        Summary = "Custom action based on the approval of the ticket rejection. In the implemented method, define both the conditions for executing the operations and the operations themselves.",
                        Definition = "void OnRejected(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onrejected",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the ongoing database transaction."),
                            ("ticketId", "Ticket ID (tHdTicket.iHdTicketId)."),
                            ("approvalItemId", "approval step ID (tHdTicketApprovalItem.iHdTicketApprovalItemId)."),
                        ]
                    },
                    new() {
                        Name = "OnApproverAdded",
                        Summary = "Custom action based on adding a ticket approver. In the implemented method, define both the conditions for executing the operations and the operations themselves.",
                        Definition = "void OnApproverAdded(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onapproveradded",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the ongoing database transaction."),
                            ("ticketId", "Ticket ID (tHdTicket.iHdTicketId)."),
                            ("approvalItemId", "approvalItemIds - List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId)."),
                        ]
                    },
                    new() {
                        Name = "OnApproverCanceled",
                        Summary = "Custom action based on the removal of the ticket approver. In the implemented method, define both the conditions for executing the operations and the operations themselves.",
                        Definition = "void OnApproverCanceled(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions#onapprovercanceled",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the ongoing database transaction."),
                            ("ticketId", "Ticket ID (tHdTicket.iHdTicketId)."),
                            ("approvalItemId", "List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId)."),
                        ],
                    }
                },
            },
            new {
                N = "IMailMessageAutoAction",
                S = "By implementing the IMailMessageAutoAction interface in the application script you can define custom actions when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnMessageReceived",
                        Summary = "The actual action can be performed when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the implemented method, define both the conditions for executing the operations and the operations themselves.",
                        Definition = "bool OnMessageReceived(SqlConnection con, SqlTransaction trans, MailMessage message, int sectionId, int ticketId, int fromPersonId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions#onmessagereceived",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("trans", "SqlTransaction of the ongoing database transaction."),
                            ("message", "message object."),
                            ("sectionId", "the service ID (tHdSection.iSectionId) which the message was loaded to."),
                            ("ticketId", "ID of the ticket (tHdTicket.iHdTicketId) to which the message belongs according to the subject, or zero if it is a new ticket creation."),
                            ("fromPersonId", "message sender ID(tPerson.iPersonId), or Host account, if the message sender is not found among the users."),
                        ],
                        Returns = "Return true or false indicating whether or not the message should continue to be processed by default. For an example use case, see the AssignToSolverByEmail application template.",
                    },
                },
            },
            new {
                N = "IObjectPropertyAutoAction",
                S = "By implementing the IObjectPropertyAutoAction interface in a application script, you can define custom actions that are automatically performed when the user manually modifies the value of an object property.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnObjectPropertyModifying",
                        Summary = "This method is called before saving the modified property value to the database, e.g. within the Modify (property) statement.",
                        Definition = "ObjectPropertyModifyResult OnObjectPropertyModifying(ObjectPropertyEventArgs e);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change#onobjectpropertymodifying",
                        Parameters = [
                            ("e", "Property event method parameters:<br/> - ObjectId - ID of the object (tblNode.intNodeId) that is being modified.<br/> - PropertyKindId - ID of the property kind (tblKind.intKindId) of the object that is being modified.<br/> - PersonId - the ID of the user (tPerson.iPersonId) who invoked the action.<br/> - NewValue - new value of the property."),
                        ],
                    },
                    new() {
                        Name = "OnObjectPropertyModified",
                        Summary = "This method is called after writing a new property value to the database, e.g. by the *Modify (property)*statement.",
                        Definition = "void OnPropertyModified(ObjectPropertyEventArgs e);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change#onobjectpropertymodified",
                        Parameters = [
                            ("e", "Property event method parameters:<br/> - ObjectId - ID of the object (tblNode.intNodeId) that is being modified.<br/> - PropertyKindId - ID of the property kind (tblKind.intKindId) of the object that is being modified.<br/> - PersonId - the ID of the user (tPerson.iPersonId) who invoked the action.<br/> - NewValue - new value of the property."),
                        ],
                    },
                },
            },
            new {
                N = "IObjectMoveAutoAction",
                S = "By implementing the IObjectMoveAutoAction interface in an application script, you can define custom actions that are automatically performed when an object is moved to another location in the object tree, including removing the object to the Trash.",
                FU = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move",
                M = new List<DotnetMethod>() {
                    new() {
                        Name = "OnObjectMoving",
                        Summary = "This method is called before moving an object in the tree to another location, e.g. within the Move statement.",
                        Definition = "Tuple<bool, string> OnObjectMoving(SqlConnection con, int objectId, int newParentObjectId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#onobjectmoving",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("objectId", "ID of the object (tblNode.intNodeId) to be moved."),
                            ("newParentObjectId", "ID of the object (tblNode.intNodeId) to which the object is to be moved. A value of 0 means that the object will be moved to the root of the tree."),
                            ("personId", "the ID of the user (tPerson.iPersonId) who invoked the action."),
                        ],
                        Returns = "bool - if the method returns true, the object is moved to a new position in the database. If the method returns false, the operation will not be performed and the upcoming object move will be canceled.<br/>string - the message that will be displayed to the user if the return value is false.",
                    },
                    new() {
                        Name = "OnObjectMoved",
                        Summary = "This method is called after moving an object in the tree.",
                        Definition = "void OnObjectMoved(SqlConnection con, int objectId, int oldParentObjectId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#onobjectmoved",
                        Parameters = [
                            ("con", "SqlConnection to the database."),
                            ("objectId", "ID of the object (tblNode.intNodeId) to be moved."),
                            ("oldParentObjectId", "the ID of the object (tblNode.intNodeId) that was the father (parent object) of the object with objectId before it was moved. A value of 0 means that the object was moved from the root of the tree."),
                            ("personId", "the user ID (tPerson.iPersonId) that triggered the action."),
                        ],
                    },
                },
            },
            new {
                N = "IEntityTab",
                S = "By implementing this interface, you can define custom tabs on the object or ticket page. A custom tab can view any web content displayable in an iframe tag. For an example, see the ShowRequesterAddress application template.<br/><br/>In the application create a new script using the IElementTab template and name it appropriately according to the content of the tab. In the newly created script, set the following properties in the constructor of the class:<br/> - Id - a unique tab identifier (string)<br/> - Entity - the type of entity for which the tab will be displayed(Entity.Ticket or Entity.Object).",
                FU = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-tab",
                M = new List<DotnetMethod> {
                    new() {
                        Name = "Show",
                        Summary = "This method handles the display of the entity custom tab.",
                        Definition = "EntityTabShowResult Show (int entityId, int personId);",
                        FullUrl = "https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-tab#show",
                        Parameters = [
                            ("entityId", "the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the custom tab should be displayed."),
                            ("personId", "the ID of the user(tPerson.iPersonId) to whom the custom tab should be displayed."),
                        ],
                        Returns = "An instance of the class EntityTabShowResult with properties:<br/>- Show (bool) - true = the tab will be displayed; false = the tab will not be displayed.<br/>- Name ( string) - a display name of the tab<br/>- Url ( string) - an URL of a content of the tab.",
                    },
                },
            },
        };

        foreach (var item in ar) {
            List<string> usings = ["Alvao.API.Common.Model.CustomApps", "Microsoft.Data.SqlClient"];
            if (item.N == "IMailMessageAutoAction") usings.Add("Rebex.Mail");

            var clazz = new AlvaoClass(item.N, "Interface", appsApi, item.S, $"public interface {item.N}", usings, [], item.M, [], []) {
                FullUrl = item.FU
            };
            clazz.ProduceFinalCsFile();
        }
    }

    // Monkeypatch usings based on class names
    public static void PatchUsings(AlvaoClass clazz, ILogger Logger) {
        List<string> toAdd = [];

        switch (clazz.NamespaceName) {
            case "Alvao.API.AM":
                toAdd.Add("Alvao.API.Common.Model.Database");

                AddUsingByClassName("CustomApps", "Alvao.API.Common.Model.CustomApps", clazz.Name, toAdd);
                AddUsingByClassName("CustomApps", "Alvao.API.Common.Model.CustomApps.Requests", clazz.Name, toAdd);

                AddUsingByClassName("SwLib", "Alvao.API.AM.Model.SwLibrary", clazz.Name, toAdd);
                AddUsingByClassName("SoftwareProfile", "Alvao.API.AM.Model", clazz.Name, toAdd);
                AddUsingByClassName("Object", "Alvao.API.AM.Model", clazz.Name, toAdd);
                AddUsingByClassName("Object", "Alvao.API.AM.Exceptions", clazz.Name, toAdd);
                AddUsingByClassName("Object", "Alvao.API.AM.Model.XmlExport", clazz.Name, toAdd);
                AddUsingByClassName("ImportCsv", "Alvao.API.AM.Model", clazz.Name, toAdd);
                AddUsingByClassName("ObjectProperty", "Alvao.API.AM.Model", clazz.Name, toAdd);

                AddUsingByClassName("LinkModel", "Alvao.API.Common.Model", clazz.Name, toAdd);
                AddUsingByClassName("AMDocument", "Alvao.API.Common.Model", clazz.Name, toAdd);
                AddUsingByClassName("AMDocument", "Alvao.API.AM.Model", clazz.Name, toAdd);
                AddUsingByClassName("InvoiceProcessor", "Alvao.API.AM.Model", clazz.Name, toAdd);
                break;
            case "Alvao.API.AM.Model":
                AddUsingByClassName("ObjectClass", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("ObjectProperty", "Alvao.API.AM.Model", clazz.Name, toAdd);
                AddUsingByClassName("CancelOemLicenseModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("InvoiceProperty", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                break;
            case "Alvao.API.AM.Model.Detection":
                AddUsingByClassName("DetectLog", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("XmlDetection", "System.Collections", clazz.Name, toAdd);
                AddUsingByClassName("XmlDetection", "System.Xml.XPath", clazz.Name, toAdd);

                AddUsingByClassName("CompareProperty", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("CompareProperty", "System.Data", clazz.Name, toAdd);
                AddUsingByClassName("CompareProperty", "static Alvao.API.Common.Model.Database.KindDataType", clazz.Name, toAdd);

                AddUsingByClassName("DetectionMessage", "System.Xml", clazz.Name, toAdd);
                AddUsingByClassName("DetectionArchive", "System.Xml", clazz.Name, toAdd);
                break;

            case "Alvao.API.Common":
                AddUsingByClassName("AuditLog", "Alvao.API.Common.Model", clazz.Name, toAdd);

                AddUsingByClassName("Person", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("PersonRights", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("Role", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);

                AddUsingByClassName("CustomApps", "Alvao.API.Common.Model.CustomApps", clazz.Name, toAdd);
                AddUsingByClassName("CustomApps", "Alvao.API.Common.Model.CustomApps.Requests", clazz.Name, toAdd);

                AddUsingByClassName("CustomColumn", "Alvao.API.Common.Model", clazz.Name, toAdd);
                AddUsingByClassName("Locale", "Alvao.API.Common.Model", clazz.Name, toAdd);

                AddUsingByClassName("MSEntraTenant", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("Locale", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("ExternalService", "Alvao.API.Common.Model", clazz.Name, toAdd);
                break;
            case "Alvao.API.Common.Model":
                AddUsingByClassName("ColumnValue", "static Alvao.API.Common.Database", clazz.Name, toAdd);
                break;
            case "Alvao.API.Common.Model.Database":
                AddUsingByClassName("DatabaseModelAutomapperProfile", "AutoMapper", clazz.Name, toAdd);
                AddUsingByClassName("ObjectProperty", "Alvao.API.AM.Model", clazz.Name, toAdd);
                AddUsingByClassName("ObjectRight", "Alvao.API.AM.Model", clazz.Name, toAdd);
                break;
            case "Alvao.API.SD":
                toAdd.Add("Alvao.API.Common.Model.Database");

                AddUsingByClassName("TicketState", "Alvao.API.SD.Model", clazz.Name, toAdd);
                AddUsingByClassName("TicketState", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);

                AddUsingByClassName("TicketProcess", "Alvao.API.SD.Model", clazz.Name, toAdd);

                AddUsingByClassName("CustomApps", "Alvao.API.Common.Model.CustomApps", clazz.Name, toAdd);
                AddUsingByClassName("CustomApps", "Alvao.API.Common.Model.CustomApps.Requests", clazz.Name, toAdd);

                AddUsingByClassName("Message", "Alvao.API.SD.Model", clazz.Name, toAdd);
                AddUsingByClassName("Act", "Alvao.API.SD.Model", clazz.Name, toAdd);
                break;
            case "Alvao.API.SD.Exceptions":
                AddUsingByClassName("RequiredFieldsException", "Alvao.API.SD.Model", clazz.Name, toAdd);
                break;
            case "Alvao.API.SD.Model":
                AddUsingByClassName("TicketTemplateColumnModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("RelatedTicketRuleModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);

                AddUsingByClassName("NewTicketModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("SendMessageSettingsModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                AddUsingByClassName("InitialActSettings", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);

                AddUsingByClassName("ChangeTicketStateSettingsModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);

                AddUsingByClassName("ActCreateSettings", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                break;
            case "Alvao.Context":
                AddUsingByClassName("AlvaoContext", "Alvao.Context.DB", clazz.Name, toAdd);
                break;
            case "Alvao.Context.DB":
                AddUsingByClassName("IConnectionScope", "System.Data", clazz.Name, toAdd);
                AddUsingByClassName("IConnectionScope", "Microsoft.Data.SqlClient", clazz.Name, toAdd);
                break;
            case "Alvao.API.AI.Service":
                AddUsingByClassName("IDocumentIntelligenceClientService", "Alvao.API.Common", clazz.Name, toAdd);
                AddUsingByClassName("IDocumentIntelligenceClientService", "Azure", clazz.Name, toAdd);
                break;
            case "Alvao.API.AI.Service.Implementation":
                AddUsingByClassName("DocumentIntelligenceClientService", "Azure", clazz.Name, toAdd);
                break;
        }

        if (toAdd.Count == 0) return;

        Logger.LogInformation("Monkeypatching usings based on class name [{}] {{{}}}", clazz.Name, clazz.NamespaceName);
        clazz.Usings.AddRange(toAdd);
    }

    // TODO: It will be faster when this will be done while the definitions are processed
    public static void UsingsBasedOnDefinitions(AlvaoClass clazz, ILogger Logger) {
        List<string> definitions = clazz.GetAllDefinitionsAsList();

        List<(string, string)> map =
        [
            (" StringBuilder ", "System.Text"),

            // Exceptions
            ("ValidationInExecuteException", "System.Runtime.Serialization"),
            ("TicketApprovalNotInProgressException", "System.Runtime.Serialization"),
            ("UserTokenServiceError", "System.Runtime.Serialization"),
            ("TranslationsSecretsInvalidException", "System.Runtime.Serialization"),

            // ORM specific annotations
            ("[Ignore]", "AutoMapper.Configuration.Annotations"),
            ("[ExplicitKey]", "Dapper.Contrib"),
            ("[Key]", "Dapper.Contrib.Extensions"),
            ("[Table(", "Dapper.Contrib.Extensions"),
            ("[JsonIgnore]", "Newtonsoft.Json"),
            ("[JsonProperty", "Newtonsoft.Json"),
            ("[JsonPropertyName", "System.Text.Json.Serialization"),
            (" ILogger", "Microsoft.Extensions.Logging"),

            (" IAttachment", "Alvao.API.Common.Model"),
            (" ISerializable", "System.Runtime.Serialization"),
            (" CultureInfo ", "System.Globalization"),
            (" XmlDetection", "System.Xml"),
            (" HttpStatusCode ", "System.Net"),

            // AI
            (" AssistantTicketTabModel ", "Alvao.API.AI.Model"),

            ("IDocumentRepository", "Alvao.API.Common.Model.Database"),
            ("HtmlTextModel ", "Alvao.API.Common.Model"),
            ("CostModel ", "Alvao.API.SD.Model"),

            ("vColumnValueLoc", "Alvao.API.Common.Model.Database"),
            ("vColumnLoc", "Alvao.API.Common.Model.Database"),

            ("ImportViewModel", "Alvao.API.AM.Model.XmlExport"),
            ("ImportCsvSettings", "Alvao.API.AM.Model.CsvImport"),

            ("EmbeddingCreateResponse", "Alvao.API.AI.Model"),
            ("InvoiceTemplate", "Alvao.API.AI.Model"),
            ("AMDocumentsModel", "Alvao.API.AI.Model"),

            (" DocumentFieldDictionary ", "Alvao.API.Common"),
            (" DocumentIntelligenceClientService ", "Alvao.API.Common"),
            ("AnalyzedDocument", "Alvao.API.Common"),
            ("AttachmentModel", "Alvao.API.Common.Model"),
        ];

        foreach (var d in definitions) {
            foreach (var m in map) {
                if (d.Contains(m.Item1)) {
                    Logger.LogDebug("Monkeypatching using based on definition {} [{}] {{{}}}", m.Item2, clazz.Name, clazz.NamespaceName);
                    clazz.Usings.Add(m.Item2);
                }
            }
        }
    }

    // Create methods, that are not specified in the documentaiont
    public static void CreateMethods(AlvaoClass clazz, ILogger Logger) {
        Logger.LogDebug("Monkeypatching missing methods [{}] {{{}}}", clazz.Name, clazz.NamespaceName);

        List<(string, string)> map =
        [
            ("XmlDetection", "public object Clone()"),
            ("DetectionArchive", "public void Dispose()"),
            ("DetectionArchive", "public System.Threading.Tasks.ValueTask DisposeAsync()"),
        ];

        foreach (var m in map) {
            if (clazz.Name.Contains(m.Item1)) {
                Logger.LogDebug("Creating method {} [{}] {{{}}}", m.Item2, clazz.Name, clazz.NamespaceName);
                clazz.Methods.Add(new DotnetMethod() {
                    Name = $"Patched {m.Item2}",
                    Definition = m.Item2,
                    Summary = "!!!CAUTION: This method is not document. It was generated as empty, to make the project compilable",
                });
            }
        }

        Logger.LogDebug("Method monkeypatching done [{}] {{{}}}", clazz.Name, clazz.NamespaceName);
    }

    // Monkeypatch methods definitions and usings based on class names and it's methods definitions
    public static void SpecificMethod(AlvaoClass clazz, DotnetMethod method, ILogger Logger) {
        var _def = string.Empty;

        if (IsClass(clazz, "Alvao.API.Common", "ProfileValue") && string.Equals(method.Name, "Get"))
            _def = method.Definition.Replace(" ProfileValue ", " Alvao.API.Common.Model.Database.ProfileValue ");

        if (IsClass(clazz, "Alvao.API.Common", "Email")) {
            // TODO: Find better way, idealy with example contains
            switch (method.Name) {
                case "Queue":
                    _def = method.Definition.Replace("(MailMessage ", "(Rebex.Mail.MailMessage ");
                    if (clazz.Methods.Count == 1)
                        _def = method.Definition.Replace("(MailMessage ", "(System.Net.Mail.MailMessage ");
                    break;
                case "QueueMailMessage":
                    _def = method.Definition.Replace("(MailMessage ", "(Rebex.Mail.MailMessage ");
                    if (clazz.Methods.Count == 3)
                        _def = method.Definition.Replace("(MailMessage ", "(System.Net.Mail.MailMessage ");
                    break;
            }
        }

        if (IsClass(clazz, "Alvao.API.SD", "TicketState")) {
            switch (method.Name) {
                case "GetStatesFromProcess":
                case "GetFromProcess":
                    _def = method.Definition.Replace("<TicketState>", "<Alvao.API.Common.Model.Database.TicketState>");
                    break;
                case "GetByBehaviorId":
                case "GetById":
                case "GetByName":
                case "GetCurrentStateByTicketId":
                    _def = method.Definition.Replace(" TicketState ", " Alvao.API.Common.Model.Database.TicketState ");
                    break;
            }
        }

        if (IsClass(clazz, "Alvao.API.AM", "ObjectRight")) {
            switch (method.Name) {
                case "CheckForUser":
                case "HasUserObjectRight":
                    _def = method.Definition.Replace("ObjectRight.Right ", "Alvao.API.AM.Model.ObjectRight.Right ");
                    break;
            }
        }

        if (IsClass(clazz, "Alvao.API.Common", "Webhook")) {
            switch (method.Name) {
                case "Create":
                case "Delete":
                    _def = method.Definition.Replace("(Webhook ", "(Alvao.API.Common.Model.Database.Webhook ");
                    break;
                    _def = method.Definition.Replace("(Webhook ", "(Alvao.API.Common.Model.Database.Webhook ");
                    break;
                case "GetById":
                    _def = method.Definition.Replace(" Webhook ", " Alvao.API.Common.Model.Database.Webhook ");
                    break;
                case "GetTopicById":
                    _def = method.Definition.Replace(" WebhookTopic ", " Alvao.API.Common.Model.Database.WebhookTopic ");
                    break;
            }
        }

        if (IsClass(clazz, "Alvao.API.SD", "News")) {
            switch (method.Name) {
                case "GetById":
                    _def = method.Definition.Replace(" News", " Alvao.API.Common.Model.Database.News");
                    break;
            }
        }

        if (string.IsNullOrEmpty(_def)) return;

        Logger.LogInformation("Monkeypatching method {} [{}] {{{}}}", method.Name, clazz.Name, clazz.NamespaceName);
        method.Definition = _def;
    }

    // Monkeypatch constructors definitions based on class names and it's constructor definitions
    public static void SpecificConstructor(AlvaoClass clazz, DotnetConstructor constructor, ILogger Logger) {
        var _def = string.Empty;

        if (IsClass(clazz, "Alvao.API.AM.Model", "Property")) {
            _def = constructor.Definition.Replace("Kind.DataType kind = DataType.KindNone", "Kind.DataType kind = Kind.DataType.KindNone");
        }

        if (string.IsNullOrEmpty(_def)) return;

        Logger.LogInformation("Monkeypatching constructor {} [{}] {{{}}}", constructor.Name, clazz.Name, clazz.NamespaceName);
        constructor.Definition = _def;
    }

    // Monkeypatch properties definitions based on class names and it's properties definitions
    public static void SpecificProperty(AlvaoClass clazz, DotnetPropertyOrFieldOrEvent property, ILogger Logger) {
        var _def = string.Empty;

        if (IsClass(clazz, "Alvao.API.Common.Model", "ColumnValue")) {
            _def = property.Definition.Replace("public Database.ValueDataType DataType", "public ValueDataType DataType");
        }

        if (string.IsNullOrEmpty(_def)) return;

        Logger.LogInformation("Monkeypatching property {} [{}] {{{}}}", property.Name, clazz.Name, clazz.NamespaceName);
        property.Definition = _def;
    }
}

public class MonkeyPatchLogger { }
