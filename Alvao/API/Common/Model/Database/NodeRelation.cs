using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table with links between objects in Asset Management</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html"/>
[Table("dbo.NodeRelation")]
public class NodeRelation {
    /// <summary>ID of start link object. Foreign key on tblNode table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_BeginNodeId"/>
    public virtual int BeginNodeId { get; set; }
    /// <summary>User ID of a person who created the link (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_CreatedByPersonId"/>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Link creation date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_CreatedDate"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>ID of end link object. Foreign key on tblNode table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_EndNodeId"/>
    public virtual int EndNodeId { get; set; }
    /// <summary>Link Type. Foreign key on NodeRelationType table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_NodeRelationTypeId"/>
    public virtual int NodeRelationTypeId { get; set; }
    /// <summary>User ID of a person who deleted the link (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Link removal date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_id"/>
    [Key]
    public virtual int id { get; set; }
}
