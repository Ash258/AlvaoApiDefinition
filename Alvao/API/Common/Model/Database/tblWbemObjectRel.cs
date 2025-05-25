using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Links between the detected components of the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectRel.html"/>
[Table("dbo.tblWbemObjectRel")]
public class tblWbemObjectRel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectRel.html#Alvao_API_Common_Model_Database_tblWbemObjectRel_lintWbemObjectId1"/>
    [ExplicitKey]
    public virtual int lintWbemObjectId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectRel.html#Alvao_API_Common_Model_Database_tblWbemObjectRel_lintWbemObjectId2"/>
    public virtual int lintWbemObjectId2 { get; set; }
}
