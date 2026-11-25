using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kind of change of a license or a license item.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLogKind.html"/>
[Table("dbo.LicHistLogKind")]
public class LicHistLogKind {
    /// <summary>Kind of change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLogKind.html#Alvao_API_Common_Model_Database_LicHistLogKind_LogKind"/>
    /// <remarks>Column <c>LogKind</c>: nvarchar(100), not null.</remarks>
    public virtual string LogKind { get; set; }
    /// <summary>Template of the message for displaying the change in the license log.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLogKind.html#Alvao_API_Common_Model_Database_LicHistLogKind_MsgTemplate"/>
    /// <remarks>Column <c>MsgTemplate</c>: nvarchar(255), not null.</remarks>
    public virtual string MsgTemplate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLogKind.html#Alvao_API_Common_Model_Database_LicHistLogKind_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
