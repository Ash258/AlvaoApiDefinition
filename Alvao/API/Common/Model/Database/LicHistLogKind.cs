using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Kind of change of a license or a license item.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistLogKind.htm"/>
[TableAttribute("dbo.LicHistLogKind")]
public class LicHistLogKind
{
    /// <summary>Record ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Kind of change.</summary>
    public virtual string LogKind { get; set; }
    /// <summary>Template of the message for displaying the change in the license log.</summary>
    public virtual string MsgTemplate { get; set; }

    public LicHistLogKind() { }
}
