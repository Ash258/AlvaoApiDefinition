using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Changes of object relation custom fields.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html"/>
[Table("dbo.NodeRelationCustChange")]
public class NodeRelationCustChange {
    /// <summary>Change date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ChangeDate"/>
    public virtual DateTime ChangeDate { get; set; }
    /// <summary>Changed field (tColumn.iColumnId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Object relation ID (NodeRelation.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_NodeRelationId"/>
    public virtual int NodeRelationId { get; set; }
    /// <summary>Author of the change (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>New bit value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewBit"/>
    public virtual bool? ValueNewBit { get; set; }
    /// <summary>New date value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewDate"/>
    public virtual DateTime? ValueNewDate { get; set; }
    /// <summary>New datetime value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewDateTime"/>
    public virtual DateTime? ValueNewDateTime { get; set; }
    /// <summary>New float value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewFloat"/>
    public virtual double? ValueNewFloat { get; set; }
    /// <summary>New int value (could be foreign key to various tables)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewInt"/>
    public virtual int? ValueNewInt { get; set; }
    /// <summary>New string value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewNvarchar"/>
    public virtual string ValueNewNvarchar { get; set; }
    /// <summary>Old bit value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldBit"/>
    public virtual bool? ValueOldBit { get; set; }
    /// <summary>Old date value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldDate"/>
    public virtual DateTime? ValueOldDate { get; set; }
    /// <summary>Old datetime value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldDateTime"/>
    public virtual DateTime? ValueOldDateTime { get; set; }
    /// <summary>Old float value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldFloat"/>
    public virtual double? ValueOldFloat { get; set; }
    /// <summary>Old int value (could be foreign key to various tables)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldInt"/>
    public virtual int? ValueOldInt { get; set; }
    /// <summary>Old string value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldNvarchar"/>
    public virtual string ValueOldNvarchar { get; set; }
}
