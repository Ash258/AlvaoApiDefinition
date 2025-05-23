using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>View settings table</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ProfileValue.htm"/>
[TableAttribute("dbo.ProfileValue")]
public class ProfileValue {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProfileValue_Backup.htm"/>
    public virtual bool Backup { get; set; }
    /// <summary>Int settings value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProfileValue_IntValue.htm"/>
    public virtual int? IntValue { get; set; }
    /// <summary>Foreign key to table tPerson - iPersonId. Specifies the settings "owner"</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProfileValue_PersonId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int PersonId { get; set; }
    /// <summary>String settings value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProfileValue_StringValue.htm"/>
    public virtual string StringValue { get; set; }
    /// <summary>Name of settings including path used in registries. The path is provided for the purpose of product identification</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProfileValue_ValueName.htm"/>
    public virtual string ValueName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ProfileValue__ctor.htm"/>
    public ProfileValue() { }
}
