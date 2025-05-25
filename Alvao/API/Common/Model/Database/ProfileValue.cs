using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>View settings table</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html"/>
[Table("dbo.ProfileValue")]
public class ProfileValue {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_Backup"/>
    public virtual bool Backup { get; set; }
    /// <summary>Int settings value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_IntValue"/>
    public virtual int? IntValue { get; set; }
    /// <summary>Foreign key to table tPerson - iPersonId. Specifies the settings &quot;owner&quot;</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_PersonId"/>
    [ExplicitKey]
    public virtual int PersonId { get; set; }
    /// <summary>String settings value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_StringValue"/>
    public virtual string StringValue { get; set; }
    /// <summary>Name of settings including path used in registries. The path is provided for the purpose of product identification</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_ValueName"/>
    public virtual string ValueName { get; set; }
}
