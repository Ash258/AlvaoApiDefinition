using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Properties of objects which are downloaded from AD.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyFromAD.htm"/>
[TableAttribute("dbo.vPropertyFromAD")]
public class vPropertyFromAD
{
    public virtual int bCanModify { get; set; }
    public virtual int bFromAD { get; set; }
    public virtual int intNodeId { get; set; }
    public virtual int intPropertyId { get; set; }

    public vPropertyFromAD() { }
}
