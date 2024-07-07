using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Hardware "Blacklist".</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemObjectProcess.htm"/>
[TableAttribute("dbo.tblWbemObjectProcess")]
public class tblWbemObjectProcess
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectProcess_bolClearObjectProp.htm"/>
    public virtual bool bolClearObjectProp { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectProcess_bolSetObjectAsVirtual.htm"/>
    public virtual bool bolSetObjectAsVirtual { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtCLASS.htm"/>
    [ExplicitKeyAttribute]
    public virtual string txtCLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtPropName.htm"/>
    public virtual string txtPropName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtPropValue.htm"/>
    public virtual string txtPropValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblWbemObjectProcess__ctor.htm"/>
    public tblWbemObjectProcess() { }
}
