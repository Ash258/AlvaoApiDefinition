namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html"/>
public class AzureAISearchEntitySetting {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html#Alvao_API_Common_Model_AzureAISearchEntitySetting_EntityType"/>
    public AzureAISearchEntityType? EntityType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html#Alvao_API_Common_Model_AzureAISearchEntitySetting_ModelId"/>
    public int ModelId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html#Alvao_API_Common_Model_AzureAISearchEntitySetting_ServiceId"/>
    public int? ServiceId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html#Alvao_API_Common_Model_AzureAISearchEntitySetting_SimilarityPercent"/>
    public double? SimilarityPercent { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html#Alvao_API_Common_Model_AzureAISearchEntitySetting_Top"/>
    public int Top { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntitySetting.html#Alvao_API_Common_Model_AzureAISearchEntitySetting_Vector"/>
    public float[] Vector { get; set; }
}
