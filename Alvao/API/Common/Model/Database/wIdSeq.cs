using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequence.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_wIdSeq.htm"/>
[TableAttribute("dbo.wIdSeq")]
public class wIdSeq
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_bUse.htm"/>
    public virtual bool bUse { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_IdSeqType.htm"/>
    public virtual string IdSeqType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_IdSeqTypeId.htm"/>
    public virtual int? IdSeqTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_intIdSeqId.htm"/>
    public virtual int intIdSeqId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_liKindId.htm"/>
    public virtual int? liKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_NextNumber.htm"/>
    public virtual string NextNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_sKindName.htm"/>
    public virtual string sKindName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_sName.htm"/>
    public virtual string sName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_txtPrefix.htm"/>
    public virtual string txtPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wIdSeq_txtSuffix.htm"/>
    public virtual string txtSuffix { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_wIdSeq__ctor.htm"/>
    public wIdSeq() { }
}
