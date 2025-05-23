namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html"/>
public class OnObjectPropertyModifiedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_ObjectId"/>
    public int ObjectId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_PropertyKindId"/>
    public int PropertyKindId { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest__ctor"/>
    public OnObjectPropertyModifiedRequest() { }
    /// <param name="objectId"></param>
    /// <param name="propertyKindId"></param>
    /// <param name="personId"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest__ctor_System_Int32_System_Int32_System_Int32_"/>
    public OnObjectPropertyModifiedRequest(int objectId, int propertyKindId, int personId) { }
}
