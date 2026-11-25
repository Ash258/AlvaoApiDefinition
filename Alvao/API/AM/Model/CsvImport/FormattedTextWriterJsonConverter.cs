using Newtonsoft.Json;

namespace Alvao.API.AM.Model.CsvImport;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.CsvImport.FormattedTextWriterJsonConverter.html"/>
public sealed class FormattedTextWriterJsonConverter : JsonConverter {
    /// <summary>Determines whether this instance can convert the specified object type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.CsvImport.FormattedTextWriterJsonConverter.html#Alvao_API_AM_Model_CsvImport_FormattedTextWriterJsonConverter_CanConvert_System_Type_"/>
    /// <param name="objectType">Type of the object.</param>
    /// <returns>true if this instance can convert the specified object type; otherwise, false.</returns>
    public override bool CanConvert(Type objectType) { throw new NotImplementedException(); }
    /// <summary>Reads the JSON representation of the object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.CsvImport.FormattedTextWriterJsonConverter.html#Alvao_API_AM_Model_CsvImport_FormattedTextWriterJsonConverter_ReadJson_Newtonsoft_Json_JsonReader_System_Type_System_Object_Newtonsoft_Json_JsonSerializer_"/>
    /// <param name="reader">The Newtonsoft.Json.JsonReader to read from.</param>
    /// <param name="objectType">Type of the object.</param>
    /// <param name="existingValue">The existing value of object being read.</param>
    /// <param name="serializer">The calling serializer.</param>
    /// <returns>The object value.</returns>
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { throw new NotImplementedException(); }
    /// <summary>Writes the JSON representation of the object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.CsvImport.FormattedTextWriterJsonConverter.html#Alvao_API_AM_Model_CsvImport_FormattedTextWriterJsonConverter_WriteJson_Newtonsoft_Json_JsonWriter_System_Object_Newtonsoft_Json_JsonSerializer_"/>
    /// <param name="writer">The Newtonsoft.Json.JsonWriter to write to.</param>
    /// <param name="value">The value.</param>
    /// <param name="serializer">The calling serializer.</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { throw new NotImplementedException(); }
}
