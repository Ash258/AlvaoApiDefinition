using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vComputer.htm"/>
[TableAttribute("dbo.vComputer")]
public class vComputer
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_bolAutoUpdate.htm"/>
    public virtual bool bolAutoUpdate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_bolComputerStateOn.htm"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_bolIgnoreDifferences.htm"/>
    public virtual bool bolIgnoreDifferences { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_bSwAllAllowed.htm"/>
    public virtual bool bSwAllAllowed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_intNodeId.htm"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_intState.htm"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_IsActive.htm"/>
    public virtual bool? IsActive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_IsDiscarded.htm"/>
    public virtual bool IsDiscarded { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_IsHidden.htm"/>
    public virtual bool? IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_lintClassId.htm"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_lintIconId.htm"/>
    public virtual int? lintIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_lintParentId.htm"/>
    public virtual int? lintParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_liSwProfileId.htm"/>
    public virtual int? liSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtComputerName.htm"/>
    public virtual string txtComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtDomain.htm"/>
    public virtual string txtDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtFullComputerName.htm"/>
    public virtual string txtFullComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtIPAddress.htm"/>
    public virtual string txtIPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtLDAPGUID.htm"/>
    public virtual string txtLDAPGUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputer_txtPath.htm"/>
    public virtual string txtPath { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vComputer__ctor.htm"/>
    public vComputer() { }
}
