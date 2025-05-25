using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users that only have the right of reader in the services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vOnlyReader.html"/>
[Table("dbo.vOnlyReader")]
public class vOnlyReader {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vOnlyReader.html#Alvao_API_Common_Model_Database_vOnlyReader_OnlyReader"/>
    public virtual bool? OnlyReader { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vOnlyReader.html#Alvao_API_Common_Model_Database_vOnlyReader_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vOnlyReader.html#Alvao_API_Common_Model_Database_vOnlyReader_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vOnlyReader.html#Alvao_API_Common_Model_Database_vOnlyReader_SectionId"/>
    public virtual int SectionId { get; set; }
}
