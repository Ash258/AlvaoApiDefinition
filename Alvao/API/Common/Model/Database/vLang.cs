using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Languages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLang.html"/>
[Table("dbo.vLang")]
public class vLang {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLang.html#Alvao_API_Common_Model_Database_vLang_intNameLangId"/>
    public virtual int? intNameLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLang.html#Alvao_API_Common_Model_Database_vLang_txtLang"/>
    public virtual string txtLang { get; set; }
}
