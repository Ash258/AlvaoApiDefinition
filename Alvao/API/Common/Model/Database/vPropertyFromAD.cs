using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Properties of objects which are downloaded from AD.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyFromAD.htm"/>
[TableAttribute("dbo.vPropertyFromAD")]
public class vPropertyFromAD
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyFromAD_bCanModify.htm"/>
    public virtual int bCanModify { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyFromAD_bFromAD.htm"/>
    public virtual int bFromAD { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyFromAD_intNodeId.htm"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyFromAD_intPropertyId.htm"/>
    public virtual int intPropertyId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPropertyFromAD__ctor.htm"/>
    public vPropertyFromAD() { }
}
