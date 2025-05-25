namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovingRequest.html"/>
public class OnObjectMovingRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectMovingRequest_NewParentObjectId"/>
    public int NewParentObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectMovingRequest_ObjectId"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectMovingRequest_PersonId"/>
    public int PersonId { get; set; }
}
