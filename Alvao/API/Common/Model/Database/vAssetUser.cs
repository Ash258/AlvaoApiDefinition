using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Users in the object tree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAssetUser.htm"/>
[TableAttribute("dbo.vAssetUser")]
public class vAssetUser
{
    public virtual string City { get; set; }
    public virtual string Department { get; set; }
    public virtual string Email { get; set; }
    public virtual int intNodeId { get; set; }
    public virtual bool? IsHidden { get; set; }
    public virtual string Login { get; set; }
    public virtual string Mobile { get; set; }
    public virtual string Office { get; set; }
    public virtual string PersonalNum { get; set; }
    public virtual string Phone { get; set; }
    public virtual string txtLDAPGUID { get; set; }
    public virtual string txtName { get; set; }
    public virtual string User { get; set; }
    public virtual string WorkPosition { get; set; }

    public vAssetUser() { }
}
