using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// GTS NOVERA detections.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblComputerLog.htm"/>
[TableAttribute("dbo.tblComputerLog")]
public class tblComputerLog
{
    public virtual DateTime? dteCreated { get; set; }
    public virtual DateTime? dteProcessed { get; set; }
    [KeyAttribute]
    public virtual int intComputerLogId { get; set; }
    public virtual int? intServiceType { get; set; }
    public virtual int? intType { get; set; }
    public virtual string txtComputerName { get; set; }
    public virtual string txtIPAddress { get; set; }
    public virtual string txtLDAPGUID { get; set; }
    public virtual string txtMACAddress { get; set; }
    public virtual string txtSNMP { get; set; }

    public tblComputerLog() { }
}
