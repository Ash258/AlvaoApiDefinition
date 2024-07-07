using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective authorization requesters have for SLA and services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAccess.htm"/>
[TableAttribute("dbo.vSlaAccess")]
public class vSlaAccess
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAccess_liSlaAccessHdSectionId.htm"/>
    public virtual int liSlaAccessHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAccess_liSlaAccessPersonId.htm"/>
    public virtual int? liSlaAccessPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAccess_liSlaAccessSlaId.htm"/>
    public virtual int liSlaAccessSlaId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAccess__ctor.htm"/>
    public vSlaAccess() { }
}
