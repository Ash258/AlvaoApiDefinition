namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html"/>
public class EmailSubscriptionModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_Email"/>
    public string Email { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_EmailSubscriptionTypeId"/>
    public EmailSubscriptionsType EmailSubscriptionTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_PersonId"/>
    public int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_PortraitHash"/>
    public string PortraitHash { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionModel.html#Alvao_API_Common_Model_EmailSubscriptionModel_RoleId"/>
    public int? RoleId { get; set; }
}
