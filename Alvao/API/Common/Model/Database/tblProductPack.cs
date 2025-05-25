using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of software products packages (software products library).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html"/>
[Table("dbo.tblProductPack")]
public class tblProductPack {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_bolValid"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_dteTimeStamp"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_lintProductId"/>
    [ExplicitKey]
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_lintProductPackId"/>
    public virtual int lintProductPackId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_txtCertifiedBy"/>
    public virtual string txtCertifiedBy { get; set; }
}
