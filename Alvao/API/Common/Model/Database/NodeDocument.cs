using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - links to documents.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html"/>
[Table("dbo.NodeDocument")]
public class NodeDocument {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_AMDocumentId"/>
    /// <remarks>Column <c>AMDocumentId</c>: int, not null. References <see cref="tblDocument"/>.</remarks>
    public virtual int AMDocumentId { get; set; }
    /// <summary>ID of the person who deleted the link.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date of link deletion.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>Object (tblNode.intNodeId</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_lintNodeId"/>
    /// <remarks>Column <c>lintNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    [ExplicitKey]
    public virtual int lintNodeId { get; set; }
}
