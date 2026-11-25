using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object rules mapping. Table contains concrete mapping to source and moved objects</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html"/>
[Table("dbo.ObjectRuleMapping")]
public class ObjectRuleMapping {
    /// <summary>1 = the rule is above all tree, 0 = specific mapping is used</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_FromAllObjects"/>
    public virtual bool FromAllObjects { get; set; }
    /// <summary>From object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_FromObjectId"/>
    public virtual int? FromObjectId { get; set; }
    /// <summary>From object type Id (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_FromObjectTypeId"/>
    public virtual int? FromObjectTypeId { get; set; }
    /// <summary>Object rule ID (ObjectRule.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_ObjectRuleId"/>
    public virtual int ObjectRuleId { get; set; }
    /// <summary>1 = the rule is for all object types, 0 = specific mapping is used</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_ObjectsOfAllTypes"/>
    public virtual bool ObjectsOfAllTypes { get; set; }
    /// <summary>Moved object type Id (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_ObjectsOfTypeId"/>
    public virtual int? ObjectsOfTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleMapping.html#Alvao_API_Common_Model_Database_ObjectRuleMapping_id"/>
    [Key]
    public virtual int id { get; set; }
}
