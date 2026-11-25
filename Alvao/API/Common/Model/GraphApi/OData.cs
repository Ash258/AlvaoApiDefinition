using Newtonsoft.Json;

namespace Alvao.API.Common.Model.GraphApi;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.GraphApi.OData-1.html"/>
public class OData<T> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.GraphApi.OData-1.html#Alvao_API_Common_Model_GraphApi_OData_1_Count"/>
    [JsonProperty("@odata.count")]
    public int? Count { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.GraphApi.OData-1.html#Alvao_API_Common_Model_GraphApi_OData_1_Metadata"/>
    [JsonProperty("@odata.context")]
    public string? Metadata { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.GraphApi.OData-1.html#Alvao_API_Common_Model_GraphApi_OData_1_NextLink"/>
    [JsonProperty("@odata.nextLink")]
    public string? NextLink { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.GraphApi.OData-1.html#Alvao_API_Common_Model_GraphApi_OData_1_Value"/>
    [JsonProperty("value")]
    public T? Value { get; set; }
}
