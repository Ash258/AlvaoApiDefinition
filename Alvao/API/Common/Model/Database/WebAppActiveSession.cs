using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Active session at ALVAO WebApp.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html"/>
[Table("dbo.WebAppActiveSession")]
public class WebAppActiveSession {
    /// <summary>IP address of the logged in user</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_ClientAddress"/>
    /// <remarks>Column <c>ClientAddress</c>: nvarchar(50), null.</remarks>
    public virtual string ClientAddress { get; set; }
    /// <summary>Date and time of session expiration.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_ExpireDate"/>
    /// <remarks>Column <c>ExpireDate</c>: datetime, not null.</remarks>
    public virtual DateTime ExpireDate { get; set; }
    /// <summary>Signed-in user ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>Authentication ticket Id.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_TicketGUID"/>
    /// <remarks>Column <c>TicketGUID</c>: uniqueidentifier, not null.</remarks>
    public virtual Guid TicketGUID { get; set; }
    /// <summary>Session ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebAppActiveSession.html#Alvao_API_Common_Model_Database_WebAppActiveSession_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
