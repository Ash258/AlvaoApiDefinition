using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// </summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html"/>
[Table("dbo.vSwInstLicProfile_ProductComputer")]
public class vSwInstLicProfile_ProductComputer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_CoversMoreProds"/>
    public virtual int CoversMoreProds { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_LicTypeId"/>
    public virtual int? LicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_ProductStateId"/>
    public virtual int? ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_bError"/>
    public virtual int bError { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_iLicStatusId"/>
    public virtual int? iLicStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_iSwProfStatusId"/>
    public virtual int? iSwProfStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intFrom"/>
    public virtual int intFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intInstHistId"/>
    public virtual int? intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intLicHistId"/>
    public virtual int? intLicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_intLicHistItemId"/>
    public virtual int? intLicHistItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_liProductId"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_liSwPresenceId"/>
    public virtual int? liSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_liSwProfProductId"/>
    public virtual int? liSwProfProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintComputerNodeId"/>
    public virtual int? lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintInstProductId"/>
    public virtual int? lintInstProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintLicProductId"/>
    public virtual int? lintLicProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintProductDowngradeFromId"/>
    public virtual int? lintProductDowngradeFromId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInstLicProfile_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer_lintProductPackFromId"/>
    public virtual int? lintProductPackFromId { get; set; }
}
