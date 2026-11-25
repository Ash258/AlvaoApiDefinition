using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permission to run a Data query.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html"/>
[Table("dbo.DataQueryPermission")]
public class DataQueryPermission {
    /// <summary>DataQuery (DataQuery.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_DataQueryId"/>
    /// <remarks>Column <c>DataQueryId</c>: int, not null. References <see cref="DataQuery"/>.</remarks>
    public virtual int DataQueryId { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>Role (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? RoleId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
