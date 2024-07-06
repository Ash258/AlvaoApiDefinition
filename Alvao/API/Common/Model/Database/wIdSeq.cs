using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Numeric sequence.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_wIdSeq.htm"/>
[TableAttribute("dbo.wIdSeq")]
public class wIdSeq
{
    public virtual bool bUse { get; set; }
    public virtual string IdSeqType { get; set; }
    public virtual int? IdSeqTypeId { get; set; }
    public virtual int intIdSeqId { get; set; }
    public virtual int? liKindId { get; set; }
    public virtual string NextNumber { get; set; }
    public virtual string sKindName { get; set; }
    public virtual string sName { get; set; }
    public virtual string txtPrefix { get; set; }
    public virtual string txtSuffix { get; set; }

    public wIdSeq() { }
}
