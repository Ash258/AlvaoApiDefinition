using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - BIOS serial number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_BIOSSerialNumber.html"/>
[Table("dbo.vPropertyKind_BIOSSerialNumber")]
public class vPropertyKind_BIOSSerialNumber {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_BIOSSerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_BIOSSerialNumber_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_BIOSSerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_BIOSSerialNumber_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_BIOSSerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_BIOSSerialNumber_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_BIOSSerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_BIOSSerialNumber_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_BIOSSerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_BIOSSerialNumber_txtValue"/>
    public virtual string txtValue { get; set; }
}
