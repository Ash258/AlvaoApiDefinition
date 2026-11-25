namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.TextChunk.html"/>
public class TextChunk {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.TextChunk.html#Alvao_API_Common_Model_TextChunk_ChunkId"/>
    public int ChunkId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.TextChunk.html#Alvao_API_Common_Model_TextChunk_Content"/>
    public string Content { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.TextChunk.html#Alvao_API_Common_Model_TextChunk_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.TextChunk.html#Alvao_API_Common_Model_TextChunk_ModelId"/>
    public int ModelId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.TextChunk.html#Alvao_API_Common_Model_TextChunk_Vector"/>
    public float[] Vector { get; set; }
}
