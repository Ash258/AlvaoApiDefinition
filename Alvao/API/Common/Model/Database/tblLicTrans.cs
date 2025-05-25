using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - shared licenses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html"/>
[Table("dbo.tblLicTrans")]
public class tblLicTrans {
    /// <summary>Computer from which the license is shared - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_LicNodeId"/>
    public virtual int LicNodeId { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_NodeId"/>
    public virtual int NodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_lintProductId"/>
    [ExplicitKey]
    public virtual int lintProductId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicTrans.html#Alvao_API_Common_Model_Database_tblLicTrans_txtDesc"/>
    public virtual string txtDesc { get; set; }
}
