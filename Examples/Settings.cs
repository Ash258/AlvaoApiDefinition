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
}
