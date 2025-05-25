using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Office.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Office.html"/>
[Table("dbo.vPropertyKind_Office")]
public class vPropertyKind_Office {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Office.html#Alvao_API_Common_Model_Database_vPropertyKind_Office_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Office.html#Alvao_API_Common_Model_Database_vPropertyKind_Office_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Office.html#Alvao_API_Common_Model_Database_vPropertyKind_Office_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Office.html#Alvao_API_Common_Model_Database_vPropertyKind_Office_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Office.html#Alvao_API_Common_Model_Database_vPropertyKind_Office_txtValue"/>
    public virtual string txtValue { get; set; }
}
