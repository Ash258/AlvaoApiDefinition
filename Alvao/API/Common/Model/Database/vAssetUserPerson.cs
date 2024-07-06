using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The user's link in the object tree to the user in the Administration service (tPerson.Link based on///           priority:1. AD GUID2. Personal number3. Login name4. E-mail
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAssetUserPerson.htm"/>
[TableAttribute("dbo.vAssetUserPerson")]
public class vAssetUserPerson
{
    public virtual int NodeId { get; set; }
    public virtual int PersonId { get; set; }
    public virtual int? PersonManagerId { get; set; }

    public vAssetUserPerson() { }
}
