using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Property entrusted to me - services which should be displayed in the service offer on the pages of objects of a certain type.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets.htm"/>
[TableAttribute("dbo.HdSectionNodeClassMyAssets")]
public class HdSectionNodeClassMyAssets
{
    /// <summary>The service (tHdSection.iHdSectionId) which should be displayed on the object pages.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets_HdSectionId.htm"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>The class of objects (tblClass.intClassId) whose website should display the service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets_NodeClassId.htm"/>
    public virtual int NodeClassId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets__ctor.htm"/>
    public HdSectionNodeClassMyAssets() { }
}
