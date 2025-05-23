namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnTicketChangedRequest.html"/>
public class OnTicketChangedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnTicketChangedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnTicketChangedRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnTicketChangedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnTicketChangedRequest_Properties"/>
    public string Properties { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnTicketChangedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnTicketChangedRequest_TicketId"/>
    public int TicketId { get; set; }

}
