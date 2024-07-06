using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vClass.htm"/>
[TableAttribute("dbo.vClass")]
public class vClass
{
    public virtual bool bComputer { get; set; }
    public virtual int intClassId { get; set; }
    public virtual string txtClass { get; set; }

    public vClass() { }
}
