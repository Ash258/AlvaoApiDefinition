using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last evaluated SW detection on the computer.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect.htm"/>
[TableAttribute("dbo.vLastEvaluatedSwDetect")]
public class vLastEvaluatedSwDetect {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_DetectSourceMethod.htm"/>
    public virtual int? DetectSourceMethod { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dteImported.htm"/>
    public virtual DateTime? dteImported { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dteRqCreated.htm"/>
    public virtual DateTime? dteRqCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_dUpdated.htm"/>
    public virtual DateTime? dUpdated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_intDetectId.htm"/>
    public virtual int intDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_lintDetectKindId.htm"/>
    public virtual int lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_lintDetectStatusId.htm"/>
    public virtual int lintDetectStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_liRqCreatedPersonId.htm"/>
    public virtual int liRqCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_ManualRq.htm"/>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_txtCollector.htm"/>
    public virtual string txtCollector { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_txtDescription.htm"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect_txtShareRq.htm"/>
    public virtual string txtShareRq { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect__ctor.htm"/>
    public vLastEvaluatedSwDetect() { }
}
