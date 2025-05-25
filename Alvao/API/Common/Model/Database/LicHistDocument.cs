using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - links to documents and media.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistDocument.html"/>
[Table("dbo.LicHistDocument")]
public class LicHistDocument {
    /// <summary>Document (tblDocument.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistDocument.html#Alvao_API_Common_Model_Database_LicHistDocument_AMDocumentId"/>
    public virtual int AMDocumentId { get; set; }
    /// <summary>License (tblLicHist.intLicHistId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistDocument.html#Alvao_API_Common_Model_Database_LicHistDocument_LicHistId"/>
    [ExplicitKey]
    public virtual int LicHistId { get; set; }
}
