using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products covered by licenses on the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html"/>
[Table("dbo.vSwLic_ProductComputer")]
public class vSwLic_ProductComputer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_ActivationKey"/>
    public virtual string ActivationKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_CreatedDate"/>
    public virtual DateTime? CreatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_CreatedPersonId"/>
    public virtual int? CreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_LicTypeId"/>
    public virtual int? LicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_NoProductInstallation"/>
    public virtual bool NoProductInstallation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_bolOEM"/>
    public virtual int bolOEM { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_intLicHistId"/>
    public virtual int intLicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_intLicHistItemId"/>
    public virtual int intLicHistItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_lintProductDowngradeFromId"/>
    public virtual int? lintProductDowngradeFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_lintProductPackFromId"/>
    public virtual int? lintProductPackFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtCertificateNo"/>
    public virtual string txtCertificateNo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtDepartment"/>
    public virtual string txtDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtInventoryNum"/>
    public virtual string txtInventoryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwLic_ProductComputer.html#Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtMemo"/>
    public virtual string txtMemo { get; set; }
}
