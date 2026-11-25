using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Chunked text content of news articles.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html"/>
[Table("dbo.NewsChunk")]
public class NewsChunk {
    /// <summary>Chunk ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_ChunkId"/>
    [ExplicitKey]
    public virtual int ChunkId { get; set; }
    /// <summary>Text content of the chunk.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_Content"/>
    public virtual string Content { get; set; }
    /// <summary>Vector used to compare the similarity of text in the news article.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_ContentVector"/>
    public virtual string ContentVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_EmbeddingModelId"/>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>News ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_NewsId"/>
    [ExplicitKey]
    public virtual int NewsId { get; set; }
    /// <summary>Time of ContentVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsChunk.html#Alvao_API_Common_Model_Database_NewsChunk_Time"/>
    public virtual DateTime? Time { get; set; }
}
