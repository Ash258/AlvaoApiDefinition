using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object rules mapping. Table contains concrete mapping to source and moved objects</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html"/>
[Table("dbo.ObjectRuleLog")]
public class ObjectRuleLog {
    /// <summary>Original parent object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_FromNodeId"/>
    /// <remarks>Column <c>FromNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? FromNodeId { get; set; }
    /// <summary>Original parent object name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_FromNodeName"/>
    /// <remarks>Column <c>FromNodeName</c>: nvarchar(255), not null.</remarks>
    public virtual string FromNodeName { get; set; }
    /// <summary>Moved object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? NodeId { get; set; }
    /// <summary>Moved object name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_NodeName"/>
    /// <remarks>Column <c>NodeName</c>: nvarchar(255), not null.</remarks>
    public virtual string NodeName { get; set; }
    /// <summary>Object rule ID (ObjectRule.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_ObjectRuleId"/>
    /// <remarks>Column <c>ObjectRuleId</c>: int, null. References <see cref="ObjectRule"/>.</remarks>
    public virtual int? ObjectRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ObjectRuleLog.html#Alvao_API_Common_Model_Database_ObjectRuleLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
