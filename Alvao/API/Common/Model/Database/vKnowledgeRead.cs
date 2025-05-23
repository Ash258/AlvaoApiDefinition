using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Knowledge that a user can read in services.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vKnowledgeRead.htm"/>
[TableAttribute("dbo.vKnowledgeRead")]
public class vKnowledgeRead {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vKnowledgeRead_ArticleId.htm"/>
    public virtual int? ArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vKnowledgeRead_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vKnowledgeRead_SectionId.htm"/>
    public virtual int? SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vKnowledgeRead__ctor.htm"/>
    public vKnowledgeRead() { }
}
