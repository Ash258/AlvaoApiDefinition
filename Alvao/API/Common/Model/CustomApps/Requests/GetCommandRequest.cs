namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCommandRequest.html"/>
public class GetCommandRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCommandRequest_CommandId"/>
    public int CommandId { get; set; }
}
