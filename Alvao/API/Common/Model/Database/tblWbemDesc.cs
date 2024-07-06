using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Code list of values for the detected HW properties.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemClassDesc.htm"/>
[TableAttribute("dbo.tblWbemClassDesc")]
public class tblWbemClassDesc
{
    public virtual int? intPropValueIndex { get; set; }
    public virtual string txtCLASS { get; set; }
    [ExplicitKeyAttribute]
    public virtual string txtPropName { get; set; }
    public virtual string txtPropValueDesc { get; set; }

    public tblWbemClassDesc() { }
}
