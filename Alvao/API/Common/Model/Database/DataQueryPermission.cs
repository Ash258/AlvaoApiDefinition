using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Permission to run a Data query.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DataQueryPermission.htm"/>
[TableAttribute("dbo.DataQueryPermission")]
public class DataQueryPermission
{
    /// <summary>DataQuery (DataQuery.id)</summary>
    public virtual int DataQueryId { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>Role (tRole.iRoleId)</summary>
    public virtual int? RoleId { get; set; }

    public DataQueryPermission() { }
}
