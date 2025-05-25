using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Version.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Version.html"/>
[Table("dbo.vPropertyKind_Version")]
public class vPropertyKind_Version {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Version.html#Alvao_API_Common_Model_Database_vPropertyKind_Version_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Version.html#Alvao_API_Common_Model_Database_vPropertyKind_Version_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Version.html#Alvao_API_Common_Model_Database_vPropertyKind_Version_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Version.html#Alvao_API_Common_Model_Database_vPropertyKind_Version_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Version.html#Alvao_API_Common_Model_Database_vPropertyKind_Version_txtValue"/>
    public virtual string txtValue { get; set; }
}
