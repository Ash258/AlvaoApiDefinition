using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Scheduled evaluation of HW and SW by detection.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetectAction.htm"/>
[TableAttribute("dbo.tblDetectAction")]
public class tblDetectAction
{
    [KeyAttribute]
    public virtual int intDetectActionId { get; set; }
    public virtual int lintDetectActionKindId { get; set; }
    public virtual int lintDetectId { get; set; }
    /// <summary>If the value is 1, the ticket was created manually by the Evaluate immediately command.</summary>
    public virtual bool ManualRq { get; set; }
    public virtual string txtCollector { get; set; }

    public tblDetectAction() { }
}
