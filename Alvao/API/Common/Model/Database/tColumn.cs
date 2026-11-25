using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of custom fields and certain system fields.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html"/>
[Table("dbo.tColumn")]
public class tColumn {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_IncludeInIntegrations"/>
    /// <remarks>Column <c>IncludeInIntegrations</c>: bit, not null.</remarks>
    public virtual bool IncludeInIntegrations { get; set; }
    /// <summary>
    /// The flag specifying whether translation of value lists of a custom field into other languages is enabled /
    /// allowed.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Localize"/>
    /// <remarks>Column <c>Localize</c>: bit, not null.</remarks>
    public virtual bool Localize { get; set; }
    /// <summary>The maximum length of a custom field in characters.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_MaxLength"/>
    /// <remarks>Column <c>MaxLength</c>: int, null.</remarks>
    public virtual int? MaxLength { get; set; }
    /// <summary>Multi-row text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Multiline"/>
    /// <remarks>Column <c>Multiline</c>: bit, not null.</remarks>
    public virtual bool Multiline { get; set; }
    /// <summary>Precision of the decimal part of the number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Precision"/>
    /// <remarks>Column <c>Precision</c>: int, null.</remarks>
    public virtual int? Precision { get; set; }
    /// <summary>Date of item removal.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Removed"/>
    /// <remarks>Column <c>Removed</c>: datetime, null.</remarks>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Source group of field type User (tRole.iRoleId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null.</remarks>
    public virtual int? RoleId { get; set; }
    /// <summary>
    /// Custom field data type. May contain basic types (i.e. nvarchar, bit, int, datetime, float) or advanced data
    /// types:
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Type"/>
    /// <remarks>Column <c>Type</c>: nvarchar(128), null.</remarks>
    public virtual string Type { get; set; }
    /// <summary>Use the value list.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_bUseColumnValue"/>
    /// <remarks>Column <c>bUseColumnValue</c>: bit, not null.</remarks>
    public virtual bool bUseColumnValue { get; set; }
    /// <summary>Item ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_iColumnId"/>
    /// <remarks>Column <c>iColumnId</c>: int, not null.</remarks>
    [Key]
    public virtual int iColumnId { get; set; }
    /// <summary>Item description.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_mDescription"/>
    /// <remarks>Column <c>mDescription</c>: nvarchar(max), null.</remarks>
    public virtual string mDescription { get; set; }
    /// <summary>The order of items as they are described on the forms.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_nOrder"/>
    /// <remarks>Column <c>nOrder</c>: float, not null.</remarks>
    public virtual double nOrder { get; set; }
    /// <summary>Name of the column in the table where the values of the item are stored.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_sColumn"/>
    /// <remarks>Column <c>sColumn</c>: nvarchar(128), null.</remarks>
    public virtual string sColumn { get; set; }
    /// <summary>Name of the table where the values of the item are stored.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_sTable"/>
    /// <remarks>Column <c>sTable</c>: nvarchar(128), null.</remarks>
    public virtual string sTable { get; set; }
    /// <summary>Displayed item name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_sTitle"/>
    /// <remarks>Column <c>sTitle</c>: nvarchar(255), not null.</remarks>
    public virtual string sTitle { get; set; }
}
