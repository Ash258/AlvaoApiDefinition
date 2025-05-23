using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Active session at ALVAO WebApp.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_WebAppActiveSession.htm"/>
[TableAttribute("dbo.WebAppActiveSession")]
public class WebAppActiveSession
{
    /// <summary>IP address of the logged in user</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebAppActiveSession_ClientAddress.htm"/>
    public virtual string ClientAddress { get; set; }
    /// <summary>Date and time of session expiration.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebAppActiveSession_ExpireDate.htm"/>
    public virtual DateTime ExpireDate { get; set; }
    /// <summary>Session ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebAppActiveSession_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Signed-in user ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebAppActiveSession_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Authentication ticket Id.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebAppActiveSession_TicketGUID.htm"/>
    public virtual Guid TicketGUID { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_WebAppActiveSession__ctor.htm"/>
    public WebAppActiveSession() { }
}
