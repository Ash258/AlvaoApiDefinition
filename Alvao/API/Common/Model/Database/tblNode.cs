using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html"/>
[Table("dbo.tblNode")]
public class tblNode {
    /// <summary>Computer detection profile</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_DetectProfileId"/>
    public virtual int? DetectProfileId { get; set; }
    /// <summary>1 = the object is not the Discarded assets, or the Recycle bin, or Object templates, or Property categories, neither their child object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsActive"/>
    [Computed]
    public virtual bool? IsActive { get; set; }
    /// <summary>1 = the object is discarded.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsDiscarded"/>
    public virtual bool IsDiscarded { get; set; }
    /// <summary>1 = the object is the Recycle bin, or Object templates, or Property categories, or their child object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsHidden"/>
    [Computed]
    public virtual bool? IsHidden { get; set; }
    /// <summary>1 = Whether the object is in the Recycle bin.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsRemoved"/>
    public virtual bool IsRemoved { get; set; }
    /// <summary>1 = the object is object template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsTemplate"/>
    public virtual bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_LastAgentWSContact"/>
    public virtual DateTime? LastAgentWSContact { get; set; }
    /// <summary>The ID of the parent object; in the case of no parent object, 0 is here.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_NotNullParentId"/>
    [Computed]
    public virtual int NotNullParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_PathLen"/>
    [Computed]
    public virtual int? PathLen { get; set; }
    /// <summary>The object does not have any of the required properties filled in.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_RequiredPropertyAlert"/>
    public virtual bool RequiredPropertyAlert { get; set; }
    /// <summary>Column for full text search.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_Search"/>
    public virtual string Search { get; set; }
    /// <summary>1=all software is allowed on PC for profiles</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_bSwAllAllowed"/>
    public virtual bool bSwAllAllowed { get; set; }
    /// <summary>1=according to hardware detection; automatic object update is enabled; Objects with an attribute value of 1 are displayed in this tree as a &quot;yellow triangle&quot; symbol</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_bolAutoUpdate"/>
    public virtual bool bolAutoUpdate { get; set; }
    /// <summary>1=object represents the last computer to respond to ping, 0=computer did not respond, NULL=ping not applied</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_bolComputerStateOn"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <summary>1=any differences found on this object during hardware detection will be ignored and the program will not attempt to update the tree object</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_bolIgnoreDifferences"/>
    public virtual bool bolIgnoreDifferences { get; set; }
    /// <summary>Object id</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_intNodeId"/>
    [Key]
    public virtual int intNodeId { get; set; }
    /// <summary>bit field: 1 = Recycle Bin object 2 = the object is protected against deletion 4 = Object Template object 8 = object cannot obe moved 0x10 = hidden object 0x20 = object template 0x40 = property list tabs 0x80 = history is not kept for the object 0x100 = folder &quot;Computer found in network&quot;</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_intState"/>
    public virtual int? intState { get; set; }
    /// <summary>which SW profile does the computer use</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_liSwProfileId"/>
    public virtual int? liSwProfileId { get; set; }
    /// <summary>object type - tblClass</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <summary>icon - tblIcon</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_lintIconId"/>
    public virtual int? lintIconId { get; set; }
    /// <summary>Id of parent object, foreign key to tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_lintParentId"/>
    public virtual int? lintParentId { get; set; }
    /// <summary>object name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_txtName"/>
    public virtual string txtName { get; set; }
    /// <summary>path to tree object, for example, &quot;Company/Prague Office/Sales Department&quot;</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_txtPath"/>
    public virtual string txtPath { get; set; }
}
