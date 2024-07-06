using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Mapping properties to system functions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblSetting.htm"/>
[TableAttribute("dbo.tblSetting")]
public class tblSetting
{
    public virtual int? intValue { get; set; }
    [ExplicitKeyAttribute]
    public virtual string txtKey { get; set; }
    public virtual string txtValue { get; set; }

    public tblSetting() { }
}
