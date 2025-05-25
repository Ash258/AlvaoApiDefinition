using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users' computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_UserComputer.html"/>
[Table("dbo.vSwLic_UserComputer")]
public class vSwLic_UserComputer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_UserComputer.html#Alvao_API_Common_Model_Database_vSwLic_UserComputer_ComputerId"/>
    public virtual int ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_UserComputer.html#Alvao_API_Common_Model_Database_vSwLic_UserComputer_LicHistId"/>
    public virtual int LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_UserComputer.html#Alvao_API_Common_Model_Database_vSwLic_UserComputer_LicProductId"/>
    public virtual int LicProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_UserComputer.html#Alvao_API_Common_Model_Database_vSwLic_UserComputer_ProductId"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_UserComputer.html#Alvao_API_Common_Model_Database_vSwLic_UserComputer_UserId"/>
    public virtual int? UserId { get; set; }
}
