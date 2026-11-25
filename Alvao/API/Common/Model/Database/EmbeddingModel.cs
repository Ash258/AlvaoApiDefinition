using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Used models to calculate embeddings.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html"/>
[Table("dbo.EmbeddingModel")]
public class EmbeddingModel {
    /// <summary>Name of model deployment</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_DeploymentName"/>
    public virtual string DeploymentName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Name of model</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_ModelName"/>
    public virtual string ModelName { get; set; }
    /// <summary>
    /// Status of embedding model: 0 - Disabled 1 - Active 2 - Reindexing 3 - FastReindexing 4 - Aborted
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmbeddingModel.html#Alvao_API_Common_Model_Database_EmbeddingModel_Status"/>
    public virtual int Status { get; set; }
}
