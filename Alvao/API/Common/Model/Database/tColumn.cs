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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_bUseColumnValue.htm"/>
    public virtual bool bUseColumnValue { get; set; }
    /// <summary>Item ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_iColumnId.htm"/>
    [KeyAttribute]
    public virtual int iColumnId { get; set; }
    /// <summary>The flag specifying whether translation of value lists of a custom field into other languages is enabled / allowed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_Localize.htm"/>
    public virtual bool Localize { get; set; }
    /// <summary>The maximum length of a custom field in characters.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_MaxLength.htm"/>
    public virtual int? MaxLength { get; set; }
    /// <summary>Item description.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_mDescription.htm"/>
    public virtual string mDescription { get; set; }
    /// <summary>Multi-row text.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_Multiline.htm"/>
    public virtual bool Multiline { get; set; }
    /// <summary>The order of items as they are described on the forms.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_nOrder.htm"/>
    public virtual double nOrder { get; set; }
    /// <summary>Date of item removal.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Source group of field type User (tRole.iRoleId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_RoleId.htm"/>
    public virtual int? RoleId { get; set; }
    /// <summary>Name of the column in the table where the values of the item are stored.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_sColumn.htm"/>
    public virtual string sColumn { get; set; }
    /// <summary>Name of the table where the values of the item are stored.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_sTable.htm"/>
    public virtual string sTable { get; set; }
    /// <summary>Displayed item name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_sTitle.htm"/>
    public virtual string sTitle { get; set; }
    /// <summary>Custom field data type. May contain basic types (i.e. nvarchar, bit, int, datetime, float) or advanced data types: - user – int representing foreign key to tPerson (i.e. tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumn_Type.htm"/>
    public virtual string Type { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tColumn__ctor.htm"/>
    public tColumn() { }
}
