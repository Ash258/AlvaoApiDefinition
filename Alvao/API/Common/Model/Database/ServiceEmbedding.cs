using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Embeddings for services.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html"/>
[Table("dbo.ServiceEmbedding")]
public class ServiceEmbedding {
    /// <summary>Time of CommunicationVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_CommunicationTime"/>
    public virtual DateTime? CommunicationTime { get; set; }
    /// <summary>Mean vector used to compare the similarity of ticket communication.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_CommunicationVector"/>
    public virtual string CommunicationVector { get; set; }
    /// <summary>Time of DescriptionVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_DescriptionTime"/>
    public virtual DateTime? DescriptionTime { get; set; }
    /// <summary>Vector used to compare the similarity of service name, description and keywords.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_DescriptionVector"/>
    public virtual string DescriptionVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_EmbeddingModelId"/>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>Time of FieldsVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_FieldsTime"/>
    public virtual DateTime? FieldsTime { get; set; }
    /// <summary>Mean vector used to compare the similarity of ticket fields.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_FieldsVector"/>
    public virtual string FieldsVector { get; set; }
    /// <summary>Service ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Time of ObjectsVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_ObjectsTime"/>
    public virtual DateTime? ObjectsTime { get; set; }
    /// <summary>Mean vector used to compare ticket objects.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_ObjectsVector"/>
    public virtual string ObjectsVector { get; set; }
    /// <summary>
    /// Present vector bit flag 0 â no valid vector present 1 â Communication 2 â Fields 4 - Objects 8 -
    /// Description
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_PresentFlag"/>
    public virtual int PresentFlag { get; set; }
}
