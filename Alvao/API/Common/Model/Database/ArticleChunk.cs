using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Chunked text content of knowledge base articles.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html"/>
[Table("dbo.ArticleChunk")]
public class ArticleChunk {
    /// <summary>Article ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_ArticleId"/>
    /// <remarks>Column <c>ArticleId</c>: int, not null. References <see cref="tArticle"/>.</remarks>
    [ExplicitKey]
    public virtual int ArticleId { get; set; }
    /// <summary>Chunk ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_ChunkId"/>
    /// <remarks>Column <c>ChunkId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int ChunkId { get; set; }
    /// <summary>Text content of the chunk.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_Content"/>
    /// <remarks>Column <c>Content</c>: nvarchar(max), not null.</remarks>
    public virtual string Content { get; set; }
    /// <summary>Vector used to compare the similarity of text in the article.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_ContentVector"/>
    /// <remarks>Column <c>ContentVector</c>: vector, null.</remarks>
    public virtual string ContentVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_EmbeddingModelId"/>
    /// <remarks>Column <c>EmbeddingModelId</c>: int, not null. References <see cref="EmbeddingModel"/>.</remarks>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>Time of ContentVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleChunk.html#Alvao_API_Common_Model_Database_ArticleChunk_Time"/>
    /// <remarks>Column <c>Time</c>: datetime, null.</remarks>
    public virtual DateTime? Time { get; set; }
}
