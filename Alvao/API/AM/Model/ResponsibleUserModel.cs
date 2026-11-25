namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ResponsibleUserModel.html"/>
public class ResponsibleUserModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ResponsibleUserModel.html#Alvao_API_AM_Model_ResponsibleUserModel_HasAssetAssignmentStatus"/>
    public bool HasAssetAssignmentStatus { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ResponsibleUserModel.html#Alvao_API_AM_Model_ResponsibleUserModel_IsInWarehouse"/>
    public bool IsInWarehouse { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ResponsibleUserModel.html#Alvao_API_AM_Model_ResponsibleUserModel_ObjectId"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ResponsibleUserModel.html#Alvao_API_AM_Model_ResponsibleUserModel_PersonId"/>
    public int? PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ResponsibleUserModel.html#Alvao_API_AM_Model_ResponsibleUserModel__ctor"/>
    public ResponsibleUserModel() { }
}
