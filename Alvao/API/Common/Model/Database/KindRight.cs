using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Security for properties.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_KindRight.htm"/>
[TableAttribute("dbo.KindRight")]
public class KindRight
{
    /// <summary>Permission to change value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindRight_CanModify.htm"/>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindRight_CanRead.htm"/>
    public virtual byte? CanRead { get; set; }
    /// <summary>Object kind ID. The value NULL meals that the permission applies to all object kinds.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindRight_ClassId.htm"/>
    public virtual int? ClassId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindRight_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Property definition ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindRight_KindId.htm"/>
    public virtual int KindId { get; set; }
    /// <summary>Group ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindRight_RoleId.htm"/>
    public virtual int RoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_KindRight__ctor.htm"/>
    public KindRight() { }
}
