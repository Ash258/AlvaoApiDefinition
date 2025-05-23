using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Scheduled evaluation of HW and SW by detection.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetectAction.htm"/>
[TableAttribute("dbo.tblDetectAction")]
public class tblDetectAction {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectAction_intDetectActionId.htm"/>
    [KeyAttribute]
    public virtual int intDetectActionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectAction_lintDetectActionKindId.htm"/>
    public virtual int lintDetectActionKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectAction_lintDetectId.htm"/>
    public virtual int lintDetectId { get; set; }
    /// <summary>If the value is 1, the ticket was created manually by the Evaluate immediately command.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectAction_ManualRq.htm"/>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectAction_txtCollector.htm"/>
    public virtual string txtCollector { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDetectAction__ctor.htm"/>
    public tblDetectAction() { }
}
