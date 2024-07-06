using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SAM notification type - Audit: yes, no, via e-mail.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamType.htm"/>
[TableAttribute("dbo.SamType")]
public class SamType
{
    public virtual string Desc { get; set; }
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    public virtual string Name { get; set; }

    public SamType() { }
}
