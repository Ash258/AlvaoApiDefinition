using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// System settings.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblSystemSetting.htm"/>
[TableAttribute("dbo.tblSystemSetting")]
public class tblSystemSetting
{
    public virtual bool bolDetect_RestrictDetectionCnt { get; set; }
    [ExplicitKeyAttribute]
    public virtual bool bolNode_Rights { get; set; }

    public tblSystemSetting() { }
}
