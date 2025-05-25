namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnMessageReceivedRequest.html"/>
public class OnMessageReceivedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnMessageReceivedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnMessageReceivedRequest_FromPersonId"/>
    public int FromPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnMessageReceivedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnMessageReceivedRequest_MessageId"/>
    public int MessageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnMessageReceivedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnMessageReceivedRequest_SectionId"/>
    public int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnMessageReceivedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnMessageReceivedRequest_TicketId"/>
    public int TicketId { get; set; }
}
