using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - list.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html"/>
[Table("dbo.tSwProfile")]
public class tSwProfile {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_bMemberSwProfile"/>
    public virtual bool bMemberSwProfile { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_iSwProfileId"/>
    [Key]
    public virtual int iSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_mDescription"/>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_mNotes"/>
    public virtual string mNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_sSwProfile"/>
    public virtual string sSwProfile { get; set; }
}
