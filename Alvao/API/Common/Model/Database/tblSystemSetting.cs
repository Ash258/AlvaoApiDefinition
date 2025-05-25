using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System settings.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSystemSetting.html"/>
[Table("dbo.tblSystemSetting")]
public class tblSystemSetting {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSystemSetting.html#Alvao_API_Common_Model_Database_tblSystemSetting_bolDetect_RestrictDetectionCnt"/>
    public virtual bool bolDetect_RestrictDetectionCnt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSystemSetting.html#Alvao_API_Common_Model_Database_tblSystemSetting_bolNode_Rights"/>
    [ExplicitKey]
    public virtual bool bolNode_Rights { get; set; }
}
