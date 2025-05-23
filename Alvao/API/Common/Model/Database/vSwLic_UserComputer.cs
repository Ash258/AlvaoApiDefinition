using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users' computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwLic_UserComputer.htm"/>
[TableAttribute("dbo.vSwLic_UserComputer")]
public class vSwLic_UserComputer
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_UserComputer_ComputerId.htm"/>
    public virtual int ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_UserComputer_LicHistId.htm"/>
    public virtual int LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_UserComputer_LicProductId.htm"/>
    public virtual int LicProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_UserComputer_ProductId.htm"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_UserComputer_UserId.htm"/>
    public virtual int? UserId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwLic_UserComputer__ctor.htm"/>
    public vSwLic_UserComputer() { }
}
