using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Buildings, see item Request.Building.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBuilding.htm"/>
[TableAttribute("dbo.tBuilding")]
public class tBuilding
{
    [KeyAttribute]
    public virtual int iBuildingId { get; set; }
    public virtual string sBuilding { get; set; }

    public tBuilding() { }
}
