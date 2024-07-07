using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Drawing of licenses by users
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vUserLicence.htm"/>
[TableAttribute("dbo.vUserLicence")]
public class vUserLicence
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserLicence_LicenceType.htm"/>
    public virtual string LicenceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserLicence_LicenceTypeId.htm"/>
    public virtual int? LicenceTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserLicence_PersonId.htm"/>
    public virtual int PersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vUserLicence__ctor.htm"/>
    public vUserLicence() { }
}
