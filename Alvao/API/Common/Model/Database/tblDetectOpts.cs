using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detections setting.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html"/>
[Table("dbo.tblDetectOpts")]
public class tblDetectOpts {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_bolSwFull"/>
    public virtual bool? bolSwFull { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_intDetectPeriod"/>
    public virtual int? intDetectPeriod { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintComputerNodeId"/>
    public virtual int? lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectId"/>
    [ExplicitKey]
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectKindId"/>
    public virtual int lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_lintDetectMethodId"/>
    public virtual int? lintDetectMethodId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_txtSwExclude"/>
    public virtual string txtSwExclude { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectOpts.html#Alvao_API_Common_Model_Database_tblDetectOpts_txtSwInclude"/>
    public virtual string txtSwInclude { get; set; }
}
