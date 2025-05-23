using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Services for which the individual news are intended.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NewsHdSection.htm"/>
[TableAttribute("dbo.NewsHdSection")]
public class NewsHdSection
{
    /// <summary>id of the service for which the news post is intended (tHdSection.iHdSectionId). NULL = intended for all services.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsHdSection_HdSectionId.htm"/>
    public virtual int? HdSectionId { get; set; }
    /// <summary>Primary table key.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsHdSection_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>id of the news post (News.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsHdSection_NewsId.htm"/>
    public virtual int NewsId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NewsHdSection__ctor.htm"/>
    public NewsHdSection() { }
}
