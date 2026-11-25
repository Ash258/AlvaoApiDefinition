using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Chunked text content of knowledge base articles.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html"/>
[Table("dbo.ArticleChunk")]
public class ArticleChunk {
    /// <summary>Article ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_ArticleId"/>
    [ExplicitKey]
    public virtual int ArticleId { get; set; }
    /// <summary>Chunk ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_ChunkId"/>
    [ExplicitKey]
    public virtual int ChunkId { get; set; }
    /// <summary>Text content of the chunk.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_Content"/>
    public virtual string Content { get; set; }
    /// <summary>Vector used to compare the similarity of text in the article.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_ContentVector"/>
    public virtual string ContentVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_EmbeddingModelId"/>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>Time of ContentVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_Time"/>
    public virtual DateTime? Time { get; set; }
}
