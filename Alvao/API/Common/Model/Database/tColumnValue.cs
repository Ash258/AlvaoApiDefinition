using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Value lists for custom fields.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tColumnValue.htm"/>
[TableAttribute("dbo.tColumnValue")]
public class tColumnValue
{
    /// <summary>Full name including path via parent items.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_ColumnValueShort.htm"/>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_iColumnValueId.htm"/>
    [KeyAttribute]
    public virtual int iColumnValueId { get; set; }
    /// <summary>Link to custom field record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_liColumnId.htm"/>
    public virtual int liColumnId { get; set; }
    /// <summary>NULL represents an item on the list of values applies to all services. The view is otherwise limited only to the configured service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_liHdSectionId.htm"/>
    public virtual int? liHdSectionId { get; set; }
    /// <summary>Displayed item name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_mColumnValue.htm"/>
    public virtual string mColumnValue { get; set; }
    /// <summary>Order for displaying items, sorted from lowest to highest number.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_nOrder.htm"/>
    public virtual double nOrder { get; set; }
    /// <summary>Parent tree item.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_ParentValue.htm"/>
    public virtual int? ParentValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tColumnValue_sExtra1.htm"/>
    public virtual string sExtra1 { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tColumnValue__ctor.htm"/>
    public tColumnValue() { }
}
