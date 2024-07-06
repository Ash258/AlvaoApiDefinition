using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Hardware "Blacklist".
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemObjectProcess.htm"/>
[TableAttribute("dbo.tblWbemObjectProcess")]
public class tblWbemObjectProcess
{
    public virtual bool bolClearObjectProp { get; set; }
    public virtual bool bolSetObjectAsVirtual { get; set; }
    [ExplicitKeyAttribute]
    public virtual string txtCLASS { get; set; }
    public virtual string txtPropName { get; set; }
    public virtual string txtPropValue { get; set; }

    public tblWbemObjectProcess() { }
}
