using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Groups of persons for the entire ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html"/>
[Table("dbo.tRole")]
public class tRole {
    /// <summary>Time of group creation in Active Directory (Active Directory - whenCreated attribute).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AdCreated"/>
    /// <remarks>Column <c>AdCreated</c>: datetime, null.</remarks>
    public virtual DateTime? AdCreated { get; set; }
    /// <summary>
    /// Group type in Active Directory. True means that it is a distribution group. Otherwise it is a security group.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AdDistributionGroup"/>
    /// <remarks>Column <c>AdDistributionGroup</c>: bit, not null.</remarks>
    public virtual bool AdDistributionGroup { get; set; }
    /// <summary>Path to the group in Active Directory.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AdPath"/>
    /// <remarks>Column <c>AdPath</c>: nvarchar(1024), null.</remarks>
    public virtual string AdPath { get; set; }
    /// <summary>Group ID in the Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AzureAdObjectId"/>
    /// <remarks>Column <c>AzureAdObjectId</c>: nvarchar(40), null.</remarks>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenantâs ID Azure Active Directory which the group belongs to.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_AzureAdTenantId"/>
    /// <remarks>Column <c>AzureAdTenantId</c>: int, null. References <see cref="AzureAdTenant"/>.</remarks>
    public virtual int? AzureAdTenantId { get; set; }
    /// <summary>Distribution group email (Active Directory - mail attribute).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_DistributionEmail"/>
    /// <remarks>Column <c>DistributionEmail</c>: nvarchar(255), null.</remarks>
    public virtual string DistributionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>Last import time from Active Directory.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_LastImport"/>
    /// <remarks>Column <c>LastImport</c>: datetime, null.</remarks>
    public virtual DateTime? LastImport { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_RoleBehaviorId"/>
    /// <remarks>Column <c>RoleBehaviorId</c>: int, not null. References <see cref="RoleBehavior"/>.</remarks>
    public virtual int RoleBehaviorId { get; set; }
    /// <summary>Only one group &quot;all&quot;, which has a value of 1, exists in ALVAO.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_bRoleEveryone"/>
    /// <remarks>Column <c>bRoleEveryone</c>: bit, not null.</remarks>
    public virtual bool bRoleEveryone { get; set; }
    /// <summary>Time at which the group was created.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_dRoleCreated"/>
    /// <remarks>Column <c>dRoleCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dRoleCreated { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_iRoleId"/>
    /// <remarks>Column <c>iRoleId</c>: int, not null.</remarks>
    [Key]
    public virtual int iRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_sDesc"/>
    /// <remarks>Column <c>sDesc</c>: nvarchar(max), null.</remarks>
    public virtual string sDesc { get; set; }
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_sRole"/>
    /// <remarks>Column <c>sRole</c>: nvarchar(255), null.</remarks>
    public virtual string sRole { get; set; }
    /// <summary>GUID in Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tRole.html#Alvao_API_Common_Model_Database_tRole_sRoleAdGuid"/>
    /// <remarks>Column <c>sRoleAdGuid</c>: nvarchar(255), null.</remarks>
    public virtual string sRoleAdGuid { get; set; }
}
