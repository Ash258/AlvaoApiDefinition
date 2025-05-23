using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products covered by licenses on the computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwLic_ProductComputer.htm"/>
[TableAttribute("dbo.vSwLic_ProductComputer")]
public class vSwLic_ProductComputer {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_ActivationKey.htm"/>
    public virtual string ActivationKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_bolOEM.htm"/>
    public virtual int bolOEM { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_CreatedDate.htm"/>
    public virtual DateTime? CreatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_CreatedPersonId.htm"/>
    public virtual int? CreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_intLicHistId.htm"/>
    public virtual int intLicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_intLicHistItemId.htm"/>
    public virtual int intLicHistItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_LicTypeId.htm"/>
    public virtual int? LicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_lintProductDowngradeFromId.htm"/>
    public virtual int? lintProductDowngradeFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_lintProductPackFromId.htm"/>
    public virtual int? lintProductPackFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_NodeId.htm"/>
    public virtual int? NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_NoProductInstallation.htm"/>
    public virtual bool NoProductInstallation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtCertificateNo.htm"/>
    public virtual string txtCertificateNo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtDepartment.htm"/>
    public virtual string txtDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtInventoryNum.htm"/>
    public virtual string txtInventoryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwLic_ProductComputer_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwLic_ProductComputer__ctor.htm"/>
    public vSwLic_ProductComputer() { }
}
