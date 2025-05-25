namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomGeneralCommandRequest.html"/>
public class RunCustomGeneralCommandRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomGeneralCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomGeneralCommandRequest_CommandId"/>
    public int CommandId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomGeneralCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomGeneralCommandRequest_PersonId"/>
    public int PersonId { get; set; }
}
