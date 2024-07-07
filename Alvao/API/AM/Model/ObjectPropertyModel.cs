namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectPropertyModel.htm"/>
public class ObjectPropertyModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_GlobalScope.htm"/>
    public int GlobalScope { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_Id.htm"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_IsInheritable.htm"/>
    public bool IsInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_KindId.htm"/>
    public int KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_Name.htm"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_NameOrder.htm"/>
    public int NameOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectPropertyModel_Value.htm"/>
    public string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectPropertyModel__ctor.htm"/>
    public ObjectPropertyModel() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectPropertyModel_ToUpdateObjectPropertyModel.htm"/>
    public UpdateObjectPropertyModel ToUpdateObjectPropertyModel() { throw new System.NotImplementedException(); }
}
