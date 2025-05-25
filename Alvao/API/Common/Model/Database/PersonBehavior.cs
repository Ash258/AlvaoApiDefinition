using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>People types. Normal users =1, system users &gt;1.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonBehavior.html"/>
[Table("dbo.PersonBehavior")]
public class PersonBehavior {
    /// <summary>Description of the system person type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonBehavior.html#Alvao_API_Common_Model_Database_PersonBehavior_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonBehavior.html#Alvao_API_Common_Model_Database_PersonBehavior_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
