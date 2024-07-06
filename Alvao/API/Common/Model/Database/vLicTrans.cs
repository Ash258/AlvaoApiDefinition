using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Shared licenses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicTrans.htm"/>
[TableAttribute("dbo.vLicTrans")]
public class vLicTrans
{
    public virtual int LicNodeId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual int NodeId { get; set; }
    public virtual string txtDesc { get; set; }
    public virtual string txtLicComputer { get; set; }

    public vLicTrans() { }
}
