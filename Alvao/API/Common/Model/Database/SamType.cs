using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification type - Audit: yes, no, via e-mail.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamType.htm"/>
[TableAttribute("dbo.SamType")]
public class SamType
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamType_Desc.htm"/>
    public virtual string Desc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamType_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamType_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SamType__ctor.htm"/>
    public SamType() { }
}
