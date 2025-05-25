namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActCreatedRequest.html"/>
public class OnActCreatedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActCreatedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActCreatedRequest_ActId"/>
    public int ActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActCreatedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActCreatedRequest_PersonId"/>
    public int PersonId { get; set; }
}
