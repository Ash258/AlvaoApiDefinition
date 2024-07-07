using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detection - values of detected records from the register.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblRegValue.htm"/>
[TableAttribute("dbo.tblRegValue")]
public class tblRegValue
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegValue_intRegValueId.htm"/>
    [KeyAttribute]
    public virtual int intRegValueId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegValue_lintDetectId.htm"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegValue_lintRootRegKeyId.htm"/>
    public virtual int lintRootRegKeyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegValue_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegValue_txtPath.htm"/>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblRegValue_txtValue.htm"/>
    public virtual string txtValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblRegValue__ctor.htm"/>
    public tblRegValue() { }
}
