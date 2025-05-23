using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>GTS NOVERA detections.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblComputerLog.htm"/>
[TableAttribute("dbo.tblComputerLog")]
public class tblComputerLog
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_dteProcessed.htm"/>
    public virtual DateTime? dteProcessed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_intComputerLogId.htm"/>
    [KeyAttribute]
    public virtual int intComputerLogId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_intServiceType.htm"/>
    public virtual int? intServiceType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_intType.htm"/>
    public virtual int? intType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_txtComputerName.htm"/>
    public virtual string txtComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_txtIPAddress.htm"/>
    public virtual string txtIPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_txtLDAPGUID.htm"/>
    public virtual string txtLDAPGUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_txtMACAddress.htm"/>
    public virtual string txtMACAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblComputerLog_txtSNMP.htm"/>
    public virtual string txtSNMP { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblComputerLog__ctor.htm"/>
    public tblComputerLog() { }
}
