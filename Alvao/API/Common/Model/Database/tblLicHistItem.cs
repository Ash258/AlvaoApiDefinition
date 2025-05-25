using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - license items.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html"/>
[Table("dbo.tblLicHistItem")]
public class tblLicHistItem {
    /// <summary>Serial number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_ActivationKey"/>
    public virtual string ActivationKey { get; set; }
    /// <summary>Automatically assigned item</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_AutoAssigned"/>
    public virtual bool AutoAssigned { get; set; }
    /// <summary>Number of assigned licenses</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_LicensesCount"/>
    public virtual int LicensesCount { get; set; }
    /// <summary>Computer ID - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_intLicHistItemId"/>
    [Key]
    public virtual int intLicHistItemId { get; set; }
    /// <summary>License ID - tblLicHist</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_lintLicHistId"/>
    public virtual int lintLicHistId { get; set; }
    /// <summary>Center</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtDepartment"/>
    public virtual string txtDepartment { get; set; }
    /// <summary>Inventory number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtInventoryNum"/>
    public virtual string txtInventoryNum { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtMemo"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Ticket</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblLicHistItem.html#Alvao_API_Common_Model_Database_tblLicHistItem_txtRequest"/>
    public virtual string txtRequest { get; set; }
}
