using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective authorization requesters have for SLA and services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAccess.htm"/>
[TableAttribute("dbo.vSlaAccess")]
public class vSlaAccess
{
    public virtual int liSlaAccessHdSectionId { get; set; }
    public virtual int? liSlaAccessPersonId { get; set; }
    public virtual int liSlaAccessSlaId { get; set; }

    public vSlaAccess() { }
}
