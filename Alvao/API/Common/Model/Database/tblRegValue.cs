using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection - values of detected records from the register.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html"/>
[Table("dbo.tblRegValue")]
public class tblRegValue {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_intRegValueId"/>
    [Key]
    public virtual int intRegValueId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_lintRootRegKeyId"/>
    public virtual int lintRootRegKeyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_txtPath"/>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegValue.html#Alvao_API_Common_Model_Database_tblRegValue_txtValue"/>
    public virtual string txtValue { get; set; }
}
