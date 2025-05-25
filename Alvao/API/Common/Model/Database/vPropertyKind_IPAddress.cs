using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - IP address.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_IPAddress.html"/>
[Table("dbo.vPropertyKind_IPAddress")]
public class vPropertyKind_IPAddress {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_IPAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_IPAddress_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_IPAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_IPAddress_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_IPAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_IPAddress_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_IPAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_IPAddress_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_IPAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_IPAddress_txtValue"/>
    public virtual string txtValue { get; set; }
}
