using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - list.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwProfile.htm"/>
[TableAttribute("dbo.tSwProfile")]
public class tSwProfile
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfile_bMemberSwProfile.htm"/>
    public virtual bool bMemberSwProfile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfile_iSwProfileId.htm"/>
    [KeyAttribute]
    public virtual int iSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfile_mDescription.htm"/>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfile_mNotes.htm"/>
    public virtual string mNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfile_sSwProfile.htm"/>
    public virtual string sSwProfile { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSwProfile__ctor.htm"/>
    public tSwProfile() { }
}
