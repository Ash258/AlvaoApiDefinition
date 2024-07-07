using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Connection to MS SCCM</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SccmConnection.htm"/>
[TableAttribute("dbo.SccmConnection")]
public class SccmConnection
{
    /// <summary>URL of the web application registered in Azura used to connect via the Cloud Management Gateway.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_ApplicationUri.htm"/>
    public virtual string ApplicationUri { get; set; }
    /// <summary>GUID of the native client application registered in Azure. Required when connecting via Cloud Management Gateway.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_ClientId.htm"/>
    public virtual string ClientId { get; set; }
    /// <summary>Connection string for the SCCM database</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_ConnectionString.htm"/>
    public virtual string ConnectionString { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>User password</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_Password.htm"/>
    public virtual string Password { get; set; }
    /// <summary>Type of connection (SccmConnectionKind.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_SccmConnectionKindId.htm"/>
    public virtual int SccmConnectionKindId { get; set; }
    /// <summary>URL of the access point for the native client application used to obtain an authorisation token for connecting via the Cloud Management Gateway.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_TokenEndpoint.htm"/>
    public virtual string TokenEndpoint { get; set; }
    /// <summary>Administration Service URL</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_Url.htm"/>
    public virtual string Url { get; set; }
    /// <summary>Login name for connecting to Administration Service</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SccmConnection_Username.htm"/>
    public virtual string Username { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SccmConnection__ctor.htm"/>
    public SccmConnection() { }
}
