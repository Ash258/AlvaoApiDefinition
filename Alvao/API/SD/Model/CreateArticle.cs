using Alvao.API.Common.Model;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html"/>
public class CreateArticle {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html#Alvao_API_SD_Model_CreateArticle_Annotation"/>
    public string Annotation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html#Alvao_API_SD_Model_CreateArticle_AssignedServices"/>
    public List<int> AssignedServices { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html#Alvao_API_SD_Model_CreateArticle_DisplayOrder"/>
    public int DisplayOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html#Alvao_API_SD_Model_CreateArticle_DisplayToRequesters"/>
    public bool DisplayToRequesters { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html#Alvao_API_SD_Model_CreateArticle_TextWithAttachmentsModel"/>
    public HtmlTextModel TextWithAttachmentsModel { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.CreateArticle.html#Alvao_API_SD_Model_CreateArticle_Title"/>
    public string Title { get; set; }
}
