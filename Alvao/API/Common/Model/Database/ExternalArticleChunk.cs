using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Chunk of an external article text used for semantic search.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html"/>
[Table("dbo.ExternalArticleChunk")]
public class ExternalArticleChunk {
    /// <summary>Sequential chunk number starting from 0.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_ChunkId"/>
    /// <remarks>Column <c>ChunkId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int ChunkId { get; set; }
    /// <summary>Text content of the chunk.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_Content"/>
    /// <remarks>Column <c>Content</c>: nvarchar(max), not null.</remarks>
    public virtual string Content { get; set; }
    /// <summary>Embedding vector of the chunk content.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_ContentVector"/>
    /// <remarks>Column <c>ContentVector</c>: vector, null.</remarks>
    public virtual string ContentVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_EmbeddingModelId"/>
    /// <remarks>Column <c>EmbeddingModelId</c>: int, not null. References <see cref="EmbeddingModel"/>.</remarks>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>External article ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_ExternalArticleId"/>
    /// <remarks>Column <c>ExternalArticleId</c>: int, not null. References <see cref="ExternalArticle"/>.</remarks>
    [ExplicitKey]
    public virtual int ExternalArticleId { get; set; }
    /// <summary>Time of ContentVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_Time"/>
    /// <remarks>Column <c>Time</c>: datetime, null.</remarks>
    public virtual DateTime? Time { get; set; }
}
