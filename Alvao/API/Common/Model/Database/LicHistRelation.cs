using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing links between licenses in AM Console</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistRelation.htm"/>
[TableAttribute("dbo.LicHistRelation")]
public class LicHistRelation
{
    /// <summary>Initial license link ID. A foreign key on the tblLicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelation_BeginLicHistId.htm"/>
    public virtual int BeginLicHistId { get; set; }
    /// <summary>End license link ID. A foreign key on the tblLicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelation_EndLicHistId.htm"/>
    public virtual int EndLicHistId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelation_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Link type. A foreign key on the LicHistRelationType table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelation_LicHistRelationTypeId.htm"/>
    public virtual int LicHistRelationTypeId { get; set; }
    /// <summary>Person who performed the last link edit.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelation_ModifiedByPersonId.htm"/>
    public virtual int ModifiedByPersonId { get; set; }
    /// <summary>Date of last link edit.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelation_ModifiedDate.htm"/>
    public virtual DateTime ModifiedDate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicHistRelation__ctor.htm"/>
    public LicHistRelation() { }
}
