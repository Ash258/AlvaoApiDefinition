using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequence.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html"/>
[Table("dbo.wIdSeq")]
public class wIdSeq {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_IdSeqType"/>
    public virtual string IdSeqType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_IdSeqTypeId"/>
    public virtual int? IdSeqTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_NextNumber"/>
    public virtual string NextNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_bUse"/>
    public virtual bool bUse { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_intIdSeqId"/>
    public virtual int intIdSeqId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_liKindId"/>
    public virtual int? liKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_sKindName"/>
    public virtual string sKindName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_sName"/>
    public virtual string sName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_txtPrefix"/>
    public virtual string txtPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wIdSeq.html#Alvao_API_Common_Model_Database_wIdSeq_txtSuffix"/>
    public virtual string txtSuffix { get; set; }
}
