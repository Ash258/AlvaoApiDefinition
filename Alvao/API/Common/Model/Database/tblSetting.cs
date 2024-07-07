using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Mapping properties to system functions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblSetting.htm"/>
[TableAttribute("dbo.tblSetting")]
public class tblSetting
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblSetting_intValue.htm"/>
    public virtual int? intValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblSetting_txtKey.htm"/>
    [ExplicitKeyAttribute]
    public virtual string txtKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblSetting_txtValue.htm"/>
    public virtual string txtValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblSetting__ctor.htm"/>
    public tblSetting() { }
}
