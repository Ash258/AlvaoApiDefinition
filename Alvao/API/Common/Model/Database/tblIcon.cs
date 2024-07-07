using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Icons.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblIcon.htm"/>
[TableAttribute("dbo.tblIcon")]
public class tblIcon
{
    public enum IconUid
    {
        HwCard = 10,
        Subnet = 134,
    }
    /// <summary>icon Id</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIcon_intIconId.htm"/>
    [KeyAttribute]
    public virtual int intIconId { get; set; }
    /// <summary>icon bitmap</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIcon_oleIcon.htm"/>
    public virtual byte[] oleIcon { get; set; }
    /// <summary>Icon in SVG format</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIcon_Svg.htm"/>
    public virtual byte[] Svg { get; set; }
    /// <summary>icon name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIcon_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }
    /// <summary>Unique identifier UID (only system icons)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblIcon_uid.htm"/>
    public virtual int? uid { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblIcon__ctor.htm"/>
    public tblIcon() { }
}
