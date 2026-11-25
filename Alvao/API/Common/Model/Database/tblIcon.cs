using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Icons.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIcon.html"/>
[Table("dbo.tblIcon")]
public class tblIcon {
    /// <summary>Enumeration of system icon uids.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIcon.IconUid.html#fields"/>
    public enum IconUid {
        HwCard = 10,
        ActiveDir = 107,
        Subnet = 134,
    }

    /// <summary>Icon in SVG format</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIcon.html#Alvao_API_Common_Model_Database_tblIcon_Svg"/>
    /// <remarks>Column <c>Svg</c>: varbinary, null.</remarks>
    public virtual byte[] Svg { get; set; }
    /// <summary>icon Id</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIcon.html#Alvao_API_Common_Model_Database_tblIcon_intIconId"/>
    /// <remarks>Column <c>intIconId</c>: int, not null.</remarks>
    [Key]
    public virtual int intIconId { get; set; }
    /// <summary>icon name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIcon.html#Alvao_API_Common_Model_Database_tblIcon_txtDesc"/>
    /// <remarks>Column <c>txtDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtDesc { get; set; }
    /// <summary>Unique identifier UID (only system icons)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblIcon.html#Alvao_API_Common_Model_Database_tblIcon_uid"/>
    /// <remarks>Column <c>uid</c>: int, null.</remarks>
    public virtual int? uid { get; set; }
}
