namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html"/>
public class ExternalArticleSearchResult {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_CTag"/>
    public string CTag { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_Chunks"/>
    public List<ExternalArticleChunkResult> Chunks { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_FileId"/>
    public string FileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_FileName"/>
    public string FileName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_MinCosineDistance"/>
    public float MinCosineDistance { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_ModifiedTime"/>
    public DateTimeOffset ModifiedTime { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.ExternalArticleSearchResult.html#Alvao_API_SD_Model_ExternalArticleSearchResult_Url"/>
    public string Url { get; set; }
}
