using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The user's link in the object tree to the user in the Administration service (tPerson.Link based on///           priority:1. AD GUID2. Personal number3. Login name4. E-mail
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAssetUserPerson.htm"/>
[TableAttribute("dbo.vAssetUserPerson")]
public class vAssetUserPerson
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetUserPerson_NodeId.htm"/>
    public virtual int NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetUserPerson_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetUserPerson_PersonManagerId.htm"/>
    public virtual int? PersonManagerId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vAssetUserPerson__ctor.htm"/>
    public vAssetUserPerson() { }
}
