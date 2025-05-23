using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Drawing of solver licenses by services</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSectionSolverLicence.htm"/>
[TableAttribute("dbo.vSectionSolverLicence")]
public class vSectionSolverLicence {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionSolverLicence_LicenceType.htm"/>
    public virtual string LicenceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionSolverLicence_PersonCount.htm"/>
    public virtual int? PersonCount { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionSolverLicence_SectionId.htm"/>
    public virtual int SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSectionSolverLicence__ctor.htm"/>
    public vSectionSolverLicence() { }
}
