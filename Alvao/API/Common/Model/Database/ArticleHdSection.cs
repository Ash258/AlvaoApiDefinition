using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning articles from the knowledge base to services.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ArticleHdSection.htm"/>
[TableAttribute("dbo.ArticleHdSection")]
public class ArticleHdSection
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ArticleHdSection_ArticleId.htm"/>
    public virtual int? ArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ArticleHdSection_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ArticleHdSection_SectionId.htm"/>
    public virtual int? SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ArticleHdSection__ctor.htm"/>
    public ArticleHdSection() { }
}
