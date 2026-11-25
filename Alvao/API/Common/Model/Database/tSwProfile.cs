using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - list.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html"/>
[Table("dbo.tSwProfile")]
public class tSwProfile {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_bMemberSwProfile"/>
    /// <remarks>Column <c>bMemberSwProfile</c>: bit, not null.</remarks>
    public virtual bool bMemberSwProfile { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_iSwProfileId"/>
    /// <remarks>Column <c>iSwProfileId</c>: int, not null.</remarks>
    [Key]
    public virtual int iSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_mDescription"/>
    /// <remarks>Column <c>mDescription</c>: nvarchar(max), null.</remarks>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_mNotes"/>
    /// <remarks>Column <c>mNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfile.html#Alvao_API_Common_Model_Database_tSwProfile_sSwProfile"/>
    /// <remarks>Column <c>sSwProfile</c>: nvarchar(255), null.</remarks>
    public virtual string sSwProfile { get; set; }
}
