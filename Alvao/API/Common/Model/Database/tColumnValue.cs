using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Value lists for custom fields.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tColumnValue.htm"/>
[TableAttribute("dbo.tColumnValue")]
public class tColumnValue
{
    /// <summary>Full name including path via parent items.</summary>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int iColumnValueId { get; set; }
    /// <summary>Link to custom field record.</summary>
    public virtual int liColumnId { get; set; }
    /// <summary>NULL represents an item on the list of values applies to all services. The view is otherwise limited only to the configured service.</summary>
    public virtual int? liHdSectionId { get; set; }
    /// <summary>Displayed item name.</summary>
    public virtual string mColumnValue { get; set; }
    /// <summary>Order for displaying items, sorted from lowest to highest number.</summary>
    public virtual double nOrder { get; set; }
    /// <summary>Parent tree item.</summary>
    public virtual int? ParentValue { get; set; }
    public virtual string sExtra1 { get; set; }

    public tColumnValue() { }
}
