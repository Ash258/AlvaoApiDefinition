using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Approval schemes.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tApprovalSchema.htm"/>
[TableAttribute("dbo.tApprovalSchema")]
public class tApprovalSchema
{
    /// <summary>Automatic approval of steps with the same approver.</summary>
    public virtual bool AutoApproveStepsSameApprover { get; set; }
    public virtual DateTime? dApprovalSchemaCreated { get; set; }
    public virtual DateTime? dApprovalSchemaRemoved { get; set; }
    [KeyAttribute]
    public virtual int iApprovalSchemaId { get; set; }
    public virtual string mApprovalSchemaDescription { get; set; }
    public virtual string sApprovalSchema { get; set; }

    public tApprovalSchema() { }
}
