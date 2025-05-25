using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of all objects.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html"/>
[Table("dbo.vNodeProperty")]
public class vNodeProperty {
    /// <summary>If the value of the property can be changed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_CanModify"/>
    public virtual bool? CanModify { get; set; }
    /// <summary>Name of the column in the NodeCust table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_ColumnName"/>
    public virtual string ColumnName { get; set; }
    /// <summary>If the property value is inherited to child objects.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_Inheritable"/>
    public virtual bool? Inheritable { get; set; }
    /// <summary>Object ID (tblNode.intNodeId) from which the property is inherited.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_InheritedFromNodeId"/>
    public virtual int? InheritedFromNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_IsDetected"/>
    public virtual bool? IsDetected { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_IsFromAD"/>
    public virtual bool? IsFromAD { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_KindCode"/>
    public virtual int? KindCode { get; set; }
    /// <summary>Property data type ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_KindDataTypeId"/>
    public virtual int KindDataTypeId { get; set; }
    /// <summary>Property kind ID (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_KindId"/>
    public virtual int? KindId { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeProperty.html#Alvao_API_Common_Model_Database_vNodeProperty_NodeId"/>
    public virtual int NodeId { get; set; }
}
