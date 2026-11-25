namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html"/>
public class AzureAISearchEntity {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_ChunkId"/>
    public int ChunkId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_EntityId"/>
    public required int EntityId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_EntityType"/>
    public required AzureAISearchEntityType EntityType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_Id"/>
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_ModelId"/>
    public required int ModelId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_ServiceId"/>
    public int ServiceId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_Vector"/>
    public required IEnumerable<float> Vector { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AzureAISearchEntity.html#Alvao_API_Common_Model_AzureAISearchEntity_UpdateId"/>
    public void UpdateId() { throw new NotImplementedException(); }
}
