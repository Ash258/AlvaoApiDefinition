using AlvaoScapper;

public static class MonkeyPatch
{
    public static string Methods(AlvaoClass clazz, string _name, string _definition)
    {
        if (Helpers.IsClass(clazz, "Alvao.API.AM", "ObjectRight") && _name.Equals("CheckForUser"))
            _definition = _definition.Replace(" ObjectRight.Right ", " Alvao.API.AM.Model.ObjectRight.Right ");
        if (Helpers.IsClass(clazz, "Alvao.API.Common", "ProfileValue"))
        {
            switch (_name)
            {
                case "Get":
                case "Delete":
                case "GetById":
                    _definition = _definition.Replace(" ProfileValue ", " Alvao.API.Common.Model.Database.ProfileValue ");
                    break;
            }
        }
        if (Helpers.IsClass(clazz, "Alvao.API.Common", "Webhook"))
        {
            switch (_name)
            {
                case "Create":
                case "Delete":
                case "GetById":
                    _definition = _definition.Replace(" Webhook ", " Alvao.API.Common.Model.Database.Webhook ");
                    break;
                case "GetTopicById":
                    _definition = _definition.Replace(" WebhookTopic ", " Alvao.API.Common.Model.Database.WebhookTopic ");
                    break;
            }
        }
        if (Helpers.IsClass(clazz, "Alvao.API.SD", "TicketState"))
        {
            switch (_name)
            {
                case "GetFromProcess":
                    _definition = _definition.Replace("<TicketState>", "<Alvao.API.Common.Model.Database.TicketState>");
                    break;
                case "GetByBehaviorId":
                case "GetById":
                case "GetByName":
                case "GetCurrentStateByTicketId":
                    _definition = _definition.Replace(" TicketState ", " Alvao.API.Common.Model.Database.TicketState ");
                    break;
            }
        }

        return _definition;
    }

    public static void UsingProperties(AlvaoClass clazz, string propDef)
    {
        if (propDef.Contains(" IDbContextProvider ")) clazz.Usings.Add("Volo.Abp.EntityFrameworkCore");
        if (propDef.Contains(" IDbConnection ")) clazz.Usings.Add("System.Data");
        if (propDef.Contains(" SqlConnection ")) clazz.Usings.Add("Microsoft.Data.SqlClient");
        if (propDef.Contains(" HttpStatusCode ")) clazz.Usings.Add("System.Net");
        if (propDef.Contains(" CultureInfo ")) clazz.Usings.Add("System.Globalization");
        if (propDef.Contains("[JsonPropertyAttribute(")) clazz.Usings.Add("Newtonsoft.Json");
        if (propDef.Contains("[JsonIgnoreAttribute]")) clazz.Usings.Add("Newtonsoft.Json");
        if (propDef.Contains("[KeyAttribute]")) clazz.Usings.Add("Dapper.Contrib.Extensions");
        if (propDef.Contains("[ComputedAttribute]")) clazz.Usings.Add("Dapper.Contrib.Extensions");
    }

    public static void Using(AlvaoClass clazz)
    {
        if (clazz.Definition.Contains("TableAttribute(")) clazz.Usings.Add("Dapper.Contrib.Extensions");
        if (clazz.Definition.Contains(": Profile")) clazz.Usings.Add("AutoMapper");
        if (clazz.Definition.Contains(": tbl")) clazz.Usings.Add("Alvao.API.Common.Model.Database");
        if (clazz.Definition.Contains(": vColumnLoc")) clazz.Usings.Add("Alvao.API.Common.Model.Database");

        switch (clazz.NamespaceName)
        {
            case "Alvao.API.AI":
                switch (clazz.Name)
                {
                    case "Assistant":
                        clazz.Usings.Add("Alvao.API.AI.Model");
                        break;
                }
                break;
            case "Alvao.API.AM.Exceptions":
                switch (clazz.Name)
                {
                    case "InvalidMoveException":
                    case "InvalidBulkMoveException":
                        clazz.Usings.Add("System.Runtime.Serialization");
                        break;
                }
                break;
            case "Alvao.API.AM":
                switch (clazz.Name)
                {
                    case "Installation":
                    case "Product":
                    case "ObjectRight":
                    case "License":
                    case "Scim":
                        clazz.Usings.Add("Alvao.API.Common.Model.Database");
                        break;

                    case "Object":
                    case "ObjectProperty":
                        clazz.Usings.AddRange(["Alvao.API.AM.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                }
                break;
            case "Alvao.API.SD.Exceptions":
                switch (clazz.Name)
                {
                    case "RequiredFieldsException":
                        clazz.Usings.Add("Alvao.API.SD.Model");
                        break;
                }
                break;
            case "Alvao.API.SD":
                switch (clazz.Name)
                {
                    case "WorkLoad":
                    case "Section":
                    case "TicketParticipant":
                    case "TeamsNotification":
                    case "Organization":
                        clazz.Usings.Add("Alvao.API.Common.Model.Database");
                        break;
                    case "Approval":
                        clazz.Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                    case "MessageTemplate":
                        clazz.Usings.AddRange(["Alvao.API.Common.Model", "System.Globalization"]);
                        break;
                    case "TicketProcess":
                        clazz.Usings.AddRange(["Alvao.API.SD.Model", "System.Globalization"]);
                        break;
                    case "TicketState":
                        clazz.Usings.AddRange(["Alvao.API.Common.Model.Database", "Alvao.API.SD.Model"]);
                        break;
                    case "Message":
                    case "Ticket":
                    case "Act":
                        clazz.Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database", "Alvao.API.SD.Model"]);
                        break;
                }
                break;
            case "Alvao.Context.DB":
                switch (clazz.Name)
                {
                    case "IConnectionScope":
                        clazz.Usings.AddRange(["System.Data", "Microsoft.Data.SqlClient"]);
                        break;
                }
                break;
            case "Alvao.Context":
                switch (clazz.Name)
                {
                    case "AlvaoContext":
                        clazz.Usings.AddRange(["Alvao.Context.DB", "Volo.Abp.EntityFrameworkCore"]);
                        break;
                }
                break;
            case "Alvao.API.SD.Model":
                switch (clazz.Name)
                {
                    case "TicketProcessColumnModel":
                    case "TicketTemplateColumnModel":
                    case "InitialActSettings":
                    case "RelatedTicketRuleModel":
                    case "SendMessageSettingsModel":
                    case "ActCreateSettings":
                        clazz.Usings.Add("Alvao.API.Common.Model.Database");
                        break;

                    case "NewTicketModel":
                        clazz.Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;

                    case "ChangeTicketStateSettingsModel":
                        clazz.Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                }
                break;
            case "Alvao.API.Common":
                switch (clazz.Name)
                {
                    case "CustomColumn":
                        clazz.Usings.AddRange(["System.Globalization", "Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                    case "AuditLog":
                        clazz.Usings.Add("Alvao.API.Common.Model");
                        break;
                    case "Email":
                        clazz.Usings.Add("System.Net.Mail");
                        break;
                    case "Person":
                        clazz.Usings.AddRange(["System.Globalization", "Alvao.API.Common.Model.Database"]);
                        break;

                    case "Role":
                    case "PersonRights":
                        clazz.Usings.Add("Alvao.API.Common.Model.Database");
                        break;
                }
                break;
        }
    }

    public static bool IsInvalidClass(string namespaceName, string className)
    {
        return namespaceName switch
        {
            "Alvao.API.Common" => new string[] { "Activation", "CustomApps" }.Contains(className),
            "Alvao.API.SD" => new string[] { "CustomApps" }.Contains(className),
            "Alvao.API.AM" => new string[] { "CustomApps", "ImportCsv" }.Contains(className),
            _ => false,
        };
    }

    public static bool IsInvalidProperty(string namespaceName, string className, string property)
    {
        switch (namespaceName)
        {
            case "Alvao.API.AM.Model":
                if (className.Equals("ImportCsvSettings") && property.Equals("TextOutput"))
                    return true;
                return false;
            case "Alvao.Context":
                if (new string[] { "AlvaoContext", "CustomApps" }.Contains(className) && property.Equals("DbContextProvider"))
                    return true;
                return false;
            default:
                return false;
        }
    }

    public static bool IsInvalidMethod(string namespaceName, string className, string methodName)
    {
        switch (namespaceName)
        {
            case "Alvao.API.Common.Model":
                if (className.Equals("AttachmentModel") && methodName.Equals("SaveToDB"))
                    return true;
                if (className.Equals("HtmlTextModel") && methodName.Equals("AddAttachmentsBasedOnTemplate"))
                    return true;
                return false;
            case "Alvao.API.SD":
                if (className.Equals("Sections") && new string[] { "Import", "ValidateBeforeImport" }.Contains(methodName))
                    return true;
                return false;
            default:
                return false;
        }
    }

    public static void MonkeyPatchNotAvailableNamespaces()
    {
        var ns = "Alvao.API.Common.Model.CustomApps";
        Helpers.AssertDirectory(ns.Replace(".", "/"));

        ns = "Alvao.Apps.API";
        Helpers.AssertDirectory(ns.Replace(".", "/"));

        MonkeyPatchITicketAutoAction(ns);
        MonkeyPatchIActAutoAction(ns);
        MonkeyPatchITicketApprovalAutoAction(ns);
        MonkeyPatchIMailMessageAutoAction(ns);
        MonkeyPatchIPeriodicActions(ns);
        MonkeyPatchIEntityCommand(ns);
        MonkeyPatchIEntityTab(ns);
        MonkeyPatchIGeneralCommand(ns);
        MonkeyPatchIObjectMoveAutoAction(ns);
        MonkeyPatchIObjectPropertyAutoAction(ns);

        ns = "Alvao.API.Internal";
        Helpers.AssertDirectory(ns.Replace(".", "/"));

        MonkeyPatchInternalUserToken(ns);
    }

    public static void MonkeyPatchITicketAutoAction(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "ITicketAutoAction", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the ITicketAutoAction interface in a application script, you can define custom actions based on a change in the value of a ticket item or respond to a newly created ticket.",
            "/// In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.",
            "/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.",
            "/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-custom-actions",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Properties.Add("public string Name { get; set; }");
        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on a change in the value of a ticket item (custom/system). In the implemented method, define both the conditions for performing the operations and the operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the database transaction in progress.</param>",
            "/// <param name=\"ticketId\">The ID of the ticket (tHdTicket.iHdTicketId) to which the custom action applies.</param>",
            "/// <param name=\"personId\">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>",
            "/// <param name=\"properties\">The changed ticket items separated by a comma (table.column).</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnTicketChanged\"/>",
            "void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on the creation of a ticket. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the database transaction in progress.</param>",
            "/// <param name=\"ticketId\">The ID of the ticket (tHdTicket.iHdTicketId) to which the custom action applies.</param>",
            "/// <param name=\"personId\">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnTicketCreated\"/>",
            "void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIActAutoAction(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IActAutoAction", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the IActAutoAction interface in a application script, you can define custom actions when creating an event on a ticket.",
            "/// In the newly created script, set the value of the Name property (the name of the automatic action) in the constructor of the action class.",
            "/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.",
            "/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/act-custom-actions",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Properties.Add("public string Name { get; set; }");
        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on event modification. In the implemented method, define both the conditions for executing the operations and the event operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the database transaction in progress.</param>",
            "/// <param name=\"actId\">The ID of the event (tAct.iActId) that was changed.</param>",
            "/// <param name=\"personId\">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>",
            "/// <param name=\"properties\">The changed ticket items separated by a comma (table.column).</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnActChanged\"/>",
            "void OnActChanged(SqlConnection con, SqlTransaction trans, int actId, int personId, string properties);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on the creation of a ticket. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the database transaction in progress.</param>",
            "/// <param name=\"actId\">ID of the newly created event (tAct.iActId).</param>",
            "/// <param name=\"personId\">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnActCreated\"/>",
            "void OnActCreated(SqlConnection con, SqlTransaction trans, int actId, int personId);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on event removal. In the implemented method, define both the conditions for executing the operations and the operations with the ticket itself.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the database transaction in progress.</param>",
            "/// <param name=\"actId\">ID of the newly created event (tAct.iActId).</param>",
            "/// <param name=\"personId\">The ID of the user (tPerson.iPersonId) who executed the event on the ticket. In some cases it could be the system, then the value is NULL.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnActRemoved\"/>",
            "void OnActRemoved(SqlConnection con, SqlTransaction trans, int actId, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchITicketApprovalAutoAction(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "ITicketApprovalAutoAction", string.Join("\n", [
            "/// <summary>",
            "/// You can define custom actions by implementing the ITicketApprovalAutoAction interface in application scripts.",
            "/// Automatic actions are only called for manually triggered approvals with automatic status transition disabled.",
            "/// In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.",
            "/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.",
            "/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/ticket-approval-custom-actions",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Properties.Add("public string Name { get; set; }");
        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on ticket approval. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the ongoing database transaction.</param>",
            "/// <param name=\"ticketId\">Ticket ID (tHdTicket.iHdTicketId)..</param>",
            "/// <param name=\"approvalItemIds\">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnApproved\"/>",
            "void OnApproved(SqlConnection con, SqlTransaction trans, int ticketId, int approvalItemId);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on the approval of the ticket rejection. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the ongoing database transaction.</param>",
            "/// <param name=\"ticketId\">Ticket ID (tHdTicket.iHdTicketId)..</param>",
            "/// <param name=\"approvalItemIds\">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnApproverAdded\"/>",
            "void OnApproverAdded(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>Custom action based on the removal of the ticket approver. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the ongoing database transaction.</param>",
            "/// <param name=\"ticketId\">Ticket ID (tHdTicket.iHdTicketId)..</param>",
            "/// <param name=\"approvalItemIds\">List of approval step IDs (tHdTicketApprovalItem.iHdTicketApprovalItemId).</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnApproverCanceled\"/>",
            "void OnApproverCanceled(SqlConnection con, SqlTransaction trans, int ticketId, IEnumerable<int> approvalItemIds);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIMailMessageAutoAction(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IMailMessageAutoAction", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the IMailMessageAutoAction interface in the application script you can define custom actions when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the newly created script, set the value of the Name property (the name of the automatic action) in the action class constructor.",
            "/// Tip: To store properties and action settings, we recommend defining the Settings class in a separate script that you create from the Class Library template.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-sd-custom-apps/applications/ticket-custom-actions-by-events/mail-message-custom-actions",
            Usings = ["Microsoft.Data.SqlClient", "Rebex.Mail"],
        };

        clazz.Properties.Add("public string Name { get; set; }");
        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>The actual action can be performed when loading a message from the service mailbox before saving the message to the log of an existing ticket or before creating a new ticket. In the implemented method, define both the conditions for executing the operations and the operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"trans\">SqlTransaction of the ongoing database transaction.</param>",
            "/// <param name=\"message\">message object.</param>",
            "/// <param name=\"sectionId\">the service ID (tHdSection.iSectionId) which the message was loaded to.</param>",
            "/// <param name=\"ticketId\">ID of the ticket (tHdTicket.iHdTicketId) to which the message belongs according to the subject, or zero if it is a new ticket creation.</param>",
            "/// <param name=\"fromPersonId\">message sender ID (tPerson.iPersonId), or Host account, if the message sender is not found among the users.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnMessageReceived\"/>",
            "bool OnMessageReceived(SqlConnection con, SqlTransaction trans, MailMessage message, int sectionId, int ticketId, int fromPersonId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIPeriodicActions(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IPeriodicAction", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the IPeriodicAction interface in a application script, you can define custom periodic actions.",
            "/// Custom actions can be run at a regular time interval.",
            "/// The system runs periodic custom actions every hour.",
            "///",
            "/// In the application, create a new script using the IPeriodicAction template and name it appropriately according to the functionality that the action performs.",
            "/// In the newly created script, set the value of the Name property (the name of the action itself) in the class constructor.",
            "///",
            "/// Caution: Poor definition of a custom action can irreversibly damage the Alvao database, so always create and test actions in a test environment, e.g. on a copy of the production database.",
            "/// Tip: A prerequisite for creating a working automated action is a good knowledge of Alvao database and Alvao.API.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-am-custom-apps/applications/periodic-custom-actions",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Properties.Add("public string Name { get; set; }");
        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>In the method, define both the conditions for performing the operations and the operations themselves.</summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnPeriod\"/>",
            "void OnPeriod(SqlConnection con);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIEntityCommand(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IEntityCommand", string.Join("\n", [
            "/// <summary>",
            "/// By implementing this interface, you can define custom commands for an object or a ticket. For an example, see the CostsCalculation application template.",
            "/// In the application, create a new script using the IEntityCommand template and name it appropriately according to the functionality of the custom command.",
            "/// In the newly created script, set the following properties in the constructor of the class:",
            "///    Id - a unique command identifier (string)",
            "///    Entity - the type of entity for which the command will be displayed(Entity.Ticket or Entity.Object).",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-am-custom-apps/applications/i-entity-command",
            Usings = ["Alvao.API.Common.Model.CustomApps"],
        };

        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Properties.Add("public string Id { get; set; }");
        clazz.Properties.Add("public Entity Entity { get; set; }");
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method controls display of the command in command menus",
            "///",
            "/// Tip: By calling this method in the Run method, you can check if the conditions for displaying the command haven't changed between the time of displaying the command and running it.",
            "/// </summary>",
            "///",
            "/// <param name=\"entityId\">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed.</param>",
            "/// <param name=\"personId\">the ID of the user (tPerson.iPersonId) to whom the command should be displayed.\">SqlConnection to the database.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#Show\"/>",
            "EntityCommandShowResult Show(int entityId, int personId);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method implements the command itself.",
            "///",
            "/// Tip: If the custom command is to open another Alvao WebApp page, use the Alvao.API.Common.DbProperty.WebAppUrl property from the Alvao.API to get the root URL of the WebApp.",
            "/// </summary>",
            "///",
            "/// <param name=\"entityId\">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed.</param>",
            "/// <param name=\"personId\">the ID of the user (tPerson.iPersonId) to whom the command should be displayed.\">SqlConnection to the database.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#Run\"/>",
            "CommandResult Run(int entityId, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIEntityTab(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IEntityTab", string.Join("\n", [
            "/// <summary>",
            "/// By implementing this interface, you can define custom tabs on the object or ticket page. A custom tab can view any web content displayable in an iframe tag. For an example, see the ShowRequesterAddress application template.",
            "/// ",
            "/// In the application create a new script using the IElementTab template and name it appropriately according to the content of the tab. In the newly created script, set the following properties in the constructor of the class:",
            "///     Id - a unique tab identifier (string)",
            "///     Entity - the type of entity for which the tab will be displayed (Entity.Ticket or Entity.Object).",
            "/// By implementing this interface, you can define custom commands for an object or a ticket. For an example, see the CostsCalculation application template.",
            "/// In the application, create a new script using the IEntityCommand template and name it appropriately according to the functionality of the custom command.",
            "/// In the newly created script, set the following properties in the constructor of the class:",
            "///    Id - a unique command identifier (string)",
            "///    Entity - the type of entity for which the command will be displayed(Entity.Ticket or Entity.Object).",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-am-custom-apps/applications/i-entity-tab",
            Usings = ["Alvao.API.Common.Model.CustomApps"],
        };

        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Properties.Add("public string Id { get; set; }");
        clazz.Properties.Add("public Entity Entity { get; set; }");
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method handles the display of the entity custom tab.",
            "///",
            "/// Tip: If the custom tab is to display a different page from the Alvao WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the Alvao.API interface to get the root URL.",
            "/// </summary>",
            "///",
            "/// <param name=\"entityId\">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the custom tab should be displayed.</param>",
            "/// <param name=\"personId\">the ID of the user (tPerson.iPersonId) to whom the command should be displayed.\">SqlConnection to the database.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#Show\"/>",
            "EntityTabShowResult Show(int entityId, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIGeneralCommand(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IGeneralCommand", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the IGeneralCommand interface in a application script, you can define custom main menu commands.",
            "///",
            "/// By placing a command in the main menu, you can give users access to frequently used pages and operations that are not tied to a specific ticket in ALVAO Service Desk or Asset Management function.",
            "/// Commands are displayed in the main menu of the Alvao WebApp application.",
            "/// In the Service Desk or Asset Management application, create a new script using the IGeneralCommand template and name it appropriately according to the functionality of the custom command.",
            "/// In the newly created script, set the id, name, position, and icon property values in the constructor of the command class:",
            "///    id - command number (unique)",
            "///    name - the name of the command that will be displayed in applications",
            "///    position - the position at which the command will be displayed in applications",
            "///        1 = in main menu under system commands",
            "///        2 = in the main menu above the More menu",
            "///        3 = in the main menu in the More menu above the Administration system command",
            "///        4 = in the user menu above the Settings system command",
            "///    icon - the name of the command icon",
            "///        Use the icon name from the Microsoft Fabric library as the command icon name (the icon name will appear on the page when you hover over the selected icon). If you do not specify an icon, the LightningBolt icon is used.",
            "///",
            "/// Tip: To store the properties and settings of the command, we recommend defining the Settings class in a separate script that you create from the Class Library template.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-am-custom-apps/applications/general-custom-commands",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method checks the defined conditions for displaying the command.",
            "///",
            "/// Tip: By calling this method in the Run method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.",
            "/// </summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"personId\">User ID (tPerson.iPersonId) to which the command should be displayed.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#Show\"/>",
            "bool Show(SqlConnection con, int personId);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method runs the command itself.",
            "///",
            "/// Tip: If the custom command is to open a different page from the Alvao WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the Alvao.API interface to get the root URL.",
            "/// </summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"personId\">The user ID (tPerson.iPersonId) that runs the command.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#Show\"/>",
            "Tuple<bool, string, string> Run(SqlConnection con, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIObjectMoveAutoAction(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IObjectMoveAutoAction", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the IObjectMoveAutoAction interface in an application script, you can define custom actions that are automatically performed when an object is moved to another location in the object tree, including removing the object to the Trash.",
            "/// ",
            "/// Note: The interface methods are also called in the Alvao.API.AM.Object.Move and Alvao.API.AM.Object.Delete methods. When automatically removing computer components to the Recycle Bin based on hw detection, the methods are not called.",
            "///",
            "/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException()",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method checks the defined conditions for displaying the command.",
            "///",
            "/// Tip: By calling this method in the Run method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.",
            "/// </summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"objectId\">ID of the object (tblNode.intNodeId) to be moved.</param>",
            "/// <param name=\"newParentObjectId\">ID of the object (tblNode.intNodeId) to which the object is to be moved. A value of 0 means that the object will be moved to the root of the tree.</param>",
            "/// <param name=\"personId\">the ID of the user (tPerson.iPersonId) who invoked the action.\">SqlConnection to the database.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnObjectMoving\"/>",
            "Tuple<bool, string> OnObjectMoving(SqlConnection con, int objectId, int newParentObjectId, int personId);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method is called after moving an object in the tree.",
            "/// </summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"objectId\">ID of the object (tblNode.intNodeId) to be moved.</param>",
            "/// <param name=\"oldParentObjectId\">the ID of the object (tblNode.intNodeId) that was the father (parent object) of the object with objectId before it was moved. A value of 0 means that the object was moved from the root of the tree.</param>",
            "/// <param name=\"personId\">the user ID (tPerson.iPersonId) that triggered the action.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnObjectMoved\"/>",
            "void OnObjectMoved(SqlConnection con, int objectId, int oldParentObjectId, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    public static void MonkeyPatchIObjectPropertyAutoAction(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "IObjectPropertyAutoAction", string.Join("\n", [
            "/// <summary>",
            "/// By implementing the IObjectPropertyAutoAction interface in a application script, you can define custom actions that are automatically performed when the user manually modifies the value of an object property.",
            "/// ",
            "/// Note: Interface methods are also called in both variants of the Alvao.API.AM.ObjectProperty.Update method. The AM Console command - Properties tab - Generate Value does not call the OnObjectPropertyModifying method. It only calls the OnObjectPropertyModified method.",
            "///",
            "/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.",
            "/// </summary>",
        ]))
        {
            FullUrl = $"https://doc.alvao.com/en/{Helpers.ALVAO_VERSION_DOT}/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change",
            Usings = ["Microsoft.Data.SqlClient"],
        };

        clazz.Definition = $"public interface {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method checks the defined conditions for displaying the command.",
            "///",
            "/// Tip: By calling this method in the Run method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.",
            "/// </summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"propertyId\">ID of the property (tblProperty.intPropertyId) that is being modified.</param>",
            "/// <param name=\"personId\">the ID of the user (tPerson.iPersonId) who invoked the action.\">SqlConnection to the database.</param>",
            "/// <param name=\"newValue\">new value of the property.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnObjectPropertyModifying\"/>",
            "Tuple<bool, string> OnObjectPropertyModifying(SqlConnection con, int propertyId, int personId, string newValue);"
        ]));
        clazz.Methods.Add(string.Join("\n", [
            "/// <summary>",
            "/// This method is called after writing a new property value to the database, e.g. by the Modify (property) statement.",
            "/// </summary>",
            "///",
            "/// <param name=\"con\">SqlConnection to the database.</param>",
            "/// <param name=\"propertyId\"> ID of the property (tblProperty.intPropertyId) that has been changed.</param>",
            "/// <param name=\"personId\">the user ID (tPerson.iPersonId) that triggered the action.</param>",
            "///",
            $"/// <see href=\"{clazz.FullUrl}#OnPropertyModified\"/>",
            "void OnPropertyModified(SqlConnection con, int propertyId, int personId);"
        ]));
        clazz.ProduceFinalCsFile();
    }

    private static void MonkeyPatchInternalUserToken(string ns)
    {
        var clazz = new AlvaoClass(true, ns, "UserToken", string.Join("\n", [
            "/// CAUTION: This class was heavily guessed based on the usage seen on some custom apps.",
        ]));

        clazz.Definition = $"public class {clazz.Name}";
        clazz.Methods.Add(string.Join("\n", [
            "public static string GetToken(int personId, string scope) { throw new System.NotImplementedException(); }"
        ]));
        clazz.ProduceFinalCsFile();
    }
}
