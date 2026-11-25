using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - shared licenses.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html"/>
[Table("dbo.tblLicTrans")]
public class tblLicTrans {
    /// <summary>Computer from which the license is shared - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_LicNodeId"/>
    /// <remarks>Column <c>LicNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int LicNodeId { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int NodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    [ExplicitKey]
    public virtual int lintProductId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_txtDesc"/>
    /// <remarks>Column <c>txtDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtDesc { get; set; }
}
