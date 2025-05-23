using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of process in the ticket log</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ActOperation.htm"/>
[TableAttribute("dbo.ActOperation")]
public class ActOperation {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ActOperation_ActOperationId.htm"/>
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
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ActOperation_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Process kind name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ActOperation_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ActOperation__ctor.htm"/>
    public ActOperation() { }
}
