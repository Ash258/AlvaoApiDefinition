using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detections setting.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetectOpts.htm"/>
[TableAttribute("dbo.tblDetectOpts")]
public class tblDetectOpts
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_bolSwFull.htm"/>
    public virtual bool? bolSwFull { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_bolUpdate.htm"/>
    public virtual bool bolUpdate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_intDetectPeriod.htm"/>
    public virtual int? intDetectPeriod { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_intTcpipPort.htm"/>
    public virtual int? intTcpipPort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_lintComputerNodeId.htm"/>
    public virtual int? lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectKindId.htm"/>
    public virtual int lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectMethodId.htm"/>
    public virtual int? lintDetectMethodId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_txtSharePath.htm"/>
    public virtual string txtSharePath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_txtSwExclude.htm"/>
    public virtual string txtSwExclude { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectOpts_txtSwInclude.htm"/>
    public virtual string txtSwInclude { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDetectOpts__ctor.htm"/>
    public tblDetectOpts() { }
}
