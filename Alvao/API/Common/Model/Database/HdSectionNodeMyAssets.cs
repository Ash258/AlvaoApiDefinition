using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Property entrusted to me - services which should be displayed in the service offer on the pages of objects of///           a certain type.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets.htm"/>
[TableAttribute("dbo.HdSectionNodeClassMyAssets")]
public class HdSectionNodeClassMyAssets
{
    /// <summary>The service (tHdSection.iHdSectionId) which should be displayed on the object pages.</summary>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>The class of objects (tblClass.intClassId) whose website should display the service.</summary>
    public virtual int NodeClassId { get; set; }

    public HdSectionNodeClassMyAssets() { }
}
