using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping properties to system functions.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html"/>
[Table("dbo.tblSetting")]
public class tblSetting {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html#Alvao_API_Common_Model_Database_tblSetting_intValue"/>
    public virtual int? intValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html#Alvao_API_Common_Model_Database_tblSetting_txtKey"/>
    [ExplicitKey]
    public virtual string txtKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html#Alvao_API_Common_Model_Database_tblSetting_txtValue"/>
    public virtual string txtValue { get; set; }
}
