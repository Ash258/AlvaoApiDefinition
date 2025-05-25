namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomEntityCommandRequest.html"/>
public class RunCustomEntityCommandRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomEntityCommandRequest_CommandId"/>
    public string CommandId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomEntityCommandRequest_Entity"/>
    public Entity Entity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomEntityCommandRequest_EntityId"/>
    public int EntityId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.RunCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_RunCustomEntityCommandRequest_PersonId"/>
    public int PersonId { get; set; }
}
