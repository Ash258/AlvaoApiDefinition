using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Groups of persons for the entire ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html"/>
[Table("dbo.tRole")]
public class tRole {
    /// <summary>Time of group creation in Active Directory (Active Directory - whenCreated attribute).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AdCreated"/>
    public virtual DateTime? AdCreated { get; set; }
    /// <summary>Group type in Active Directory. True means that it is a distribution group. Otherwise it is a security group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AdDistributionGroup"/>
    public virtual bool AdDistributionGroup { get; set; }
    /// <summary>Path to the group in Active Directory.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AdPath"/>
    public virtual string AdPath { get; set; }
    /// <summary>Group ID in the Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AzureAdObjectId"/>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenantâs ID Azure Active Directory which the group belongs to.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AzureAdTenantId"/>
    public virtual int? AzureAdTenantId { get; set; }
    /// <summary>Distribution group e-mail (Active Directory - mail attribute).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_DistributionEmail"/>
    public virtual string DistributionEmail { get; set; }
    /// <summary>Last import time from Active Directory.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_LastImport"/>
    public virtual DateTime? LastImport { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_RoleBehaviorId"/>
    public virtual int RoleBehaviorId { get; set; }
    /// <summary>Only one group &quot;all&quot;, which has a value of 1, exists in ALVAO.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_bRoleEveryone"/>
    public virtual bool bRoleEveryone { get; set; }
    /// <summary>Time at which the group was created.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_dRoleCreated"/>
    public virtual DateTime? dRoleCreated { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_iRoleId"/>
    [Key]
    public virtual int iRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_sDesc"/>
    public virtual string sDesc { get; set; }
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_sRole"/>
    public virtual string sRole { get; set; }
    /// <summary>GUID in Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_sRoleAdGuid"/>
    public virtual string sRoleAdGuid { get; set; }
}
