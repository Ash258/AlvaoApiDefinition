using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object rules for automatic object sorting</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html"/>
[Table("dbo.ObjectRule")]
public class ObjectRule {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_AlvaoModuleId"/>
    /// <remarks>Column <c>AlvaoModuleId</c>: int, null. References <see cref="AlvaoModule"/>.</remarks>
    public virtual int? AlvaoModuleId { get; set; }
    /// <summary>SQL conditions related to selected source and destination properties, paths and types</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Condition"/>
    /// <remarks>Column <c>Condition</c>: nvarchar(max), null.</remarks>
    public virtual string Condition { get; set; }
    /// <summary>Rule description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Rule execution error text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Error"/>
    /// <remarks>Column <c>Error</c>: nvarchar(max), null.</remarks>
    public virtual string Error { get; set; }
    /// <summary>1 = the rule is enabled, 0 = disabled</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_IsEnabled"/>
    /// <remarks>Column <c>IsEnabled</c>: bit, not null.</remarks>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Rule name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(1024), not null.</remarks>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Order"/>
    /// <remarks>Column <c>Order</c>: int, null.</remarks>
    public virtual int? Order { get; set; }
    /// <summary>Rule removal date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Removed"/>
    /// <remarks>Column <c>Removed</c>: datetime, null.</remarks>
    public virtual DateTime? Removed { get; set; }
    /// <summary>To object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_ToObjectId"/>
    /// <remarks>Column <c>ToObjectId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? ToObjectId { get; set; }
    /// <summary>To object type Id (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_ToObjectTypeId"/>
    /// <remarks>Column <c>ToObjectTypeId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? ToObjectTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
