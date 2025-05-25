using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Marking the record in the ticket log.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActMark.html"/>
[Table("dbo.ActMark")]
public class ActMark {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActMark.ActMarkId.html#fields"/>
    public enum ActMarkId {
        RequestSpecification = 1,
        RequestSolution = 2,
    }
    /// <summary>Record marking name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActMark.html#Alvao_API_Common_Model_Database_ActMark_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ActMark.html#Alvao_API_Common_Model_Database_ActMark_id"/>
    [Key]
    public virtual byte id { get; set; }
}
