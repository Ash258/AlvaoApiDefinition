namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityCommandRequest.html"/>
public class GetCustomEntityCommandRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityCommandRequest_Entity"/>
    public Entity Entity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityCommandRequest_EntityId"/>
    public int EntityId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityCommandRequest_Id"/>
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityCommandRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityCommandRequest_PersonId"/>
    public int PersonId { get; set; }
}
