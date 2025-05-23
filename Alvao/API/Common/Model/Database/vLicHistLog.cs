using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log of changes in registered licenses.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHistLog.htm"/>
[TableAttribute("dbo.vLicHistLog")]
public class vLicHistLog
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_Author.htm"/>
    public virtual string Author { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_LicHistId.htm"/>
    public virtual int? LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_LicHistLogKindId.htm"/>
    public virtual int LicHistLogKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_LogDate.htm"/>
    public virtual DateTime LogDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_LogKind.htm"/>
    public virtual string LogKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_Message.htm"/>
    public virtual string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_NewVal.htm"/>
    public virtual string NewVal { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_ObjKind.htm"/>
    public virtual string ObjKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_ObjName.htm"/>
    public virtual string ObjName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_OldVal.htm"/>
    public virtual string OldVal { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicHistLog_PropName.htm"/>
    public virtual string PropName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLicHistLog__ctor.htm"/>
    public vLicHistLog() { }
}
