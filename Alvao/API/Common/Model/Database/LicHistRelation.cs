using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing links between licenses in Asset Management</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html"/>
[Table("dbo.LicHistRelation")]
public class LicHistRelation {
    /// <summary>Initial license link ID. A foreign key on the tblLicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_BeginLicHistId"/>
    /// <remarks>Column <c>BeginLicHistId</c>: int, not null. References <see cref="tblLicHist"/>.</remarks>
    public virtual int BeginLicHistId { get; set; }
    /// <summary>End license link ID. A foreign key on the tblLicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_EndLicHistId"/>
    /// <remarks>Column <c>EndLicHistId</c>: int, not null. References <see cref="tblLicHist"/>.</remarks>
    public virtual int EndLicHistId { get; set; }
    /// <summary>Link type. A foreign key on the LicHistRelationType table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_LicHistRelationTypeId"/>
    /// <remarks>
    /// Column <c>LicHistRelationTypeId</c>: int, not null. References <see cref="LicHistRelationType"/>.
    /// </remarks>
    public virtual int LicHistRelationTypeId { get; set; }
    /// <summary>Person who performed the last link edit.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_ModifiedByPersonId"/>
    /// <remarks>Column <c>ModifiedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int ModifiedByPersonId { get; set; }
    /// <summary>Date of last link edit.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_ModifiedDate"/>
    /// <remarks>Column <c>ModifiedDate</c>: datetime, not null.</remarks>
    public virtual DateTime ModifiedDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
