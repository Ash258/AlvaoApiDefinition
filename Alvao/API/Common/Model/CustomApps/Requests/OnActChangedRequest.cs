namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActChangedRequest.html"/>
public class OnActChangedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActChangedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActChangedRequest_ActId"/>
    public int ActId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActChangedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActChangedRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnActChangedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnActChangedRequest_Properties"/>
    public string Properties { get; set; }

}
