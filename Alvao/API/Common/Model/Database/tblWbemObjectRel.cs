using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Links between the detected components of the computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblWbemObjectRel.htm"/>
[TableAttribute("dbo.tblWbemObjectRel")]
public class tblWbemObjectRel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectRel_lintWbemObjectId1.htm"/>
    [ExplicitKeyAttribute]
    public virtual int lintWbemObjectId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblWbemObjectRel_lintWbemObjectId2.htm"/>
    public virtual int lintWbemObjectId2 { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblWbemObjectRel__ctor.htm"/>
    public tblWbemObjectRel() { }
}
