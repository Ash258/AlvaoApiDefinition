using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Automatic replies statuses.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesStatus.html"/>
[Table("dbo.AutomaticRepliesStatus")]
public class AutomaticRepliesStatus {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesStatus.Status.html#fields"/>
    public enum Status {
        Disabled = 1,
        AlwaysEnabled = 2,
        Scheduled = 3,
    }

    /// <summary>Record ID: 1 - Disabled 2 - Always enabled 3 - Scheduled</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesStatus.html#Alvao_API_Common_Model_Database_AutomaticRepliesStatus_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Status name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesStatus.html#Alvao_API_Common_Model_Database_AutomaticRepliesStatus_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesStatus.html#Alvao_API_Common_Model_Database_AutomaticRepliesStatus_GetDbStatus_System_Nullable_Microsoft_Graph_Models_AutomaticRepliesStatus__"/>
    public static AutomaticRepliesStatus.Status GetDbStatus(AutomaticRepliesStatus? status) { throw new NotImplementedException(); }
}
