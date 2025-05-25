using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Approval schemes.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html"/>
[Table("dbo.tApprovalSchema")]
public class tApprovalSchema {
    /// <summary>Automatic approval of steps with the same approver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_AutoApproveStepsSameApprover"/>
    public virtual bool AutoApproveStepsSameApprover { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_dApprovalSchemaCreated"/>
    public virtual DateTime? dApprovalSchemaCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_dApprovalSchemaRemoved"/>
    public virtual DateTime? dApprovalSchemaRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_iApprovalSchemaId"/>
    [Key]
    public virtual int iApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_mApprovalSchemaDescription"/>
    public virtual string mApprovalSchemaDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchema.html#Alvao_API_Common_Model_Database_tApprovalSchema_sApprovalSchema"/>
    public virtual string sApprovalSchema { get; set; }
}
