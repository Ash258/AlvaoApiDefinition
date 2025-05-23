using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Installed software vs licenses and software profiles. Note: This view is outdated and should not be used. It will be removed in a future version of ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer.htm"/>
[TableAttribute("dbo.vSwInstLicProfile_ProductComputer")]
public class vSwInstLicProfile_ProductComputer {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_bError.htm"/>
    public virtual int bError { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_CoversMoreProds.htm"/>
    public virtual int CoversMoreProds { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_iLicStatusId.htm"/>
    public virtual int? iLicStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intFrom.htm"/>
    public virtual int intFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intInstHistId.htm"/>
    public virtual int? intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intLicHistId.htm"/>
    public virtual int? intLicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intLicHistItemId.htm"/>
    public virtual int? intLicHistItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_iSwProfStatusId.htm"/>
    public virtual int? iSwProfStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_LicTypeId.htm"/>
    public virtual int? LicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintComputerNodeId.htm"/>
    public virtual int? lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintInstProductId.htm"/>
    public virtual int? lintInstProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintLicProductId.htm"/>
    public virtual int? lintLicProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintProductDowngradeFromId.htm"/>
    public virtual int? lintProductDowngradeFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintProductPackFromId.htm"/>
    public virtual int? lintProductPackFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_liProductId.htm"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_liSwPresenceId.htm"/>
    public virtual int? liSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_liSwProfProductId.htm"/>
    public virtual int? liSwProfProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_ProductStateId.htm"/>
    public virtual int? ProductStateId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer__ctor.htm"/>
    public vSwInstLicProfile_ProductComputer() { }
}
