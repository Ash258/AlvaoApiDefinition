using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users with the permission to read software licenses belonging to the organization.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicRight_Read.html"/>
[Table("dbo.vLicRight_Read")]
public class vLicRight_Read {
    /// <summary>Organization (tblNode.intNodeId) to whose software licenses the permissions apply.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicRight_Read.html#Alvao_API_Common_Model_Database_vLicRight_Read_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Authorized user (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicRight_Read.html#Alvao_API_Common_Model_Database_vLicRight_Read_PersonId"/>
    public virtual int? PersonId { get; set; }
}
