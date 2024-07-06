using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Groups of persons for the entire ALVAO.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tRole.htm"/>
[TableAttribute("dbo.tRole")]
public class tRole
{
    /// <summary>Time of group creation in Active Directory (Active Directory - whenCreated attribute).</summary>
    public virtual DateTime? AdCreated { get; set; }
    /// <summary>Group type in Active Directory. True means that it is a distribution group. Otherwise it is a security group.</summary>
    public virtual bool AdDistributionGroup { get; set; }
    /// <summary>Path to the group in Active Directory.</summary>
    public virtual string AdPath { get; set; }
    /// <summary>Group ID in the Azure Active Directory</summary>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenant’s ID Azure Active Directory which the group belongs to.</summary>
    public virtual int? AzureAdTenantId { get; set; }
    /// <summary>Only one group "all", which has a value of 1, exists in ALVAO.</summary>
    public virtual bool bRoleEveryone { get; set; }
    /// <summary>Distribution group e-mail (Active Directory - mail attribute).</summary>
    public virtual string DistributionEmail { get; set; }
    /// <summary>Time at which the group was created.</summary>
    public virtual DateTime? dRoleCreated { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int iRoleId { get; set; }
    /// <summary>Last import time from Active Directory.</summary>
    public virtual DateTime? LastImport { get; set; }
    public virtual int RoleBehaviorId { get; set; }
    public virtual string sDesc { get; set; }
    /// <summary>Group name.</summary>
    public virtual string sRole { get; set; }
    /// <summary>GUID in Active Directory</summary>
    public virtual string sRoleAdGuid { get; set; }

    public tRole() { }
}
