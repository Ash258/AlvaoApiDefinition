using Newtonsoft.Json;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html"/>
public class Property {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_CanModify"/>
    [JsonIgnore]
    public bool CanModify { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ClassId"/>
    [JsonIgnore]
    public int ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ClassIds"/>
    [JsonIgnore]
    public IEnumerable<int> ClassIds { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ColumnName"/>
    public string ColumnName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_HasGlobalScope"/>
    [JsonIgnore]
    public bool HasGlobalScope { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_IsFromAd"/>
    [JsonIgnore]
    public bool IsFromAd { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_IsInheritable"/>
    [JsonIgnore]
    public bool IsInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_IsUnique"/>
    [JsonIgnore]
    public bool IsUnique { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_KindCode"/>
    [JsonIgnore]
    public Kind.KindCode KindCode { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_KindDataType"/>
    [JsonIgnore]
    public Kind.DataType KindDataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_KindId"/>
    [JsonIgnore]
    public int KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_LocalizedName"/>
    [JsonIgnore]
    public string LocalizedName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ObjectId"/>
    [JsonIgnore]
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ParentNodeId"/>
    [JsonIgnore]
    public int? ParentNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_SampleString"/>
    [JsonIgnore]
    public string SampleString { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_SequenceId"/>
    [JsonIgnore]
    public int SequenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_Value"/>
    public object Value { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ValueIsSelectionOnly"/>
    [JsonIgnore]
    public bool ValueIsSelectionOnly { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_ValueKindId"/>
    [JsonIgnore]
    public int? ValueKindId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property__ctor"/>
    public Property() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property__ctor_System_Int32_"/>
    public Property(int sequenceId) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property__ctor_System_String_System_String_System_String_Alvao_API_AM_Model_Kind_DataType_"/>
    public Property(string name, string value, string columnName, Kind.DataType kind = Kind.DataType.KindNone) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_IsInherited"/>
    public bool IsInherited() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_IsQueryProperty"/>
    public bool IsQueryProperty() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_IsSystemProperty"/>
    public bool IsSystemProperty() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Property.html#Alvao_API_AM_Model_Property_Validate_System_Int32_"/>
    public bool Validate(int localeId) { throw new NotImplementedException(); }
}
