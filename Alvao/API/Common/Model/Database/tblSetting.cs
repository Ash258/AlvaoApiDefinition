using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping properties to system functions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html"/>
[Table("dbo.tblSetting")]
public class tblSetting {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html#Alvao_API_Common_Model_Database_tblSetting_intValue"/>
    /// <remarks>Column <c>intValue</c>: int, null.</remarks>
    public virtual int? intValue { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html#Alvao_API_Common_Model_Database_tblSetting_txtKey"/>
    /// <remarks>Column <c>txtKey</c>: nvarchar(255), not null.</remarks>
    [ExplicitKey]
    public virtual string txtKey { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblSetting.html#Alvao_API_Common_Model_Database_tblSetting_txtValue"/>
    /// <remarks>Column <c>txtValue</c>: nvarchar(255), null.</remarks>
    public virtual string txtValue { get; set; }
}
