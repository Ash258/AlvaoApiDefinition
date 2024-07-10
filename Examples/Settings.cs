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
}
