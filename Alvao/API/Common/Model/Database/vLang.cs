using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Languages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLang.htm"/>
[TableAttribute("dbo.vLang")]
public class vLang
{
    public virtual int? intNameLangId { get; set; }
    public virtual string txtLang { get; set; }

    public vLang() { }
}
