using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - sub-profiles.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwProfileSwProfile.htm"/>
[TableAttribute("dbo.tSwProfileSwProfile")]
public class tSwProfileSwProfile
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfileSwProfile_liMemberSwProfileId.htm"/>
    public virtual int liMemberSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfileSwProfile_liSwProfileId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int liSwProfileId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSwProfileSwProfile__ctor.htm"/>
    public tSwProfileSwProfile() { }
}
