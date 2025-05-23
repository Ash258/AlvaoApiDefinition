namespace Alvao.API.Common.Model;

/// <summary>Column value model</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_ColumnValue.htm"/>
public class ColumnValue {
    /// <summary>Column name without table name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnValue_ColumnName.htm"/>
    public string ColumnName { get; set; }
    /// <summary>Data type of the value. Usable only for integer custom columns with value list when you need to set the text value instead of its Id.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnValue_DataType.htm"/>
    public Alvao.API.Common.Database.ValueDataType DataType { get; set; }
    /// <summary>Non-localized column value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnValue_Value.htm"/>
    public Object Value { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_ColumnValue__ctor.htm"/>
    public ColumnValue() { }
}
