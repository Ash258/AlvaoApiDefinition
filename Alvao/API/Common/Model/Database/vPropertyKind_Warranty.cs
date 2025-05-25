using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Warranty.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Warranty.html"/>
[Table("dbo.vPropertyKind_Warranty")]
public class vPropertyKind_Warranty {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Warranty.html#Alvao_API_Common_Model_Database_vPropertyKind_Warranty_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Warranty.html#Alvao_API_Common_Model_Database_vPropertyKind_Warranty_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Warranty.html#Alvao_API_Common_Model_Database_vPropertyKind_Warranty_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Warranty.html#Alvao_API_Common_Model_Database_vPropertyKind_Warranty_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Warranty.html#Alvao_API_Common_Model_Database_vPropertyKind_Warranty_txtValue"/>
    public virtual string txtValue { get; set; }
}
