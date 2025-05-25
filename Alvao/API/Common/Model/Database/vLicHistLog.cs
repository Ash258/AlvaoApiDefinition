using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log of changes in registered licenses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html"/>
[Table("dbo.vLicHistLog")]
public class vLicHistLog {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_Author"/>
    public virtual string Author { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_LicHistId"/>
    public virtual int? LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_LicHistLogKindId"/>
    public virtual int LicHistLogKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_LogDate"/>
    public virtual DateTime LogDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_LogKind"/>
    public virtual string LogKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_Message"/>
    public virtual string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_NewVal"/>
    public virtual string NewVal { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_ObjKind"/>
    public virtual string ObjKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_ObjName"/>
    public virtual string ObjName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_OldVal"/>
    public virtual string OldVal { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicHistLog.html#Alvao_API_Common_Model_Database_vLicHistLog_PropName"/>
    public virtual string PropName { get; set; }
}
