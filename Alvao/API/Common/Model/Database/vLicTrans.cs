using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Shared licenses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicTrans.html"/>
[Table("dbo.vLicTrans")]
public class vLicTrans {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicTrans.html#Alvao_API_Common_Model_Database_vLicTrans_LicNodeId"/>
    public virtual int LicNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicTrans.html#Alvao_API_Common_Model_Database_vLicTrans_NodeId"/>
    public virtual int NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicTrans.html#Alvao_API_Common_Model_Database_vLicTrans_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicTrans.html#Alvao_API_Common_Model_Database_vLicTrans_txtDesc"/>
    public virtual string txtDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicTrans.html#Alvao_API_Common_Model_Database_vLicTrans_txtLicComputer"/>
    public virtual string txtLicComputer { get; set; }
}
