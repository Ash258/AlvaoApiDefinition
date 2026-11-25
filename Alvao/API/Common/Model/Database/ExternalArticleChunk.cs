using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Chunk of an external article text used for semantic search.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html"/>
[Table("dbo.ExternalArticleChunk")]
public class ExternalArticleChunk {
    /// <summary>Sequential chunk number starting from 0.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_ChunkId"/>
    [ExplicitKey]
    public virtual int ChunkId { get; set; }
    /// <summary>Text content of the chunk.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_Content"/>
    public virtual string Content { get; set; }
    /// <summary>Embedding vector of the chunk content.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_ContentVector"/>
    public virtual string ContentVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_EmbeddingModelId"/>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>External article ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_ExternalArticleId"/>
    [ExplicitKey]
    public virtual int ExternalArticleId { get; set; }
    /// <summary>Time of ContentVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticleChunk.html#Alvao_API_Common_Model_Database_ExternalArticleChunk_Time"/>
    public virtual DateTime? Time { get; set; }
}
