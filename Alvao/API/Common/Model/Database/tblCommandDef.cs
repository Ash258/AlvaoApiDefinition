using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Definitions of commands for the "Administrator's Tools" function.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblCommandDef.htm"/>
[TableAttribute("dbo.tblCommandDef")]
public class tblCommandDef
{
    [KeyAttribute]
    public virtual int intCommandDefId { get; set; }
    public virtual int? intCommandDefUID { get; set; }
    public virtual int? intGroup { get; set; }
    public virtual string txtCommand { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtRunDir { get; set; }

    public tblCommandDef() { }
}
