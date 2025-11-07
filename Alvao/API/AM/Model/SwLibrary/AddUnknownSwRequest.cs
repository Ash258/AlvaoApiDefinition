namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.AddUnknownSwRequest.html"/>
public class AddUnknownSwRequest {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.AddUnknownSwRequest.html#Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_ContactEmail"/>
    public string ContactEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.AddUnknownSwRequest.html#Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_FromPersonId"/>
    public int? FromPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.AddUnknownSwRequest.html#Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_NotifyOnLibUpdate"/>
    public bool NotifyOnLibUpdate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.AddUnknownSwRequest.html#Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_Products"/>
    public IEnumerable<SwLibProduct> Products { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.AddUnknownSwRequest.html#Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_GetProductInfo"/>
    public string GetProductInfo() { throw new NotImplementedException(); }
}
