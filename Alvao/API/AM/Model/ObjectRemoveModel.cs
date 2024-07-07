namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectRemoveModel.htm"/>
public class ObjectRemoveModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRemoveModel_IsInTrash.htm"/>
    public bool IsInTrash { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRemoveModel_IsResponsible.htm"/>
    public bool IsResponsible { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRemoveModel_IsTemplate.htm"/>
    public bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRemoveModel_IsUsedOnLicense.htm"/>
    public bool IsUsedOnLicense { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRemoveModel_Name.htm"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ObjectRemoveModel_ObjectId.htm"/>
    public int ObjectId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectRemoveModel__ctor.htm"/>
    public ObjectRemoveModel() { }
}
