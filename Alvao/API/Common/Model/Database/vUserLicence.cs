using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Drawing of licenses by users</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserLicence.html"/>
[Table("dbo.vUserLicence")]
public class vUserLicence {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserLicence.html#Alvao_API_Common_Model_Database_vUserLicence_LicenceType"/>
    public virtual string LicenceType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserLicence.html#Alvao_API_Common_Model_Database_vUserLicence_LicenceTypeId"/>
    public virtual int? LicenceTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserLicence.html#Alvao_API_Common_Model_Database_vUserLicence_PersonId"/>
    public virtual int PersonId { get; set; }
}
