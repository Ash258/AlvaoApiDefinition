using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// View settings table
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ProfileValue.htm"/>
[TableAttribute("dbo.ProfileValue")]
public class ProfileValue
{
    public virtual bool Backup { get; set; }
    /// <summary>Int settings value</summary>
    public virtual int? IntValue { get; set; }
    /// <summary>Foreign key to table tPerson - iPersonId. Specifies the settings "owner"</summary>
    [ExplicitKeyAttribute]
    public virtual int PersonId { get; set; }
    /// <summary>String settings value</summary>
    public virtual string StringValue { get; set; }
    /// <summary>Name of settings including path used in registries. The path is provided for the purpose of product identification</summary>
    public virtual string ValueName { get; set; }

    public ProfileValue() { }
}
