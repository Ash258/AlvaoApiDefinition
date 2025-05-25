namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApproverCanceledRequest.html"/>
public class OnApproverCanceledRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApproverCanceledRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnApproverCanceledRequest_ApprovalItemIds"/>
    public int[] ApprovalItemIds { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApproverCanceledRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnApproverCanceledRequest_TicketId"/>
    public int TicketId { get; set; }
}
