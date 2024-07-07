using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definitions of commands for the "Administrator's Tools" function.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblCommandDef.htm"/>
[TableAttribute("dbo.tblCommandDef")]
public class tblCommandDef
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblCommandDef_intCommandDefId.htm"/>
    [KeyAttribute]
    public virtual int intCommandDefId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblCommandDef_intCommandDefUID.htm"/>
    public virtual int? intCommandDefUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblCommandDef_intGroup.htm"/>
    public virtual int? intGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblCommandDef_txtCommand.htm"/>
    public virtual string txtCommand { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblCommandDef_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblCommandDef_txtRunDir.htm"/>
    public virtual string txtRunDir { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblCommandDef__ctor.htm"/>
    public tblCommandDef() { }
}
