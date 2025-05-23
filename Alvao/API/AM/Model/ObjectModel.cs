namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectModel.htm"/>
public class ObjectModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectModel_ClassCode.htm"/>
    public int? ClassCode { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectModel_IsComputer.htm"/>
    public bool IsComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectModel_ObjectId.htm"/>
    public int ObjectId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectModel__ctor.htm"/>
    public ObjectModel() { }
}
