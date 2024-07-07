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

        return namespaceName switch
        {
            "Alvao.API.AM.Model" => className.Equals("ImportCsvSettings") && property.Equals("TextOutput"),
            "Alvao.Context" => new string[] { "AlvaoContext", "CustomApps" }.Contains(className) && property.Equals("DbContextProvider"),
            _ => false,
        };
    }
}
