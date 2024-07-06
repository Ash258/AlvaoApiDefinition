using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Knowledge that a user can read in services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vKnowledgeRead.htm"/>
[TableAttribute("dbo.vKnowledgeRead")]
public class vKnowledgeRead
{
    public virtual int? ArticleId { get; set; }
    public virtual int? PersonId { get; set; }
    public virtual int? SectionId { get; set; }

    public vKnowledgeRead() { }
}
