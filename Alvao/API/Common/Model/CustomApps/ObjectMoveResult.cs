namespace Alvao.API.Common.Model.CustomApps;

/// <summary>Object Move auto action model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectMoveResult.html"/>
public class ObjectMoveResult {
    /// <summary>Message for user</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectMoveResult.html#Alvao_API_Common_Model_CustomApps_ObjectMoveResult_Message"/>
    public string Message { get; set; }

    /// <summary>Indication for auto action success</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectMoveResult.html#Alvao_API_Common_Model_CustomApps_ObjectMoveResult_Success"/>
    public bool Success { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectMoveResult.html#Alvao_API_Common_Model_CustomApps_ObjectMoveResult__ctor"/>
    public ObjectMoveResult() { }
    /// <param name="success"></param>
    /// <param name="message"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectMoveResult.html#Alvao_API_Common_Model_CustomApps_ObjectMoveResult__ctor_System_Boolean_System_String_"/>
    public ObjectMoveResult(bool success, string message) { }
}
