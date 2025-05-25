using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Drawing of solver licenses by services</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionSolverLicence.html"/>
[Table("dbo.vSectionSolverLicence")]
public class vSectionSolverLicence {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionSolverLicence.html#Alvao_API_Common_Model_Database_vSectionSolverLicence_LicenceType"/>
    public virtual string LicenceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionSolverLicence.html#Alvao_API_Common_Model_Database_vSectionSolverLicence_PersonCount"/>
    public virtual int? PersonCount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionSolverLicence.html#Alvao_API_Common_Model_Database_vSectionSolverLicence_SectionId"/>
    public virtual int SectionId { get; set; }
}
