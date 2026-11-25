using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Approval schemes.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html"/>
[Table("dbo.tApprovalSchema")]
public class tApprovalSchema {
    /// <summary>Automatic approval of steps with the same approver.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_AutoApproveStepsSameApprover"/>
    /// <remarks>Column <c>AutoApproveStepsSameApprover</c>: bit, not null.</remarks>
    public virtual bool AutoApproveStepsSameApprover { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_dApprovalSchemaCreated"/>
    /// <remarks>Column <c>dApprovalSchemaCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dApprovalSchemaCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_dApprovalSchemaRemoved"/>
    /// <remarks>Column <c>dApprovalSchemaRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dApprovalSchemaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_iApprovalSchemaId"/>
    /// <remarks>Column <c>iApprovalSchemaId</c>: int, not null.</remarks>
    [Key]
    public virtual int iApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_mApprovalSchemaDescription"/>
    /// <remarks>Column <c>mApprovalSchemaDescription</c>: nvarchar(max), null.</remarks>
    public virtual string mApprovalSchemaDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_sApprovalSchema"/>
    /// <remarks>Column <c>sApprovalSchema</c>: nvarchar(255), null.</remarks>
    public virtual string sApprovalSchema { get; set; }
}
