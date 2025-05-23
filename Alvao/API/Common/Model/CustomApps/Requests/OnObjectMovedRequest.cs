namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovedRequest.html"/>
public class OnObjectMovedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectMovedRequest_ObjectId"/>
    public int ObjectId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectMovedRequest_OldParentObjectId"/>
    public int OldParentObjectId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectMovedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectMovedRequest_PersonId"/>
    public int PersonId { get; set; }

}
