using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Embeddings for services.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html"/>
[Table("dbo.ServiceEmbedding")]
public class ServiceEmbedding {
    /// <summary>Time of CommunicationVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_CommunicationTime"/>
    /// <remarks>Column <c>CommunicationTime</c>: datetime, null.</remarks>
    public virtual DateTime? CommunicationTime { get; set; }
    /// <summary>Mean vector used to compare the similarity of ticket communication.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_CommunicationVector"/>
    /// <remarks>Column <c>CommunicationVector</c>: vector, null.</remarks>
    public virtual string CommunicationVector { get; set; }
    /// <summary>Time of DescriptionVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_DescriptionTime"/>
    /// <remarks>Column <c>DescriptionTime</c>: datetime, null.</remarks>
    public virtual DateTime? DescriptionTime { get; set; }
    /// <summary>Vector used to compare the similarity of service name, description and keywords.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_DescriptionVector"/>
    /// <remarks>Column <c>DescriptionVector</c>: vector, null.</remarks>
    public virtual string DescriptionVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_EmbeddingModelId"/>
    /// <remarks>Column <c>EmbeddingModelId</c>: int, not null. References <see cref="EmbeddingModel"/>.</remarks>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>Time of FieldsVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_FieldsTime"/>
    /// <remarks>Column <c>FieldsTime</c>: datetime, null.</remarks>
    public virtual DateTime? FieldsTime { get; set; }
    /// <summary>Mean vector used to compare the similarity of ticket fields.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_FieldsVector"/>
    /// <remarks>Column <c>FieldsVector</c>: vector, null.</remarks>
    public virtual string FieldsVector { get; set; }
    /// <summary>Service ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Time of ObjectsVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_ObjectsTime"/>
    /// <remarks>Column <c>ObjectsTime</c>: datetime, null.</remarks>
    public virtual DateTime? ObjectsTime { get; set; }
    /// <summary>Mean vector used to compare ticket objects.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_ObjectsVector"/>
    /// <remarks>Column <c>ObjectsVector</c>: vector, null.</remarks>
    public virtual string ObjectsVector { get; set; }
    /// <summary>
    /// Present vector bit flag 0 â no valid vector present 1 â Communication 2 â Fields 4 - Objects 8 -
    /// Description
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ServiceEmbedding.html#Alvao_API_Common_Model_Database_ServiceEmbedding_PresentFlag"/>
    /// <remarks>Column <c>PresentFlag</c>: int, not null.</remarks>
    public virtual int PresentFlag { get; set; }
}
