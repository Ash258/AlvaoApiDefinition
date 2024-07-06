using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Active session at ALVAO WebApp.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_WebAppActiveSession.htm"/>
[TableAttribute("dbo.WebAppActiveSession")]
public class WebAppActiveSession
{
    /// <summary>IP address of the logged in user</summary>
    public virtual string ClientAddress { get; set; }
    /// <summary>Date and time of session expiration.</summary>
    public virtual DateTime ExpireDate { get; set; }
    /// <summary>Session ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Signed-in user ID.</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Authentication ticket Id.</summary>
    public virtual Guid TicketGUID { get; set; }

    public WebAppActiveSession() { }
}
