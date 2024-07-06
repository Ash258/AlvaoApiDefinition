using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// People types. Normal users =1, system users &gt;1.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonBehavior.htm"/>
[TableAttribute("dbo.PersonBehavior")]
public class PersonBehavior
{
    /// <summary>Description of the system person type.</summary>
    public virtual string Description { get; set; }
    /// <summary>Record ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public PersonBehavior() { }
}
