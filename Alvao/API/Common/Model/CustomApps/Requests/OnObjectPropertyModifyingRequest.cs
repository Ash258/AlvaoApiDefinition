namespace Alvao.API.Common.Model.CustomApps.Requests;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html"/>
public class OnObjectPropertyModifyingRequest : BaseRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifyingRequest_NewValue"/>
    public object NewValue { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifyingRequest_ObjectId"/>
    public int ObjectId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifyingRequest_PersonId"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifyingRequest_PropertyKindId"/>
    public int PropertyKindId { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifyingRequest__ctor"/>
    public OnObjectPropertyModifyingRequest() { }
    /// <param name="objectId"></param>
    /// <param name="propertyKindId"></param>
    /// <param name="personId"></param>
    /// <param name="newValue"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Requests.OnObjectPropertyModifyingRequest.html#Alvao_API_Common_Model_CustomApps_Requests_OnObjectPropertyModifyingRequest__ctor_System_Int32_System_Int32_System_Int32_System_Object_"/>
    public OnObjectPropertyModifyingRequest(int objectId, int propertyKindId, int personId, object newValue) { }
}
