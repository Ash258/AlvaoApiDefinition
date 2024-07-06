using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rooms, see item Request.Room.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tRoom.htm"/>
[TableAttribute("dbo.tRoom")]
public class tRoom
{
    [KeyAttribute]
    public virtual int iRoomId { get; set; }
    public virtual int? liRoomBuildingId { get; set; }
    public virtual string sRoom { get; set; }
    public virtual string sRoomFloor { get; set; }
    public virtual string sRoomKind { get; set; }

    public tRoom() { }
}
