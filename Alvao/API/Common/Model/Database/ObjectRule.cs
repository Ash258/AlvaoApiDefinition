using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object rules for automatic object sorting</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html"/>
[Table("dbo.ObjectRule")]
public class ObjectRule {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_AlvaoModuleId"/>
    public virtual int? AlvaoModuleId { get; set; }
    /// <summary>SQL conditions related to selected source and destination properties, paths and types</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Condition"/>
    public virtual string Condition { get; set; }
    /// <summary>Rule description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Rule execution error text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Error"/>
    public virtual string Error { get; set; }
    /// <summary>1 = the rule is enabled, 0 = disabled</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_IsEnabled"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Rule name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Order"/>
    public virtual int? Order { get; set; }
    /// <summary>Rule removal date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>To object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_ToObjectId"/>
    public virtual int? ToObjectId { get; set; }
    /// <summary>To object type Id (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_ToObjectTypeId"/>
    public virtual int? ToObjectTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRule.html#Alvao_API_Common_Model_Database_ObjectRule_id"/>
    [Key]
    public virtual int id { get; set; }
}
