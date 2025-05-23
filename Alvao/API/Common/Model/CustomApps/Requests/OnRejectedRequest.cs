namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnRejectedRequest.html"/>
public class OnRejectedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnRejectedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnRejectedRequest_ApprovalItemId"/>
    public int ApprovalItemId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnRejectedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnRejectedRequest_TicketId"/>
    public int TicketId { get; set; }

}
