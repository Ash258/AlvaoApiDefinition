using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Users' computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwLic_UserComputer.htm"/>
[TableAttribute("dbo.vSwLic_UserComputer")]
public class vSwLic_UserComputer
{
    public virtual int ComputerId { get; set; }
    public virtual int LicHistId { get; set; }
    public virtual int LicProductId { get; set; }
    public virtual int ProductId { get; set; }
    public virtual int? UserId { get; set; }

    public vSwLic_UserComputer() { }
}
