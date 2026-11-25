using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definitions of commands for the &quot;Administrator's Tools&quot; function.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html"/>
[Table("dbo.tblCommandDef")]
public class tblCommandDef {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_intCommandDefId"/>
    /// <remarks>Column <c>intCommandDefId</c>: int, not null.</remarks>
    [Key]
    public virtual int intCommandDefId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_intCommandDefUID"/>
    /// <remarks>Column <c>intCommandDefUID</c>: int, null.</remarks>
    public virtual int? intCommandDefUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_intGroup"/>
    /// <remarks>Column <c>intGroup</c>: int, null.</remarks>
    public virtual int? intGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_txtCommand"/>
    /// <remarks>Column <c>txtCommand</c>: nvarchar(255), not null.</remarks>
    public virtual string txtCommand { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), not null.</remarks>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_txtRunDir"/>
    /// <remarks>Column <c>txtRunDir</c>: nvarchar(255), null.</remarks>
    public virtual string txtRunDir { get; set; }
}
