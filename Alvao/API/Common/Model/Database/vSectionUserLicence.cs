using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Drawing of user licenses by services</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionUserLicence.html"/>
[Table("dbo.vSectionUserLicence")]
public class vSectionUserLicence {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionUserLicence.html#Alvao_API_Common_Model_Database_vSectionUserLicence_LicenceType"/>
    public virtual string LicenceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionUserLicence.html#Alvao_API_Common_Model_Database_vSectionUserLicence_PersonCount"/>
    public virtual int? PersonCount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionUserLicence.html#Alvao_API_Common_Model_Database_vSectionUserLicence_SectionId"/>
    public virtual int SectionId { get; set; }
}
