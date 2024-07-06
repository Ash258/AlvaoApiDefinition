using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Products types.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vProductType.htm"/>
[TableAttribute("dbo.vProductType")]
public class vProductType
{
    public virtual int intProductTypeId { get; set; }
    public virtual string txtProductType { get; set; }

    public vProductType() { }
}
