using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of custom fields and certain system items.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tColumn.htm"/>
[TableAttribute("dbo.tColumn")]
public class tColumn
{
    /// <summary>Use the value list.</summary>
    public virtual bool bUseColumnValue { get; set; }
    /// <summary>Item ID.</summary>
    [KeyAttribute]
    public virtual int iColumnId { get; set; }
    /// <summary>The flag specifying whether translation of value lists of a custom field into other languages is enabled / allowed.</summary>
    public virtual bool Localize { get; set; }
    /// <summary>The maximum length of a custom field in characters.</summary>
    public virtual int? MaxLength { get; set; }
    /// <summary>Item description.</summary>
    public virtual string mDescription { get; set; }
    /// <summary>Multi-row text.</summary>
    public virtual bool Multiline { get; set; }
    /// <summary>The order of items as they are described on the forms.</summary>
    public virtual double nOrder { get; set; }
    /// <summary>Date of item removal.</summary>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Source group of field type User (tRole.iRoleId).</summary>
    public virtual int? RoleId { get; set; }
    /// <summary>Name of the column in the table where the values of the item are stored.</summary>
    public virtual string sColumn { get; set; }
    /// <summary>Name of the table where the values of the item are stored.</summary>
    public virtual string sTable { get; set; }
    /// <summary>Displayed item name.</summary>
    public virtual string sTitle { get; set; }
    /// <summary>Custom field data type. May contain basic types (i.e. nvarchar, bit, int, datetime, float) or advanced data types: - user – int representing foreign key to tPerson (i.e. tPerson.iPersonId)</summary>
    public virtual string Type { get; set; }

    public tColumn() { }
}
