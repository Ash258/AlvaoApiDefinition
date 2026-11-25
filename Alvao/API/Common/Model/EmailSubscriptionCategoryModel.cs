namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionCategoryModel.html"/>
public class EmailSubscriptionCategoryModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionCategoryModel.html#Alvao_API_Common_Model_EmailSubscriptionCategoryModel_Category"/>
    public EmailSubscriptionsType Category { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionCategoryModel.html#Alvao_API_Common_Model_EmailSubscriptionCategoryModel_Subscribers"/>
    public List<EmailSubscriptionModel> Subscribers { get; set; }
}
