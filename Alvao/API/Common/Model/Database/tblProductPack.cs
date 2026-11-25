using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of software product packages (software product library).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html"/>
[Table("dbo.tblProductPack")]
public class tblProductPack {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_bolValid"/>
    /// <remarks>Column <c>bolValid</c>: bit, not null.</remarks>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_dteTimeStamp"/>
    /// <remarks>Column <c>dteTimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_intFlags"/>
    /// <remarks>Column <c>intFlags</c>: int, null.</remarks>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    [ExplicitKey]
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_lintProductPackId"/>
    /// <remarks>Column <c>lintProductPackId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int lintProductPackId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductPack.html#Alvao_API_Common_Model_Database_tblProductPack_txtCertifiedBy"/>
    /// <remarks>Column <c>txtCertifiedBy</c>: nvarchar(255), null.</remarks>
    public virtual string txtCertifiedBy { get; set; }
}
