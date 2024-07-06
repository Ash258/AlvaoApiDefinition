using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Software profiles - sub-profiles.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwProfileSwProfile.htm"/>
[TableAttribute("dbo.tSwProfileSwProfile")]
public class tSwProfileSwProfile
{
    public virtual int liMemberSwProfileId { get; set; }
    [ExplicitKeyAttribute]
    public virtual int liSwProfileId { get; set; }

    public tSwProfileSwProfile() { }
}
