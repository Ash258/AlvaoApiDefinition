using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Assigning/removing/moving license to/from/between computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistItemAssign.htm"/>
[TableAttribute("dbo.LicHistItemAssign")]
public class LicHistItemAssign
{
    /// <summary>Date assigned/removed</summary>
    public virtual DateTime AssignedDate { get; set; }
    /// <summary>Assigning/Removing author</summary>
    public virtual int AssignedPersonId { get; set; }
    /// <summary>Target object</summary>
    public virtual int? DestNodeId { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Information on the assigned/removed license item.</summary>
    public virtual string ItemInfo { get; set; }
    /// <summary>License</summary>
    public virtual int LicHistId { get; set; }
    /// <summary>License item</summary>
    public virtual int? LicHistItemId { get; set; }
    /// <summary>Information on the assigned/removed license.</summary>
    public virtual string LicInfo { get; set; }
    /// <summary>Source object</summary>
    public virtual int? SrcNodeId { get; set; }

    public LicHistItemAssign() { }
}
