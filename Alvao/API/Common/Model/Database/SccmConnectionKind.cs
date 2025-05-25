using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Type of connection to MS SCCM</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnectionKind.html"/>
[Table("dbo.SccmConnectionKind")]
public class SccmConnectionKind {
    /// <summary>Type name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnectionKind.html#Alvao_API_Common_Model_Database_SccmConnectionKind_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID: 1=Administration Service 2=Database</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SccmConnectionKind.html#Alvao_API_Common_Model_Database_SccmConnectionKind_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
