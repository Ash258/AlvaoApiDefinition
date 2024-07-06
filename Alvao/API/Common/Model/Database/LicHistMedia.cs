using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License - links to documents and media.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistMedia.htm"/>
[TableAttribute("dbo.LicHistMedia")]
public class LicHistMedia
{
    /// <summary>License (tblLicHist.intLicHistId)</summary>
    [ExplicitKeyAttribute]
    public virtual int LicHistId { get; set; }
    /// <summary>Media (tblMedia.id)</summary>
    public virtual int MediaId { get; set; }

    public LicHistMedia() { }
}
