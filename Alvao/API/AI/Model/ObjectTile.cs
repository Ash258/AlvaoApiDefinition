namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ObjectTile.html"/>
public class ObjectTile : SimilarEntity, ISimilarEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ObjectTile.html#Alvao_API_AI_Model_ObjectTile_IconId"/>
    public int? IconId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ObjectTile.html#Alvao_API_AI_Model_ObjectTile_Name"/>
    public string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.ObjectTile.html#Alvao_API_AI_Model_ObjectTile_Path"/>
    public string Path { get; set; }

}
