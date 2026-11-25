using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Chunked text content of news articles.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html"/>
[Table("dbo.NewsChunk")]
public class NewsChunk {
    /// <summary>Chunk ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_ChunkId"/>
    /// <remarks>Column <c>ChunkId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int ChunkId { get; set; }
    /// <summary>Text content of the chunk.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_Content"/>
    /// <remarks>Column <c>Content</c>: nvarchar(max), not null.</remarks>
    public virtual string Content { get; set; }
    /// <summary>Vector used to compare the similarity of text in the news article.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_ContentVector"/>
    /// <remarks>Column <c>ContentVector</c>: vector, null.</remarks>
    public virtual string ContentVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_EmbeddingModelId"/>
    /// <remarks>Column <c>EmbeddingModelId</c>: int, not null. References <see cref="EmbeddingModel"/>.</remarks>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>News ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_NewsId"/>
    /// <remarks>Column <c>NewsId</c>: int, not null. References <see cref="News"/>.</remarks>
    [ExplicitKey]
    public virtual int NewsId { get; set; }
    /// <summary>Time of ContentVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_Time"/>
    /// <remarks>Column <c>Time</c>: datetime, null.</remarks>
    public virtual DateTime? Time { get; set; }
}
