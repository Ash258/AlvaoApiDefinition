using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - license items.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html"/>
[Table("dbo.tblLicHistItem")]
public class tblLicHistItem {
    /// <summary>Serial number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_ActivationKey"/>
    /// <remarks>Column <c>ActivationKey</c>: nvarchar(1024), null.</remarks>
    public virtual string ActivationKey { get; set; }
    /// <summary>Automatically assigned item</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_AutoAssigned"/>
    /// <remarks>Column <c>AutoAssigned</c>: bit, not null.</remarks>
    public virtual bool AutoAssigned { get; set; }
    /// <summary>External object ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_ExternalObjectId"/>
    /// <remarks>Column <c>ExternalObjectId</c>: int, null. References <see cref="ExternalObject"/>.</remarks>
    public virtual int? ExternalObjectId { get; set; }
    /// <summary>Number of assigned licenses</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_LicensesCount"/>
    /// <remarks>Column <c>LicensesCount</c>: int, not null.</remarks>
    public virtual int LicensesCount { get; set; }
    /// <summary>Computer ID - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? NodeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_intLicHistItemId"/>
    /// <remarks>Column <c>intLicHistItemId</c>: int, not null.</remarks>
    [Key]
    public virtual int intLicHistItemId { get; set; }
    /// <summary>License ID - tblLicHist</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_lintLicHistId"/>
    /// <remarks>Column <c>lintLicHistId</c>: int, not null. References <see cref="tblLicHist"/>.</remarks>
    public virtual int lintLicHistId { get; set; }
    /// <summary>Center</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtDepartment"/>
    /// <remarks>Column <c>txtDepartment</c>: nvarchar(255), null.</remarks>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtInventoryNum"/>
    /// <remarks>Column <c>txtInventoryNum</c>: nvarchar(255), null.</remarks>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtMemo"/>
    /// <remarks>Column <c>txtMemo</c>: nvarchar(max), null.</remarks>
    public virtual string txtMemo { get; set; }
    /// <summary>Ticket</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtRequest"/>
    /// <remarks>Column <c>txtRequest</c>: nvarchar(255), null.</remarks>
    public virtual string txtRequest { get; set; }
}
