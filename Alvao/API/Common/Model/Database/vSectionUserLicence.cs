using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Drawing of user licenses by services
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSectionUserLicence.htm"/>
[TableAttribute("dbo.vSectionUserLicence")]
public class vSectionUserLicence
{
    public virtual string LicenceType { get; set; }
    public virtual int? PersonCount { get; set; }
    public virtual int SectionId { get; set; }

    public vSectionUserLicence() { }
}
