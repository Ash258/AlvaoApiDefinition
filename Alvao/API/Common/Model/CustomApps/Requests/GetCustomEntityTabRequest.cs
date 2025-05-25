namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityTabRequest.html"/>
public class GetCustomEntityTabRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityTabRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityTabRequest_Entity"/>
    public Entity Entity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityTabRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityTabRequest_EntityId"/>
    public int EntityId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.GetCustomEntityTabRequest.html#Alvao_API_Common_Model_CustomApps_Requests_GetCustomEntityTabRequest_PersonId"/>
    public int PersonId { get; set; }
}
