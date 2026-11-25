using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detections setting.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html"/>
[Table("dbo.tblDetectOpts")]
public class tblDetectOpts {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_bolSwFull"/>
    /// <remarks>Column <c>bolSwFull</c>: bit, null.</remarks>
    public virtual bool? bolSwFull { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_intDetectPeriod"/>
    /// <remarks>Column <c>intDetectPeriod</c>: int, null.</remarks>
    public virtual int? intDetectPeriod { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintComputerNodeId"/>
    /// <remarks>Column <c>lintComputerNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, null. References <see cref="tblDetect"/>.</remarks>
    [ExplicitKey]
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectKindId"/>
    /// <remarks>Column <c>lintDetectKindId</c>: int, not null. References <see cref="tblDetectKind"/>.</remarks>
    public virtual int lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectMethodId"/>
    /// <remarks>Column <c>lintDetectMethodId</c>: int, null. References <see cref="DetectMethod"/>.</remarks>
    public virtual int? lintDetectMethodId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_txtSwExclude"/>
    /// <remarks>Column <c>txtSwExclude</c>: nvarchar(255), null.</remarks>
    public virtual string txtSwExclude { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_txtSwInclude"/>
    /// <remarks>Column <c>txtSwInclude</c>: nvarchar(255), null.</remarks>
    public virtual string txtSwInclude { get; set; }
}
