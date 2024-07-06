using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Software profiles - list.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwProfile.htm"/>
[TableAttribute("dbo.tSwProfile")]
public class tSwProfile
{
    public virtual bool bMemberSwProfile { get; set; }
    [KeyAttribute]
    public virtual int iSwProfileId { get; set; }
    public virtual string mDescription { get; set; }
    public virtual string mNotes { get; set; }
    public virtual string sSwProfile { get; set; }

    public tSwProfile() { }
}
