using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - links to documents.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeDocument.htm"/>
[TableAttribute("dbo.NodeDocument")]
public class NodeDocument {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeDocument_AMDocumentId.htm"/>
    public virtual int AMDocumentId { get; set; }
    /// <summary>Object (tblNode.intNodeId</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeDocument_lintNodeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int lintNodeId { get; set; }
    /// <summary>ID of the person who deleted the link.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeDocument_RemovedByPersonId.htm"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date of link deletion.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeDocument_RemovedDate.htm"/>
    public virtual DateTime? RemovedDate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NodeDocument__ctor.htm"/>
    public NodeDocument() { }
}
