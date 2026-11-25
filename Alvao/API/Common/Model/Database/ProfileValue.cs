using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>View settings table</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html"/>
[Table("dbo.ProfileValue")]
public class ProfileValue {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_Backup"/>
    /// <remarks>Column <c>Backup</c>: bit, not null.</remarks>
    public virtual bool Backup { get; set; }
    /// <summary>Int settings value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_IntValue"/>
    /// <remarks>Column <c>IntValue</c>: int, null.</remarks>
    public virtual int? IntValue { get; set; }
    /// <summary>Foreign key to table tPerson - iPersonId. Specifies the settings &quot;owner&quot;</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    [ExplicitKey]
    public virtual int PersonId { get; set; }
    /// <summary>String settings value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_StringValue"/>
    /// <remarks>Column <c>StringValue</c>: nvarchar(max), null.</remarks>
    public virtual string StringValue { get; set; }
    /// <summary>
    /// Name of settings including path used in registries. The path is provided for the purpose of product
    /// identification
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProfileValue.html#Alvao_API_Common_Model_Database_ProfileValue_ValueName"/>
    /// <remarks>Column <c>ValueName</c>: nvarchar(max), not null.</remarks>
    public virtual string ValueName { get; set; }
}
