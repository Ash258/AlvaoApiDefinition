using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Assigning SLA to individuals and groups.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSlaRights.htm"/>
[TableAttribute("dbo.tSlaRights")]
public class tSlaRights
{
    /// <summary>1 = SLA is set as the default; 0 = SLA is not default</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaRights_bSlaRightsDefault.htm"/>
    public virtual bool bSlaRightsDefault { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaRights_iSlaRightsId.htm"/>
    [KeyAttribute]
    public virtual int iSlaRightsId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaRights_liHdSectionId.htm"/>
    public virtual int liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsPersonId.htm"/>
    public virtual int? liSlaRightsPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsRoleId.htm"/>
    public virtual int? liSlaRightsRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaRights_liSlaRightsSlaId.htm"/>
    public virtual int liSlaRightsSlaId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSlaRights__ctor.htm"/>
    public tSlaRights() { }
}
