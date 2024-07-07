using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Object types assigned to services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionNodeClass.htm"/>
[TableAttribute("dbo.HdSectionNodeClass")]
public class HdSectionNodeClass
{
    /// <summary>A service (tHdSection.iHdSectionId) to which the object type is linked.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionNodeClass_HdSectionId.htm"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionNodeClass_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>The object type (tblClass.intClassId) which is linked to the service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionNodeClass_NodeClassId.htm"/>
    public virtual int NodeClassId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionNodeClass__ctor.htm"/>
    public HdSectionNodeClass() { }
}
