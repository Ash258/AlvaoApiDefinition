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
}
