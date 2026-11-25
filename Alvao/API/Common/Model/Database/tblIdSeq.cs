using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequences - definitions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html"/>
[Table("dbo.tblIdSeq")]
public class tblIdSeq {
    /// <summary>Numeric sequence type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_IdSeqTypeId"/>
    /// <remarks>Column <c>IdSeqTypeId</c>: int, null. References <see cref="IdSeqType"/>.</remarks>
    public virtual int? IdSeqTypeId { get; set; }
    /// <summary>Next number that will be used. Formatting including &quot;0&quot; is preserved.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_NextNumber"/>
    /// <remarks>Column <c>NextNumber</c>: nvarchar(60), null.</remarks>
    public virtual string NextNumber { get; set; }
    /// <summary>1=series is active</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_bUse"/>
    /// <remarks>Column <c>bUse</c>: bit, not null.</remarks>
    public virtual bool bUse { get; set; }
    /// <summary>1 = Media 2 = Invoices 3 = Acceptance Protocols 4 = Documents 5 = Certificates 6 = EULAs</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_intIdSeqId"/>
    /// <remarks>Column <c>intIdSeqId</c>: int, not null.</remarks>
    [Key]
    public virtual int intIdSeqId { get; set; }
    /// <summary>Property</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_liKindId"/>
    /// <remarks>Column <c>liKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? liKindId { get; set; }
    /// <summary>Sequence name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_sName"/>
    /// <remarks>Column <c>sName</c>: nvarchar(255), null.</remarks>
    public virtual string sName { get; set; }
    /// <summary>Prefix</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_txtPrefix"/>
    /// <remarks>Column <c>txtPrefix</c>: nvarchar(255), null.</remarks>
    public virtual string txtPrefix { get; set; }
    /// <summary>Suffix</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIdSeq.html#Alvao_API_Common_Model_Database_tblIdSeq_txtSuffix"/>
    /// <remarks>Column <c>txtSuffix</c>: nvarchar(255), null.</remarks>
    public virtual string txtSuffix { get; set; }
}
