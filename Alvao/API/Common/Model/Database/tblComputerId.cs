using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// ID of the objects types based on which the computer is identified during the detection of HW and SW.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblComputerIdClass.htm"/>
[TableAttribute("dbo.tblComputerIdClass")]
public class tblComputerIdClass
{
    [ExplicitKeyAttribute]
    public virtual int? lintClassId { get; set; }

    public tblComputerIdClass() { }
}
