using Alvao.API.Common.Model.Database;
using Newtonsoft.Json;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html"/>
public class InvoiceProperty {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_ColumnName"/>
    public string ColumnName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_DataType"/>
    [JsonProperty("dataType")]
    public KindDataType.KindDataTypeIdEnum DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_DateValue"/>
    public DateTime? DateValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_Id"/>
    [JsonProperty("id")]
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_IsSequence"/>
    public bool IsSequence { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_NumberValue"/>
    public double? NumberValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_PropertyName"/>
    [JsonProperty("propertyName")]
    public string PropertyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_TextValue"/>
    public string TextValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_Value"/>
    [JsonProperty("value")]
    public string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceProperty.html#Alvao_API_AM_Model_InvoiceProperty_GetValue"/>
    public string GetValue() { throw new NotImplementedException(); }
}
