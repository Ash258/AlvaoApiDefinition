using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Asset category.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_AssetCategory.html"/>
[Table("dbo.vPropertyKind_AssetCategory")]
public class vPropertyKind_AssetCategory {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_AssetCategory.html#Alvao_API_Common_Model_Database_vPropertyKind_AssetCategory_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_AssetCategory.html#Alvao_API_Common_Model_Database_vPropertyKind_AssetCategory_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_AssetCategory.html#Alvao_API_Common_Model_Database_vPropertyKind_AssetCategory_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_AssetCategory.html#Alvao_API_Common_Model_Database_vPropertyKind_AssetCategory_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_AssetCategory.html#Alvao_API_Common_Model_Database_vPropertyKind_AssetCategory_txtValue"/>
    public virtual string txtValue { get; set; }
}
