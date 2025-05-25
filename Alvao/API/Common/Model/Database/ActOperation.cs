using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of process in the ticket log</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.html"/>
[Table("dbo.ActOperation")]
public class ActOperation {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.ActOperationId.html#fields"/>
    public enum ActOperationId {
        ChangeStatus = 1,
        AssignedToSolver = 2,
        Resolved = 3,
        Reopened = 4,
        DeadlineChange = 5,
        DeadlineSet = 6,
        DeadlineCancelled = 7,
        SlaChanged = 8,
        ReturnedToOperator = 9,
        MovedToService = 10,
        Closed = 11,
        MergeRequests = 12,
        ApprovalResult = 13,
        ApprovalEnter = 14,
    }
    /// <summary>Process kind name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.html#Alvao_API_Common_Model_Database_ActOperation_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActOperation.html#Alvao_API_Common_Model_Database_ActOperation_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
