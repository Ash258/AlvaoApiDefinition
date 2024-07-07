using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rooms, see item Request.Room.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tRoom.htm"/>
[TableAttribute("dbo.tRoom")]
public class tRoom
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoom_iRoomId.htm"/>
    [KeyAttribute]
    public virtual int iRoomId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoom_liRoomBuildingId.htm"/>
    public virtual int? liRoomBuildingId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoom_sRoom.htm"/>
    public virtual string sRoom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoom_sRoomFloor.htm"/>
    public virtual string sRoomFloor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRoom_sRoomKind.htm"/>
    public virtual string sRoomKind { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tRoom__ctor.htm"/>
    public tRoom() { }
}
