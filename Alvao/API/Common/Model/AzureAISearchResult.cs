namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchResult.html"/>
public class AzureAISearchResult {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchResult.html#Alvao_API_Common_Model_AzureAISearchResult_Document"/>
    public AzureAISearchEntity Document { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchResult.html#Alvao_API_Common_Model_AzureAISearchResult_Score"/>
    public double Score { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchResult.html#Alvao_API_Common_Model_AzureAISearchResult_Similarity"/>
    public double Similarity { get; set; }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchResult.html#Alvao_API_Common_Model_AzureAISearchResult_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new NotImplementedException(); }
}
