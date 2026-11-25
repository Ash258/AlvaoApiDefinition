using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table with links between objects in Asset Management</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html"/>
[Table("dbo.NodeRelation")]
public class NodeRelation {
    /// <summary>ID of start link object. Foreign key on tblNode table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_BeginNodeId"/>
    /// <remarks>Column <c>BeginNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int BeginNodeId { get; set; }
    /// <summary>User ID of a person who created the link (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Link creation date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_CreatedDate"/>
    /// <remarks>Column <c>CreatedDate</c>: datetime, not null.</remarks>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>ID of end link object. Foreign key on tblNode table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_EndNodeId"/>
    /// <remarks>Column <c>EndNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int EndNodeId { get; set; }
    /// <summary>Link Type. Foreign key on NodeRelationType table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_NodeRelationTypeId"/>
    /// <remarks>Column <c>NodeRelationTypeId</c>: int, not null. References <see cref="NodeRelationType"/>.</remarks>
    public virtual int NodeRelationTypeId { get; set; }
    /// <summary>User ID of a person who deleted the link (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Link removal date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>The relation does not have any of the required fields filled in.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_RequiredRelationFieldAlert"/>
    /// <remarks>Column <c>RequiredRelationFieldAlert</c>: bit, not null.</remarks>
    public virtual bool RequiredRelationFieldAlert { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelation.html#Alvao_API_Common_Model_Database_NodeRelation_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
