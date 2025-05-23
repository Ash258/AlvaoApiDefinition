using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary></summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SectionSequence.htm"/>
[TableAttribute("dbo.SectionSequence")]
public class SectionSequence
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SectionSequence_NextSectionId.htm"/>
    public virtual int NextSectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SectionSequence__ctor.htm"/>
    public SectionSequence() { }
}
