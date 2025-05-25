using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Active session at ALVAO WebApp.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html"/>
[Table("dbo.WebAppActiveSession")]
public class WebAppActiveSession {
    /// <summary>IP address of the logged in user</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_ClientAddress"/>
    public virtual string ClientAddress { get; set; }
    /// <summary>Date and time of session expiration.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_ExpireDate"/>
    public virtual DateTime ExpireDate { get; set; }
    /// <summary>Signed-in user ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Authentication ticket Id.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_TicketGUID"/>
    public virtual Guid TicketGUID { get; set; }
    /// <summary>Session ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_id"/>
    [Key]
    public virtual int id { get; set; }
}
