using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - links to documents and media.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistMedia.html"/>
[Table("dbo.LicHistMedia")]
public class LicHistMedia {
    /// <summary>License (tblLicHist.intLicHistId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistMedia.html#Alvao_API_Common_Model_Database_LicHistMedia_LicHistId"/>
    /// <remarks>Column <c>LicHistId</c>: int, not null. References <see cref="tblLicHist"/>.</remarks>
    [ExplicitKey]
    public virtual int LicHistId { get; set; }
    /// <summary>Media (tblMedia.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistMedia.html#Alvao_API_Common_Model_Database_LicHistMedia_MediaId"/>
    /// <remarks>Column <c>MediaId</c>: int, not null. References <see cref="tblMedia"/>.</remarks>
    public virtual int MediaId { get; set; }
}
