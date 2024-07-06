using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Users that only have the right of reader in the services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vOnlyReader.htm"/>
[TableAttribute("dbo.vOnlyReader")]
public class vOnlyReader
{
    public virtual bool? OnlyReader { get; set; }
    public virtual int PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    public virtual int RequesterRoleId { get; set; }
    public virtual int SectionId { get; set; }

    public vOnlyReader() { }
}
