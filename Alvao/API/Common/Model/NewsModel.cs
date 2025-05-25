namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.NewsModel.html"/>
public class NewsModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.NewsModel.html#Alvao_API_Common_Model_NewsModel_HtmlText"/>
    public string HtmlText { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.NewsModel.html#Alvao_API_Common_Model_NewsModel_LocaleId"/>
    public int? LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.NewsModel.html#Alvao_API_Common_Model_NewsModel_NewsId"/>
    public int NewsId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.NewsModel.html#Alvao_API_Common_Model_NewsModel_Subject"/>
    public string Subject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.NewsModel.html#Alvao_API_Common_Model_NewsModel_Text"/>
    public string Text { get; set; }
}
