namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetTicketCustomViewsRequest.html"/>
public class GetTicketCustomViewsRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetTicketCustomViewsRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetTicketCustomViewsRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetTicketCustomViewsRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetTicketCustomViewsRequest_TicketId"/>
    public int TicketId { get; set; }

}
