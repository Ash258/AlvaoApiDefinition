using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Embeddings for objects.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectEmbedding.html"/>
[Table("dbo.ObjectEmbedding")]
public class ObjectEmbedding {
    /// <summary>Time of DescriptionVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectEmbedding.html#Alvao_API_Common_Model_Database_ObjectEmbedding_DescriptionTime"/>
    /// <remarks>Column <c>DescriptionTime</c>: datetime, null.</remarks>
    public virtual DateTime? DescriptionTime { get; set; }
    /// <summary>
    /// Vector used to compare the similarity of object description made from name, type and property values.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectEmbedding.html#Alvao_API_Common_Model_Database_ObjectEmbedding_DescriptionVector"/>
    /// <remarks>Column <c>DescriptionVector</c>: vector, null.</remarks>
    public virtual string DescriptionVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectEmbedding.html#Alvao_API_Common_Model_Database_ObjectEmbedding_EmbeddingModelId"/>
    /// <remarks>Column <c>EmbeddingModelId</c>: int, not null. References <see cref="EmbeddingModel"/>.</remarks>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>Object ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectEmbedding.html#Alvao_API_Common_Model_Database_ObjectEmbedding_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
}
