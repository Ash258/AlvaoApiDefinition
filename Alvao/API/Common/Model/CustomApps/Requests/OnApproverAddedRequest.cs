namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApproverAddedRequest.html"/>
public class OnApproverAddedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApproverAddedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnApproverAddedRequest_ApprovalItemIds"/>
    public int[] ApprovalItemIds { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnApproverAddedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnApproverAddedRequest_TicketId"/>
    public int TicketId { get; set; }

}
