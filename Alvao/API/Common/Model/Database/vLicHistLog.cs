using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Log of changes in registered licenses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHistLog.htm"/>
[TableAttribute("dbo.vLicHistLog")]
public class vLicHistLog
{
    public virtual string Author { get; set; }
    public virtual int? LicHistId { get; set; }
    public virtual int LicHistLogKindId { get; set; }
    public virtual DateTime LogDate { get; set; }
    public virtual string LogKind { get; set; }
    public virtual string Message { get; set; }
    public virtual string NewVal { get; set; }
    public virtual string ObjKind { get; set; }
    public virtual string ObjName { get; set; }
    public virtual string OldVal { get; set; }
    public virtual string PropName { get; set; }

    public vLicHistLog() { }
}
