using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Embeddings for tickets.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html"/>
[Table("dbo.TicketEmbedding")]
public class TicketEmbedding {
    /// <summary>Time of CommunicationVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_CommunicationTime"/>
    public virtual DateTime? CommunicationTime { get; set; }
    /// <summary>Vector used to compare the similarity of ticket communication.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_CommunicationVector"/>
    public virtual string CommunicationVector { get; set; }
    /// <summary>Time of DescriptionVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_DescriptionTime"/>
    public virtual DateTime? DescriptionTime { get; set; }
    /// <summary>Vector used to compare the similarity of ticket description and solution.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_DescriptionVector"/>
    public virtual string DescriptionVector { get; set; }
    /// <summary>Used embedding model for vectors.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_EmbeddingModelId"/>
    [ExplicitKey]
    public virtual int EmbeddingModelId { get; set; }
    /// <summary>Time of FieldsVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_FieldsTime"/>
    public virtual DateTime? FieldsTime { get; set; }
    /// <summary>Vector used to compare the similarity of ticket fields.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_FieldsVector"/>
    public virtual string FieldsVector { get; set; }
    /// <summary>Ticket ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Time of ObjectsVector change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_ObjectsTime"/>
    public virtual DateTime? ObjectsTime { get; set; }
    /// <summary>Vector used to compare ticket objects.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_ObjectsVector"/>
    public virtual string ObjectsVector { get; set; }
    /// <summary>
    /// Present vector bit flag 0 â no valid vector present 1 â Communication 2 â Fields 4 - Objects 8 -
    /// Description
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketEmbedding.html#Alvao_API_Common_Model_Database_TicketEmbedding_PresentFlag"/>
    public virtual int PresentFlag { get; set; }
}
