using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of value list item localizations.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ColumnValueLoc.htm"/>
[TableAttribute("dbo.ColumnValueLoc")]
public class ColumnValueLoc {
    /// <summary>Custom field ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnId.htm"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Localized item value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValue.htm"/>
    public virtual string ColumnValue { get; set; }
    /// <summary>Value list item ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValueId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int ColumnValueId { get; set; }
    /// <summary>Localized reduced item value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValueShort.htm"/>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ColumnValueLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ColumnValueLoc__ctor.htm"/>
    public ColumnValueLoc() { }
}
