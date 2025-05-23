using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Approval schemes.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tApprovalSchema.htm"/>
[TableAttribute("dbo.tApprovalSchema")]
public class tApprovalSchema {
    /// <summary>Automatic approval of steps with the same approver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchema_AutoApproveStepsSameApprover.htm"/>
    public virtual bool AutoApproveStepsSameApprover { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchema_dApprovalSchemaCreated.htm"/>
    public virtual DateTime? dApprovalSchemaCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchema_dApprovalSchemaRemoved.htm"/>
    public virtual DateTime? dApprovalSchemaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchema_iApprovalSchemaId.htm"/>
    [KeyAttribute]
    public virtual int iApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchema_mApprovalSchemaDescription.htm"/>
    public virtual string mApprovalSchemaDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchema_sApprovalSchema.htm"/>
    public virtual string sApprovalSchema { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tApprovalSchema__ctor.htm"/>
    public tApprovalSchema() { }
}
