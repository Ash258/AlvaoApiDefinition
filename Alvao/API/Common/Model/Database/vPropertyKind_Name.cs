using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Name.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Name.html"/>
[Table("dbo.vPropertyKind_Name")]
public class vPropertyKind_Name {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Name.html#Alvao_API_Common_Model_Database_vPropertyKind_Name_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Name.html#Alvao_API_Common_Model_Database_vPropertyKind_Name_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Name.html#Alvao_API_Common_Model_Database_vPropertyKind_Name_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Name.html#Alvao_API_Common_Model_Database_vPropertyKind_Name_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Name.html#Alvao_API_Common_Model_Database_vPropertyKind_Name_txtValue"/>
    public virtual string txtValue { get; set; }
}
