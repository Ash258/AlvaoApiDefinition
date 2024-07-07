using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Marking the record in the ticket log.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ActMark.htm"/>
[TableAttribute("dbo.ActMark")]
public class ActMark
{
    public enum ActMarkId
    {
        RequestSpecification = 1,
        RequestSolution = 2,
    }

    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual byte id { get; set; }
    /// <summary>Record marking name</summary>
    public virtual string Name { get; set; }

    public ActMark() { }
}
