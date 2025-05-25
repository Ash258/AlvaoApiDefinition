using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing links between licenses in Asset Management</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html"/>
[Table("dbo.LicHistRelation")]
public class LicHistRelation {
    /// <summary>Initial license link ID. A foreign key on the tblLicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_BeginLicHistId"/>
    public virtual int BeginLicHistId { get; set; }
    /// <summary>End license link ID. A foreign key on the tblLicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_EndLicHistId"/>
    public virtual int EndLicHistId { get; set; }
    /// <summary>Link type. A foreign key on the LicHistRelationType table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_LicHistRelationTypeId"/>
    public virtual int LicHistRelationTypeId { get; set; }
    /// <summary>Person who performed the last link edit.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_ModifiedByPersonId"/>
    public virtual int ModifiedByPersonId { get; set; }
    /// <summary>Date of last link edit.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_ModifiedDate"/>
    public virtual DateTime ModifiedDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelation.html#Alvao_API_Common_Model_Database_LicHistRelation_id"/>
    [Key]
    public virtual int id { get; set; }
}
