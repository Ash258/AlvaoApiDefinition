using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Changes of object relation custom fields.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html"/>
[Table("dbo.NodeRelationCustChange")]
public class NodeRelationCustChange {
    /// <summary>Change date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ChangeDate"/>
    /// <remarks>Column <c>ChangeDate</c>: datetime, not null.</remarks>
    public virtual DateTime ChangeDate { get; set; }
    /// <summary>Changed field (tColumn.iColumnId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    public virtual int ColumnId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Object relation ID (NodeRelation.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_NodeRelationId"/>
    /// <remarks>Column <c>NodeRelationId</c>: int, not null. References <see cref="NodeRelation"/>.</remarks>
    public virtual int NodeRelationId { get; set; }
    /// <summary>Author of the change (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>New bit value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewBit"/>
    /// <remarks>Column <c>ValueNewBit</c>: bit, null.</remarks>
    public virtual bool? ValueNewBit { get; set; }
    /// <summary>New date value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewDate"/>
    /// <remarks>Column <c>ValueNewDate</c>: date, null.</remarks>
    public virtual DateTime? ValueNewDate { get; set; }
    /// <summary>New datetime value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewDateTime"/>
    /// <remarks>Column <c>ValueNewDateTime</c>: datetime, null.</remarks>
    public virtual DateTime? ValueNewDateTime { get; set; }
    /// <summary>New float value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewFloat"/>
    /// <remarks>Column <c>ValueNewFloat</c>: float, null.</remarks>
    public virtual double? ValueNewFloat { get; set; }
    /// <summary>New int value (could be foreign key to various tables)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewInt"/>
    /// <remarks>Column <c>ValueNewInt</c>: int, null.</remarks>
    public virtual int? ValueNewInt { get; set; }
    /// <summary>New string value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueNewNvarchar"/>
    /// <remarks>Column <c>ValueNewNvarchar</c>: nvarchar(max), null.</remarks>
    public virtual string ValueNewNvarchar { get; set; }
    /// <summary>Old bit value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldBit"/>
    /// <remarks>Column <c>ValueOldBit</c>: bit, null.</remarks>
    public virtual bool? ValueOldBit { get; set; }
    /// <summary>Old date value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldDate"/>
    /// <remarks>Column <c>ValueOldDate</c>: date, null.</remarks>
    public virtual DateTime? ValueOldDate { get; set; }
    /// <summary>Old datetime value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldDateTime"/>
    /// <remarks>Column <c>ValueOldDateTime</c>: datetime, null.</remarks>
    public virtual DateTime? ValueOldDateTime { get; set; }
    /// <summary>Old float value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldFloat"/>
    /// <remarks>Column <c>ValueOldFloat</c>: float, null.</remarks>
    public virtual double? ValueOldFloat { get; set; }
    /// <summary>Old int value (could be foreign key to various tables)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldInt"/>
    /// <remarks>Column <c>ValueOldInt</c>: int, null.</remarks>
    public virtual int? ValueOldInt { get; set; }
    /// <summary>Old string value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationCustChange.html#Alvao_API_Common_Model_Database_NodeRelationCustChange_ValueOldNvarchar"/>
    /// <remarks>Column <c>ValueOldNvarchar</c>: nvarchar(max), null.</remarks>
    public virtual string ValueOldNvarchar { get; set; }
}
