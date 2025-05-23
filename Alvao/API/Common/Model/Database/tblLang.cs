using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of languages. Text in tblDict</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblLang.htm"/>
[TableAttribute("dbo.tblLang")]
public class tblLang {
    /// <summary>language Id, e.g. 1029=Czech, 1051=Slovak, 1033=English</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblLang_intLangId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intLangId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblLang__ctor.htm"/>
    public tblLang() { }
}
