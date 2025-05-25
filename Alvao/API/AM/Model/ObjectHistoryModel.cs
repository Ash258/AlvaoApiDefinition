namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html"/>
public class ObjectHistoryModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.EHistoryFlag.html#fields"/>
    public enum EHistoryFlag {
        HistfMoveDest = 1,
        HistfMoveSrc = 2,
        HistfTo = 3,
        HistfInsertNew = 4,
        HistfToNew = 5,
        HistfShift = 8,
        HistfMask = 65280,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_DetectId"/>
    public int DetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_Flags"/>
    public int Flags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_ObjectId"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_Op2ObjectId"/>
    public int? Op2ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_Op2ObjectName"/>
    public string Op2ObjectName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_OpObjectId"/>
    public int? OpObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_OpObjectName"/>
    public string OpObjectName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectHistoryModel.html#Alvao_API_AM_Model_ObjectHistoryModel_PersonId"/>
    public int PersonId { get; set; }
}
