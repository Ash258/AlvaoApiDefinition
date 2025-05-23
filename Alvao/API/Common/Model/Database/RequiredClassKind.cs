using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The table contains properties that must be filled in for the given object types.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RequiredClassKind.htm"/>
[TableAttribute("dbo.RequiredClassKind")]
public class RequiredClassKind
{
    /// <summary>Object kind ID (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RequiredClassKind_ClassId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int ClassId { get; set; }
    /// <summary>Property definition ID (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RequiredClassKind_KindId.htm"/>
    public virtual int KindId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RequiredClassKind__ctor.htm"/>
    public RequiredClassKind() { }
}
