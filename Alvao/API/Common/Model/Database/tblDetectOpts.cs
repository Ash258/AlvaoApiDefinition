using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detections setting.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetectOpts.htm"/>
[TableAttribute("dbo.tblDetectOpts")]
public class tblDetectOpts
{
    public virtual bool? bolSwFull { get; set; }
    public virtual bool bolUpdate { get; set; }
    public virtual int? intDetectPeriod { get; set; }
    public virtual int? intTcpipPort { get; set; }
    public virtual int? lintComputerNodeId { get; set; }
    [ExplicitKeyAttribute]
    public virtual int? lintDetectId { get; set; }
    public virtual int lintDetectKindId { get; set; }
    public virtual int? lintDetectMethodId { get; set; }
    public virtual string txtSharePath { get; set; }
    public virtual string txtSwExclude { get; set; }
    public virtual string txtSwInclude { get; set; }

    public tblDetectOpts() { }
}
