using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of custom fields and certain system items.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html"/>
[Table("dbo.tColumn")]
public class tColumn {
    /// <summary>The flag specifying whether translation of value lists of a custom field into other languages is enabled / allowed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Localize"/>
    public virtual bool Localize { get; set; }
    /// <summary>The maximum length of a custom field in characters.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_MaxLength"/>
    public virtual int? MaxLength { get; set; }
    /// <summary>Multi-row text.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Multiline"/>
    public virtual bool Multiline { get; set; }
    /// <summary>Precision of the decimal part of the number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Precision"/>
    public virtual int? Precision { get; set; }
    /// <summary>Date of item removal.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Source group of field type User (tRole.iRoleId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <summary>Custom field data type. May contain basic types (i.e. nvarchar, bit, int, datetime, float) or advanced data types:</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_Type"/>
    public virtual string Type { get; set; }
    /// <summary>Use the value list.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_bUseColumnValue"/>
    public virtual bool bUseColumnValue { get; set; }
    /// <summary>Item ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_iColumnId"/>
    [Key]
    public virtual int iColumnId { get; set; }
    /// <summary>Item description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_mDescription"/>
    public virtual string mDescription { get; set; }
    /// <summary>The order of items as they are described on the forms.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_nOrder"/>
    public virtual double nOrder { get; set; }
    /// <summary>Name of the column in the table where the values of the item are stored.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_sColumn"/>
    public virtual string sColumn { get; set; }
    /// <summary>Name of the table where the values of the item are stored.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_sTable"/>
    public virtual string sTable { get; set; }
    /// <summary>Displayed item name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumn.html#Alvao_API_Common_Model_Database_tColumn_sTitle"/>
    public virtual string sTitle { get; set; }
}
