namespace Alvao.API.Common.Model;

/// <summary>
/// Column value model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_ColumnValue.htm"/>
public class ColumnValue
{
    /// <summary>Column name without table name</summary>
    public string ColumnName { get; set; }
    /// <summary>Non-localized column value</summary>
    public Object Value { get; set; }

    public ColumnValue() { }
}
