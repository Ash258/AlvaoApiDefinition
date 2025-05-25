namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActRemovedRequest.html"/>
public class OnActRemovedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActRemovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActRemovedRequest_ActId"/>
    public int ActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActRemovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActRemovedRequest_PersonId"/>
    public int PersonId { get; set; }
}
