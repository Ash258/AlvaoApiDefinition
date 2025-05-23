using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping attributes from AD to AM properties. This configuration is used by ImportAD.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblADMap.htm"/>
[TableAttribute("dbo.tblADMap")]
public class tblADMap {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblADMap_bolKey.htm"/>
    public virtual bool bolKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblADMap_lintClassId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblADMap_lintKindId.htm"/>
    public virtual int? lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblADMap_txtADAttr.htm"/>
    public virtual string txtADAttr { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblADMap_txtADClass.htm"/>
    public virtual string txtADClass { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblADMap__ctor.htm"/>
    public tblADMap() { }
}
