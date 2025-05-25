using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permission to run a Data query.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html"/>
[Table("dbo.DataQueryPermission")]
public class DataQueryPermission {
    /// <summary>DataQuery (DataQuery.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_DataQueryId"/>
    public virtual int DataQueryId { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Role (tRole.iRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQueryPermission.html#Alvao_API_Common_Model_Database_DataQueryPermission_id"/>
    [Key]
    public virtual int id { get; set; }
}
