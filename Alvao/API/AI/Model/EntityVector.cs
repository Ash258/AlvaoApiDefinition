namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.EntityVector.html"/>
public class EntityVector {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.EntityVector.html#Alvao_API_AI_Model_EntityVector_ChunkId"/>
    public int ChunkId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.EntityVector.html#Alvao_API_AI_Model_EntityVector_EntityId"/>
    public int EntityId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.EntityVector.html#Alvao_API_AI_Model_EntityVector_Vector"/>
    public float[] Vector { get; set; }
}
