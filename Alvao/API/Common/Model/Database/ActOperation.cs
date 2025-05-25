using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of process in the ticket log</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.html"/>
[Table("dbo.ActOperation")]
public class ActOperation {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.ActOperationId.html#fields"/>
    public enum ActOperationId {
        ApprovalEnter = 14,
        ApprovalResult = 13,
        AssignedToSolver = 2,
        ChangeStatus = 1,
        Closed = 11,
        DeadlineCancelled = 7,
        DeadlineChange = 5,
        DeadlineSet = 6,
        MergeRequests = 12,
        MovedToService = 10,
        Reopened = 4,
        Resolved = 3,
        ReturnedToOperator = 9,
        SlaChanged = 8,
    }
    /// <summary>Process kind name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.html#Alvao_API_Common_Model_Database_ActOperation_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.html#Alvao_API_Common_Model_Database_ActOperation_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
