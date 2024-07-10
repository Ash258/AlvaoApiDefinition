using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Settings
{
    // EmailSendingOnTicketCreation.cs
    public const int SD_SECTION_NAME = 123;
    public const string SD_BASE_URL = "https://tenant.onalvao.com/Alvao/Ticket/";
    public const string AM_RECIPIENTS_TO = "example@example.com";

    // CostsClaculation.cs
    public const string CommandName = "Calculate the total cost of SW and HW";
    public const int CommandPosition = 1;
    public const string CommandIcon = "Calculator";
    public const int StateId = 94; // The ID of the status in which the request is to be displayed.
    public const int ServiceId = 37; // The ID of the service in which the request should be displayed.

    // TicketShowRequesterAddress.cs
    public const string TabName = "Show requester's address";

    // ReportProblem.cs
    public const int CommandId = 2;
    public const string ProblemServiceCatalogUrl = "/NewTicket/SectionCatalog/1";

    // CheckObjectMandatoryProperties.cs
    public static readonly int ObjectClassToCheckId = (int)Alvao.API.AM.Model.ObjectClass.Code.Warehouse; // Object class ID.
    public static readonly string ErrorMessage = "Fill in all mandatory properties of the object before moving from the warehouse."; // Error message.

    // SetComputerDetectionProfile.cs
    public static readonly int movedObjectClassIdToCheck = (int)Alvao.API.AM.Model.ObjectClass.Code.Computer; // Object class ID of the moved object.
    public static readonly int oldParentobjectClassId = (int)Alvao.API.AM.Model.ObjectClass.Code.Warehouse; // Was moved object somewhere under the object of this Object class ID?
    public static readonly string detectionProfileName = "Standard"; // Name of the detection profile in database.

    // UpdateSuperiorGroupPeriodic.cs
    public const int UPDATE_HOUR = 2;
    public const string ORGANIZATION_NAME = "";
    public const string SUPERIOR_GROUP_NAME = "";

    // EntityTab.cs
    public const string CMD_TabName = "CMDB diagram";
    public static int[] SupportedServices = { }; // List of supported services separated by a comma. Example: { 1, 2 }

    // OpenAttachments.cs
    public const string OA_CommandName = "Open Attachments";
    public const int OA_CommandPosition = 1;
    public const string OA_CommandIcon = "OpenFile";
    public const string AttachmentsCustomColumnName = "Attachments";

    // SectionKnowledges.cs
    // public static readonly int[] SupportedServices = null;
    public const string SK_TabName = "Knowledge Base";

    // TicketCreateTaskInToDoCommand.cs
    // TicketCreateOutlookMeetingCommand.cs
    private static int subjectMaxLength = 150;
    private static string dots = "...";

    public static string GetSubject(string name, string tag)
    {
        string ticketFullName;
        if (name.Length > subjectMaxLength)
        {
            name = $"{name.Trim().Substring(0, subjectMaxLength - 1)}";
            ticketFullName = $"{name}{dots} ({tag})";
        }
        else
        {
            ticketFullName = $"{name} ({tag})";
        }

        return ticketFullName;
    }

    // AssignToSolverByEmail.cs
    public const string ATSBE_ActionName = "Assign to the solver via e-mail";

    // AssignToTester.cs
    public const string ATT_ActionName = "Resolved in the version - pass to the test";
    public const string ATT_ServiceName = "Program modifications"; // Name of the service in which the request should be passed to Testers.
    public const int ATT_ControlStateId = 1; // Status ID in which the request should be passed to the Testers.
    public const string ATT_SolverGroupName = "Testers";

    // TicketAutoClose.cs
    public static readonly List<int> TAC_Hours = new List<int>() { 0, 12 };

    // SendMailsAboutNewEvent.cs
    public static string SMANE_ActionName = "New note – send e-mails";
    public static string SMANE_ServiceName = "Program modifications"; // The name of the service on which request the event will be created.

    // OrderAfterApproval.cs
    public static string OAA_ActionName = "OrderAfterApproval";
    public static string OAA_ServiceName = "Purchase"; // The name of the service where the approval is taking place
    public static string OAA_State = "Purchase approval"; // The name of the status where the approval is taking place.
    public static string OAA_TargetState = "Order"; // The name of the status to enter after approval.

    // CheckPhoneNumberFormat.cs
    public static readonly string CPNF_propName = "Phone Number"; // Specify the property name you want to check.
    public static readonly Regex CPNF_rx = new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", RegexOptions.Compiled | RegexOptions.IgnoreCase); // Phone number format in regex.
    public static readonly string CPNF_errorMessage = "The value you entered is not a phone number. Enter the phone number in the correct format, etc. +(039) 123 456 789."; // Error message if the new value is not in correct format.

    // Do not change this value.
    public static bool CPNF_isPhoneNumber = false;

    // TeamsWithUserCommand.cs
    public const bool TWUC_TargetState = false;

    // DeclineMessageSendCustomNotification.cs
    // Example of mail message.
    public static string DMSCN_MailMessageCzech =
        "Dobrý den, \r\n\r\n" +
        "odeslali jste zprávu na adresu, která slouží pouze pro komunikaci v rámci řešení požadavků v systému ALVAO.\r\n" +
        "Pro založení požadavku/nahlášení incidentu přejděte prosím na: https://servicedesk.contoso.com/Alvao/\r\n" +
        "V případě, že potřebujete kontaktovat oddělení, které má tuto oblast na starosti, použijte prosím kontakty dostupné na intranetu.\r\n\r\n" +
        "Děkujeme za pochopení,\r\n" +
        "Tým ALVAO SD \r\n\r\n\r\n";

    public static string DMSCN_MailMessageEnglish =
        "Hello, \r\n\r\n" +
        "You have sent a message to an address that is only used for communication within the ALVAO system.\r\n" +
        "To create a request/incident report, please go to: https://servicedesk.contoso.com/Alvao/\r\n" +
        "In case you need to contact the department in charge of this area, please use the contacts available on the intranet.\r\n\r\n" +
        "Thank you for your understanding,\r\n" +
        "ALVAO SD team \r\n\r\n\r\n";

    // CreateAnalysis.cs
    public const string CA_ActionName = "Create project request";
    public const string CA_ServiceName = "Program modifications"; // The name of the service in which the new request is being created.
    public const string CA_AnalysisServiceName = "Program modifications/Designs and analyses"; // The name of the service to which the request for the created request is to be created.

    // CopyNewPropertyValueToAnotherProperty.cs
    public static readonly string CNPVTAP_UpdatedPropertyName = "Phone number"; // Which property value was updated.
    public static readonly string CNPVTAP_ServiceName = "Phone"; // Which property kind will be updated.
}
