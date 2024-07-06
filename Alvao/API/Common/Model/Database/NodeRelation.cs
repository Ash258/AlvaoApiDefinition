using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Table with links between objects in AM Console
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeRelation.htm"/>
[TableAttribute("dbo.NodeRelation")]
public class NodeRelation
{
    /// <summary>ID of start link object. Foreign key on tblNode table.</summary>
    public virtual int BeginNodeId { get; set; }
    /// <summary>User ID of a person who created the link (tPerson.iPersonId).</summary>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Link creation date and time (UTC)</summary>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>ID of end link object. Foreign key on tblNode table.</summary>
    public virtual int EndNodeId { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Link Type. Foreign key on NodeRelationType table.</summary>
    public virtual int NodeRelationTypeId { get; set; }
    /// <summary>User ID of a person who deleted the link (tPerson.iPersonId).</summary>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Link removal date and time (UTC)</summary>
    public virtual DateTime? RemovedDate { get; set; }

    public NodeRelation() { }
}
