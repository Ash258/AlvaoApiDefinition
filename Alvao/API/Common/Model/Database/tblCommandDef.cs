using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definitions of commands for the &quot;Administrator's Tools&quot; function.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html"/>
[Table("dbo.tblCommandDef")]
public class tblCommandDef {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_intCommandDefId"/>
    [Key]
    public virtual int intCommandDefId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_intCommandDefUID"/>
    public virtual int? intCommandDefUID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_intGroup"/>
    public virtual int? intGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_txtCommand"/>
    public virtual string txtCommand { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCommandDef.html#Alvao_API_Common_Model_Database_tblCommandDef_txtRunDir"/>
    public virtual string txtRunDir { get; set; }
}
