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
    public virtual bool bSlaRightsDefault { get; set; }
    [KeyAttribute]
    public virtual int iSlaRightsId { get; set; }
    public virtual int liHdSectionId { get; set; }
    public virtual int? liSlaRightsPersonId { get; set; }
    public virtual int? liSlaRightsRoleId { get; set; }
    public virtual int liSlaRightsSlaId { get; set; }

    public tSlaRights() { }
}
