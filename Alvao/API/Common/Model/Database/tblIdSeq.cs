using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequences - definitions.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblIdSeq.htm"/>
[TableAttribute("dbo.tblIdSeq")]
public class tblIdSeq
{
    /// <summary>1=series is active</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_bUse.htm"/>
    public virtual bool bUse { get; set; }
    /// <summary>Numeric sequence type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_IdSeqTypeId.htm"/>
    public virtual int? IdSeqTypeId { get; set; }
    /// <summary>1 = Media2 = Invoices3 = Acceptance Protocols4 = Documents5 = Certificates6 = EULAs</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_intIdSeqId.htm"/>
    [KeyAttribute]
    public virtual int intIdSeqId { get; set; }
    /// <summary>Property</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_liKindId.htm"/>
    public virtual int? liKindId { get; set; }
    /// <summary>Next number that will be used. Formatting including "0" is preserved.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_NextNumber.htm"/>
    public virtual string NextNumber { get; set; }
    /// <summary>Sequence name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_sName.htm"/>
    public virtual string sName { get; set; }
    /// <summary>Prefix</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_txtPrefix.htm"/>
    public virtual string txtPrefix { get; set; }
    /// <summary>Suffix</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIdSeq_txtSuffix.htm"/>
    public virtual string txtSuffix { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblIdSeq__ctor.htm"/>
    public tblIdSeq() { }
}
