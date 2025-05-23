namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectHistoryModel.htm"/>
public class ObjectHistoryModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectHistoryModel_EHistoryFlag.htm"/>
    public enum EHistoryFlag {
        HistfMoveDest = 1,
        HistfMoveSrc = 2,
        HistfTo = 3,
        HistfInsertNew = 4,
        HistfToNew = 5,
        HistfShift = 8,
        HistfMask = 65_280,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_DetectId.htm"/>
    public int DetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_Flags.htm"/>
    public int Flags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_ObjectId.htm"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_Op2ObjectId.htm"/>
    public int? Op2ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_Op2ObjectName.htm"/>
    public string Op2ObjectName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_OpObjectId.htm"/>
    public int? OpObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_OpObjectName.htm"/>
    public string OpObjectName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectHistoryModel_PersonId.htm"/>
    public int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectHistoryModel__ctor.htm"/>
    public ObjectHistoryModel() { }
}
