using static Alvao.API.Common.Database;

namespace Alvao.API.Common.Model;

/// <summary>Column value model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnValue.html"/>
public class ColumnValue {
    /// <summary>Column name without table name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnValue.html#Alvao_API_Common_Model_ColumnValue_ColumnName"/>
    public string ColumnName { get; set; }
    /// <summary>Data type of the value. Usable only for integer custom columns with value list when you need to set the text value instead of its Id.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnValue.html#Alvao_API_Common_Model_ColumnValue_DataType"/>
    public ValueDataType DataType { get; set; }
    /// <summary>Non-localized column value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnValue.html#Alvao_API_Common_Model_ColumnValue_Value"/>
    public object Value { get; set; }
}
