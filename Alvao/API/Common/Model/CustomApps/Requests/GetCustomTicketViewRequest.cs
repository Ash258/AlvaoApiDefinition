namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomTicketViewRequest.html"/>
public class GetCustomTicketViewRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomTicketViewRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomTicketViewRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomTicketViewRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomTicketViewRequest_TicketId"/>
    public int TicketId { get; set; }

}
