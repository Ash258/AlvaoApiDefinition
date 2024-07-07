namespace Alvao.API.Common.Model;

/// <summary>
/// Column value model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_ColumnValue.htm"/>
public class ColumnValue
{
    /// <summary>Column name without table name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnValue_ColumnName.htm"/>
    public string ColumnName { get; set; }
    /// <summary>Non-localized column value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnValue_Value.htm"/>
    public Object Value { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_ColumnValue__ctor.htm"/>
    public ColumnValue() { }
}
