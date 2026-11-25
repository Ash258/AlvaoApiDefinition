using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object rules mapping. Table contains concrete mapping to source and moved objects</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html"/>
[Table("dbo.ObjectRuleLog")]
public class ObjectRuleLog {
    /// <summary>Original parent object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_FromNodeId"/>
    public virtual int? FromNodeId { get; set; }
    /// <summary>Original parent object name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_FromNodeName"/>
    public virtual string FromNodeName { get; set; }
    /// <summary>Moved object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Moved object name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_NodeName"/>
    public virtual string NodeName { get; set; }
    /// <summary>Object rule ID (ObjectRule.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_ObjectRuleId"/>
    public virtual int? ObjectRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_id"/>
    [Key]
    public virtual int id { get; set; }
}
