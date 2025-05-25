using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last evaluated SW detection on the computer.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html"/>
[Table("dbo.vLastEvaluatedSwDetect")]
public class vLastEvaluatedSwDetect {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_DetectSourceMethod"/>
    public virtual int? DetectSourceMethod { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_ManualRq"/>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dUpdated"/>
    public virtual DateTime? dUpdated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dteCreated"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dteImported"/>
    public virtual DateTime? dteImported { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dteRqCreated"/>
    public virtual DateTime? dteRqCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_intDetectId"/>
    public virtual int intDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_liRqCreatedPersonId"/>
    public virtual int liRqCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_lintDetectKindId"/>
    public virtual int lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_lintDetectStatusId"/>
    public virtual int lintDetectStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_txtCollector"/>
    public virtual string txtCollector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_txtDescription"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLastEvaluatedSwDetect.html#Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_txtShareRq"/>
    public virtual string txtShareRq { get; set; }
}
