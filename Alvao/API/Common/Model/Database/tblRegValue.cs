using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection - values of detected records from the register.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html"/>
[Table("dbo.tblRegValue")]
public class tblRegValue {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_intRegValueId"/>
    /// <remarks>Column <c>intRegValueId</c>: int, not null.</remarks>
    [Key]
    public virtual int intRegValueId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, not null. References <see cref="tblDetect"/>.</remarks>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_lintRootRegKeyId"/>
    /// <remarks>Column <c>lintRootRegKeyId</c>: int, not null.</remarks>
    public virtual int lintRootRegKeyId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), null.</remarks>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_txtPath"/>
    /// <remarks>Column <c>txtPath</c>: nvarchar(255), null.</remarks>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_txtValue"/>
    /// <remarks>Column <c>txtValue</c>: nvarchar(255), null.</remarks>
    public virtual string txtValue { get; set; }
}
