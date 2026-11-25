using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Connection to MS SCCM</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html"/>
[Table("dbo.SccmConnection")]
public class SccmConnection {
    /// <summary>
    /// URL of the web application registered in Azura used to connect via the Cloud Management Gateway.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_ApplicationUri"/>
    /// <remarks>Column <c>ApplicationUri</c>: nvarchar(2048), null.</remarks>
    public virtual string ApplicationUri { get; set; }
    /// <summary>
    /// GUID of the native client application registered in Azure. Required when connecting via Cloud Management
    /// Gateway.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_ClientId"/>
    /// <remarks>Column <c>ClientId</c>: nvarchar(255), null.</remarks>
    public virtual string ClientId { get; set; }
    /// <summary>Connection string for the SCCM database</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_ConnectionString"/>
    /// <remarks>Column <c>ConnectionString</c>: nvarchar(2048), null.</remarks>
    public virtual string ConnectionString { get; set; }
    /// <summary>User password</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_Password"/>
    /// <remarks>Column <c>Password</c>: nvarchar(32), null.</remarks>
    public virtual string Password { get; set; }
    /// <summary>Type of connection (SccmConnectionKind.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_SccmConnectionKindId"/>
    /// <remarks>
    /// Column <c>SccmConnectionKindId</c>: int, not null. References <see cref="SccmConnectionKind"/>.
    /// </remarks>
    public virtual int SccmConnectionKindId { get; set; }
    /// <summary>
    /// URL of the access point for the native client application used to obtain an authorisation token for connecting
    /// via the Cloud Management Gateway.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_TokenEndpoint"/>
    /// <remarks>Column <c>TokenEndpoint</c>: nvarchar(2048), null.</remarks>
    public virtual string TokenEndpoint { get; set; }
    /// <summary>Administration Service URL</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_Url"/>
    /// <remarks>Column <c>Url</c>: nvarchar(2048), null.</remarks>
    public virtual string Url { get; set; }
    /// <summary>Login name for connecting to Administration Service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_Username"/>
    /// <remarks>Column <c>Username</c>: nvarchar(32), null.</remarks>
    public virtual string Username { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnection.html#Alvao_API_Common_Model_Database_SccmConnection_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
