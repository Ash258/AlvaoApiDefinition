using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Used models to calculate embeddings.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html"/>
[Table("dbo.EmbeddingModel")]
public class EmbeddingModel {
    /// <summary>Name of model deployment</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_DeploymentName"/>
    /// <remarks>Column <c>DeploymentName</c>: nvarchar(64), not null.</remarks>
    public virtual string DeploymentName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Name of model</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_ModelName"/>
    /// <remarks>Column <c>ModelName</c>: nvarchar(64), not null.</remarks>
    public virtual string ModelName { get; set; }
    /// <summary>
    /// Status of embedding model: 0 - Disabled 1 - Active 2 - Reindexing 3 - FastReindexing 4 - Aborted
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_Status"/>
    /// <remarks>Column <c>Status</c>: int, not null.</remarks>
    public virtual int Status { get; set; }
}
