namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomTicketCommandRequest.html"/>
public class RunCustomTicketCommandRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomTicketCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomTicketCommandRequest_CommandId"/>
    public int CommandId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomTicketCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomTicketCommandRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomTicketCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomTicketCommandRequest_TicketId"/>
    public int TicketId { get; set; }

}
