using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects in the tree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblNode.htm"/>
[TableAttribute("dbo.tblNode")]
public class tblNode
{
    /// <summary>1=according to hardware detection; automatic object update is enabled; Objects with an attribute value of 1 are displayed in this tree as a "yellow triangle" symbol</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_bolAutoUpdate.htm"/>
    public virtual bool bolAutoUpdate { get; set; }
    /// <summary>1=object represents the last computer to respond to ping, 0=computer did not respond, NULL=ping not applied</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_bolComputerStateOn.htm"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <summary>1=any differences found on this object during hardware detection will be ignored and the program will not attempt to update the tree object</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_bolIgnoreDifferences.htm"/>
    public virtual bool bolIgnoreDifferences { get; set; }
    /// <summary>1=all software is allowed on PC for profiles</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_bSwAllAllowed.htm"/>
    public virtual bool bSwAllAllowed { get; set; }
    /// <summary>Computer detection profile</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_DetectProfileId.htm"/>
    public virtual int? DetectProfileId { get; set; }
    /// <summary>Object id</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_intNodeId.htm"/>
    [KeyAttribute]
    public virtual int intNodeId { get; set; }
    /// <summary>bit field:1 = Recycle Bin object2 = the object is protected against deletion4 = Object Template object8 = object cannot obe moved0x10 = hidden object0x20 = object template0x40 = property list tabs0x80 = history is not kept for the object0x100 = folder "Computer found in network"</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_intState.htm"/>
    public virtual int? intState { get; set; }
    /// <summary>1 = the object is not the Discarded assets, or the Recycle bin, or Object templates, or Property categories, neither their child object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_IsActive.htm"/>
    public virtual bool? IsActive { get; set; }
    /// <summary>1 = the object is discarded.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_IsDiscarded.htm"/>
    public virtual bool IsDiscarded { get; set; }
    /// <summary>1 = the object is the Recycle bin, or Object templates, or Property categories, or their child object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_IsHidden.htm"/>
    public virtual bool? IsHidden { get; set; }
    /// <summary>1 = the object is property category.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_IsPropertyCategory.htm"/>
    public virtual bool IsPropertyCategory { get; set; }
    /// <summary>1 = Whether the object is in the Recycle bin.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_IsRemoved.htm"/>
    public virtual bool IsRemoved { get; set; }
    /// <summary>1 = the object is object template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_IsTemplate.htm"/>
    public virtual bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_LastAgentWSContact.htm"/>
    public virtual DateTime? LastAgentWSContact { get; set; }
    /// <summary>object type - tblClass</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_lintClassId.htm"/>
    public virtual int? lintClassId { get; set; }
    /// <summary>icon - tblIcon</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_lintIconId.htm"/>
    public virtual int? lintIconId { get; set; }
    /// <summary>Id of parent object, foreign key to tblNode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_lintParentId.htm"/>
    public virtual int? lintParentId { get; set; }
    /// <summary>which SW profile does the computer use</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_liSwProfileId.htm"/>
    public virtual int? liSwProfileId { get; set; }
    /// <summary>The ID of the parent object; in the case of no parent object, 0 is here.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_NotNullParentId.htm"/>
    public virtual int NotNullParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_PathLen.htm"/>
    public virtual int? PathLen { get; set; }
    /// <summary>The object does not have any of the required properties filled in.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_RequiredPropertyAlert.htm"/>
    public virtual bool RequiredPropertyAlert { get; set; }
    /// <summary>GUID object value in ActiveDirectory, according to which the object was created.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_txtLDAPGUID.htm"/>
    public virtual string txtLDAPGUID { get; set; }
    /// <summary>object name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <summary>path to tree object, for example, "Company/Prague Office/Sales Department"</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNode_txtPath.htm"/>
    public virtual string txtPath { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblNode__ctor.htm"/>
    public tblNode() { }
}
