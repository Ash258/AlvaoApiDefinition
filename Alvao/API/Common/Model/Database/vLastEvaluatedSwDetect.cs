using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Last evaluated SW detection on the computer.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLastEvaluatedSwDetect.htm"/>
[TableAttribute("dbo.vLastEvaluatedSwDetect")]
public class vLastEvaluatedSwDetect
{
    public virtual int? DetectSourceMethod { get; set; }
    public virtual DateTime? dteCreated { get; set; }
    public virtual DateTime? dteImported { get; set; }
    public virtual DateTime? dteRqCreated { get; set; }
    public virtual DateTime? dUpdated { get; set; }
    public virtual int intDetectId { get; set; }
    public virtual int lintComputerNodeId { get; set; }
    public virtual int lintDetectKindId { get; set; }
    public virtual int lintDetectStatusId { get; set; }
    public virtual int liRqCreatedPersonId { get; set; }
    public virtual bool ManualRq { get; set; }
    public virtual string txtCollector { get; set; }
    public virtual string txtDescription { get; set; }
    public virtual string txtShareRq { get; set; }

    public vLastEvaluatedSwDetect() { }
}
