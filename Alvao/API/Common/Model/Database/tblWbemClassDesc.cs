using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Code list of values for the detected HW properties.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemClassDesc.htm"/>
[TableAttribute("dbo.tblWbemClassDesc")]
public class tblWbemClassDesc {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemClassDesc_intPropValueIndex.htm"/>
    public virtual int? intPropValueIndex { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemClassDesc_txtCLASS.htm"/>
    public virtual string txtCLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemClassDesc_txtPropName.htm"/>
    [ExplicitKeyAttribute]
    public virtual string txtPropName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemClassDesc_txtPropValueDesc.htm"/>
    public virtual string txtPropValueDesc { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblWbemClassDesc__ctor.htm"/>
    public tblWbemClassDesc() { }
}
