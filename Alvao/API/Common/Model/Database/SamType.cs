using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification type - Audit: yes, no, via e-mail.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html"/>
[Table("dbo.SamType")]
public class SamType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html#Alvao_API_Common_Model_Database_SamType_Desc"/>
    public virtual string Desc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html#Alvao_API_Common_Model_Database_SamType_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html#Alvao_API_Common_Model_Database_SamType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
