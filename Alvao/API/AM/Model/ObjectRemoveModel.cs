namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html"/>
public class ObjectRemoveModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_ClassId"/>
    public int ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_IsInTrash"/>
    public bool IsInTrash { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_IsResponsible"/>
    public bool IsResponsible { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_IsTemplate"/>
    public bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_IsUsedOnLicense"/>
    public bool IsUsedOnLicense { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRemoveModel.html#Alvao_API_AM_Model_ObjectRemoveModel_ObjectId"/>
    public int ObjectId { get; set; }
}
