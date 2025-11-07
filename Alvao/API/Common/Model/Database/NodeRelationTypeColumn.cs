using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Custom fields used by object relation type.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html"/>
[Table("dbo.NodeRelationTypeColumn")]
public class NodeRelationTypeColumn {
    /// <summary>Custom field ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Field is mandatory on relation type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_IsMandatory"/>
    public virtual bool IsMandatory { get; set; }
    /// <summary>Object relation type ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeColumn.html#Alvao_API_Common_Model_Database_NodeRelationTypeColumn_NodeRelationTypeId"/>
    public virtual int NodeRelationTypeId { get; set; }
}
