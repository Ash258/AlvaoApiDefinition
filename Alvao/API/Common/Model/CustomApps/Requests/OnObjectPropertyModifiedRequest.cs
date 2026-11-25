namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html"/>
public class OnObjectPropertyModifiedRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_NewValue"/>
    public object NewValue { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_ObjectId"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_PersonId"/>
    public int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest_PropertyKindId"/>
    public int PropertyKindId { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest__ctor"/>
    public OnObjectPropertyModifiedRequest() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifiedRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifiedRequest__ctor_System_Int32_System_Int32_System_Int32_System_Object_"/>
    public OnObjectPropertyModifiedRequest(int objectId, int propertyKindId, int personId, object newValue = null) { }
}
