namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionsModel.html"/>
public class EmailSubscriptionsModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionsModel.html#Alvao_API_Common_Model_EmailSubscriptionsModel_ProductUpdates"/>
    public EmailSubscriptionCategoryModel ProductUpdates { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.EmailSubscriptionsModel.html#Alvao_API_Common_Model_EmailSubscriptionsModel_ServiceAndTechnical"/>
    public EmailSubscriptionCategoryModel ServiceAndTechnical { get; set; }
}
