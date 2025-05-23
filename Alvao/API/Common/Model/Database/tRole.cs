using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Groups of persons for the entire ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tRole.htm"/>
[TableAttribute("dbo.tRole")]
public class tRole {
    /// <summary>Time of group creation in Active Directory (Active Directory - whenCreated attribute).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_AdCreated.htm"/>
    public virtual DateTime? AdCreated { get; set; }
    /// <summary>Group type in Active Directory. True means that it is a distribution group. Otherwise it is a security group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_AdDistributionGroup.htm"/>
    public virtual bool AdDistributionGroup { get; set; }
    /// <summary>Path to the group in Active Directory.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_AdPath.htm"/>
    public virtual string AdPath { get; set; }
    /// <summary>Group ID in the Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_AzureAdObjectId.htm"/>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenant’s ID Azure Active Directory which the group belongs to.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_AzureAdTenantId.htm"/>
    public virtual int? AzureAdTenantId { get; set; }
    /// <summary>Only one group "all", which has a value of 1, exists in ALVAO.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_bRoleEveryone.htm"/>
    public virtual bool bRoleEveryone { get; set; }
    /// <summary>Distribution group e-mail (Active Directory - mail attribute).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_DistributionEmail.htm"/>
    public virtual string DistributionEmail { get; set; }
    /// <summary>Time at which the group was created.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_dRoleCreated.htm"/>
    public virtual DateTime? dRoleCreated { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_iRoleId.htm"/>
    [KeyAttribute]
    public virtual int iRoleId { get; set; }
    /// <summary>Last import time from Active Directory.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_LastImport.htm"/>
    public virtual DateTime? LastImport { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_RoleBehaviorId.htm"/>
    public virtual int RoleBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_sDesc.htm"/>
    public virtual string sDesc { get; set; }
    /// <summary>Group name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_sRole.htm"/>
    public virtual string sRole { get; set; }
    /// <summary>GUID in Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tRole_sRoleAdGuid.htm"/>
    public virtual string sRoleAdGuid { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tRole__ctor.htm"/>
    public tRole() { }
}
