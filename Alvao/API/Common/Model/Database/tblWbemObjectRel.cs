using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Links between the detected components of the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemObjectRel.htm"/>
[TableAttribute("dbo.tblWbemObjectRel")]
public class tblWbemObjectRel
{
    [ExplicitKeyAttribute]
    public virtual int lintWbemObjectId1 { get; set; }
    public virtual int lintWbemObjectId2 { get; set; }

    public tblWbemObjectRel() { }
}
