namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApprovedRequest.html"/>
public class OnApprovedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApprovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnApprovedRequest_ApprovalItemId"/>
    public int ApprovalItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApprovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnApprovedRequest_TicketId"/>
    public int TicketId { get; set; }
}
