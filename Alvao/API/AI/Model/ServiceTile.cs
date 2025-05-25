namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ServiceTile.html"/>
public class ServiceTile : SimilarEntity, ISimilarEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ServiceTile.html#Alvao_API_AI_Model_ServiceTile_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ServiceTile.html#Alvao_API_AI_Model_ServiceTile_IconId"/>
    public int? IconId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ServiceTile.html#Alvao_API_AI_Model_ServiceTile_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ServiceTile.html#Alvao_API_AI_Model_ServiceTile_TileBackgroundColor"/>
    public int? TileBackgroundColor { get; set; }
}
