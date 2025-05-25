using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects which are downloaded from AD.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyFromAD.html"/>
[Table("dbo.vPropertyFromAD")]
public class vPropertyFromAD {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyFromAD.html#Alvao_API_Common_Model_Database_vPropertyFromAD_KindId"/>
    public virtual int KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyFromAD.html#Alvao_API_Common_Model_Database_vPropertyFromAD_bCanModify"/>
    public virtual int bCanModify { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyFromAD.html#Alvao_API_Common_Model_Database_vPropertyFromAD_bFromAD"/>
    public virtual int bFromAD { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyFromAD.html#Alvao_API_Common_Model_Database_vPropertyFromAD_intNodeId"/>
    public virtual int intNodeId { get; set; }
}
