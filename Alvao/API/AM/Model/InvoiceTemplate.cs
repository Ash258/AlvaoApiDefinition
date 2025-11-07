using Alvao.API.Common;
using Newtonsoft.Json;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceTemplate.html"/>
public class InvoiceTemplate : InvoiceItemToCreate {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceTemplate.html#Alvao_API_AM_Model_InvoiceTemplate_Id"/>
    [JsonProperty("id")]
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceTemplate.html#Alvao_API_AM_Model_InvoiceTemplate_InvoiceProperties"/>
    public DocumentFieldDictionary InvoiceProperties { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceTemplate.html#Alvao_API_AM_Model_InvoiceTemplate_ItemType"/>
    [JsonProperty("itemType")]
    public string ItemType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceTemplate.html#Alvao_API_AM_Model_InvoiceTemplate_Name"/>
    [JsonProperty("name")]
    public string Name { get; set; }
}
