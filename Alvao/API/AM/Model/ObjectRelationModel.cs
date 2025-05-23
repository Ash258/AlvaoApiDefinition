namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectRelationModel.htm"/>
public class ObjectRelationModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRelationModel_BeginObjectName.htm"/>
    public string BeginObjectName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRelationModel_BeginRelationName.htm"/>
    public string BeginRelationName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRelationModel_EndObjectName.htm"/>
    public string EndObjectName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRelationModel_EndRelationName.htm"/>
    public string EndRelationName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRelationModel_RelationFullName.htm"/>
    public string RelationFullName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectRelationModel__ctor.htm"/>
    public ObjectRelationModel() { }
}
