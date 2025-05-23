namespace Alvao.API.Common.Model.CustomApps;

/// <summary>Object Property Modify auto action model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyModifyResult.html"/>
public class ObjectPropertyModifyResult {
    /// <summary>Message for user</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyModifyResult.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyModifyResult_Message"/>
    public string Message { get; set; }

    /// <summary>Indication for auto action success</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyModifyResult.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyModifyResult_Success"/>
    public bool Success { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyModifyResult.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyModifyResult__ctor"/>
    public ObjectPropertyModifyResult() { }
    /// <param name="success"></param>
    /// <param name="message"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyModifyResult.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyModifyResult__ctor_System_Boolean_System_String_"/>
    public ObjectPropertyModifyResult(bool success, string message) { }
}
