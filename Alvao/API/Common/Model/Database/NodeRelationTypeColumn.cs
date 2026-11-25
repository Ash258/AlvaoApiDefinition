using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Custom fields used by object relation type.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html"/>
[Table("dbo.NodeRelationTypeColumn")]
public class NodeRelationTypeColumn {
    /// <summary>Custom field ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    public virtual int ColumnId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Field is mandatory on relation type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_IsMandatory"/>
    /// <remarks>Column <c>IsMandatory</c>: bit, not null.</remarks>
    public virtual bool IsMandatory { get; set; }
    /// <summary>Object relation type ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_NodeRelationTypeId"/>
    /// <remarks>Column <c>NodeRelationTypeId</c>: int, not null. References <see cref="NodeRelationType"/>.</remarks>
    public virtual int NodeRelationTypeId { get; set; }
}
