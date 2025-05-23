namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_UpdateObjectPropertyModel.htm"/>
public class UpdateObjectPropertyModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UpdateObjectPropertyModel_Id.htm"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UpdateObjectPropertyModel_IsInheritable.htm"/>
    public bool IsInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UpdateObjectPropertyModel_KindId.htm"/>
    public int KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_UpdateObjectPropertyModel_Value.htm"/>
    public string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_UpdateObjectPropertyModel__ctor.htm"/>
    public UpdateObjectPropertyModel() { }
}
