using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective authorization requesters have for SLA and services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAccess.html"/>
[Table("dbo.vSlaAccess")]
public class vSlaAccess {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAccess.html#Alvao_API_Common_Model_Database_vSlaAccess_liSlaAccessHdSectionId"/>
    public virtual int liSlaAccessHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAccess.html#Alvao_API_Common_Model_Database_vSlaAccess_liSlaAccessPersonId"/>
    public virtual int? liSlaAccessPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAccess.html#Alvao_API_Common_Model_Database_vSlaAccess_liSlaAccessSlaId"/>
    public virtual int liSlaAccessSlaId { get; set; }
}
