using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - links to documents.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html"/>
[Table("dbo.NodeDocument")]
public class NodeDocument {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_AMDocumentId"/>
    public virtual int AMDocumentId { get; set; }
    /// <summary>ID of the person who deleted the link.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date of link deletion.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>Object (tblNode.intNodeId</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeDocument.html#Alvao_API_Common_Model_Database_NodeDocument_lintNodeId"/>
    [ExplicitKey]
    public virtual int lintNodeId { get; set; }
}
