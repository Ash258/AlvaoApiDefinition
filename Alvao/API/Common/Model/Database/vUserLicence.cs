using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Drawing of licenses by users
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vUserLicence.htm"/>
[TableAttribute("dbo.vUserLicence")]
public class vUserLicence
{
    public virtual string LicenceType { get; set; }
    public virtual int? LicenceTypeId { get; set; }
    public virtual int PersonId { get; set; }

    public vUserLicence() { }
}
