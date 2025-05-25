using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of languages. Text in tblDict</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLang.html"/>
[Table("dbo.tblLang")]
public class tblLang {
    /// <summary>language Id, e.g. 1029=Czech, 1051=Slovak, 1033=English</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLang.html#Alvao_API_Common_Model_Database_tblLang_intLangId"/>
    [ExplicitKey]
    public virtual int intLangId { get; set; }
}
