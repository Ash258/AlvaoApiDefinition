using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object rules mapping. Table contains concrete mapping to source and moved objects</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html"/>
[Table("dbo.ObjectRuleMapping")]
public class ObjectRuleMapping {
    /// <summary>1 = the rule is above all tree, 0 = specific mapping is used</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_FromAllObjects"/>
    /// <remarks>Column <c>FromAllObjects</c>: bit, not null.</remarks>
    public virtual bool FromAllObjects { get; set; }
    /// <summary>From object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_FromObjectId"/>
    /// <remarks>Column <c>FromObjectId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? FromObjectId { get; set; }
    /// <summary>From object type Id (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_FromObjectTypeId"/>
    /// <remarks>Column <c>FromObjectTypeId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? FromObjectTypeId { get; set; }
    /// <summary>Object rule ID (ObjectRule.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_ObjectRuleId"/>
    /// <remarks>Column <c>ObjectRuleId</c>: int, not null. References <see cref="ObjectRule"/>.</remarks>
    public virtual int ObjectRuleId { get; set; }
    /// <summary>1 = the rule is for all object types, 0 = specific mapping is used</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_ObjectsOfAllTypes"/>
    /// <remarks>Column <c>ObjectsOfAllTypes</c>: bit, not null.</remarks>
    public virtual bool ObjectsOfAllTypes { get; set; }
    /// <summary>Moved object type Id (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_ObjectsOfTypeId"/>
    /// <remarks>Column <c>ObjectsOfTypeId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? ObjectsOfTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
