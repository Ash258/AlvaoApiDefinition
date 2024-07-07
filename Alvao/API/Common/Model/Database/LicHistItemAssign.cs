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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_AssignedDate.htm"/>
    public virtual DateTime AssignedDate { get; set; }
    /// <summary>Assigning/Removing author</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_AssignedPersonId.htm"/>
    public virtual int AssignedPersonId { get; set; }
    /// <summary>Target object</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_DestNodeId.htm"/>
    public virtual int? DestNodeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Information on the assigned/removed license item.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_ItemInfo.htm"/>
    public virtual string ItemInfo { get; set; }
    /// <summary>License</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_LicHistId.htm"/>
    public virtual int LicHistId { get; set; }
    /// <summary>License item</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_LicHistItemId.htm"/>
    public virtual int? LicHistItemId { get; set; }
    /// <summary>Information on the assigned/removed license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_LicInfo.htm"/>
    public virtual string LicInfo { get; set; }
    /// <summary>Source object</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistItemAssign_SrcNodeId.htm"/>
    public virtual int? SrcNodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicHistItemAssign__ctor.htm"/>
    public LicHistItemAssign() { }
}
