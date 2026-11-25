using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html"/>
[Table("dbo.tblNode")]
public class tblNode {
    /// <summary>Date and time when the asset label was generated.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_AssetLabelCreatedDate"/>
    /// <remarks>Column <c>AssetLabelCreatedDate</c>: datetime, null.</remarks>
    public virtual DateTime? AssetLabelCreatedDate { get; set; }
    /// <summary>Asset label HTML</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_AssetLabelHtml"/>
    /// <remarks>Column <c>AssetLabelHtml</c>: nvarchar(max), null.</remarks>
    public virtual string AssetLabelHtml { get; set; }
    /// <summary>Object creation date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_Created"/>
    /// <remarks>Column <c>Created</c>: datetime, null.</remarks>
    public virtual DateTime? Created { get; set; }
    /// <summary>Computer detection profile</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_DetectProfileId"/>
    /// <remarks>Column <c>DetectProfileId</c>: int, null. References <see cref="DetectProfile"/>.</remarks>
    public virtual int? DetectProfileId { get; set; }
    /// <summary>Two or more devices matched onto this object during import.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_ImportDuplicateAlert"/>
    /// <remarks>Column <c>ImportDuplicateAlert</c>: bit, not null.</remarks>
    public virtual bool ImportDuplicateAlert { get; set; }
    /// <summary>
    /// 1 = the object is not the Discarded assets, or the Recycle bin, or Object templates, or Property categories,
    /// neither their child object.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsActive"/>
    /// <remarks>Column <c>IsActive</c>: bit, null.</remarks>
    [Computed]
    public virtual bool? IsActive { get; set; }
    /// <summary>1 = the object is discarded.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsDiscarded"/>
    /// <remarks>Column <c>IsDiscarded</c>: bit, not null.</remarks>
    public virtual bool IsDiscarded { get; set; }
    /// <summary>
    /// 1 = the object is the Recycle bin, or Object templates, or Property categories, or their child object.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsHidden"/>
    /// <remarks>Column <c>IsHidden</c>: bit, null.</remarks>
    [Computed]
    public virtual bool? IsHidden { get; set; }
    /// <summary>1 = Whether the object is in the Recycle bin.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsRemoved"/>
    /// <remarks>Column <c>IsRemoved</c>: bit, not null.</remarks>
    public virtual bool IsRemoved { get; set; }
    /// <summary>Is data sample.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>1 = the object is object template.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_IsTemplate"/>
    /// <remarks>Column <c>IsTemplate</c>: bit, not null.</remarks>
    public virtual bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_LastAgentWSContact"/>
    /// <remarks>Column <c>LastAgentWSContact</c>: datetime, null.</remarks>
    public virtual DateTime? LastAgentWSContact { get; set; }
    /// <summary>The ID of the parent object; in the case of no parent object, 0 is here.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_NotNullParentId"/>
    /// <remarks>Column <c>NotNullParentId</c>: int, not null.</remarks>
    [Computed]
    public virtual int NotNullParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_PathLen"/>
    /// <remarks>Column <c>PathLen</c>: int, null.</remarks>
    [Computed]
    public virtual int? PathLen { get; set; }
    /// <summary>The object does not have any of the required properties filled in.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_RequiredPropertyAlert"/>
    /// <remarks>Column <c>RequiredPropertyAlert</c>: bit, not null.</remarks>
    public virtual bool RequiredPropertyAlert { get; set; }
    /// <summary>Column for regular search.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_Search"/>
    /// <remarks>Column <c>Search</c>: nvarchar(max), null.</remarks>
    public virtual string Search { get; set; }
    /// <summary>Column for full text search.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_SearchNormalized"/>
    /// <remarks>Column <c>SearchNormalized</c>: nvarchar(max), null.</remarks>
    public virtual string SearchNormalized { get; set; }
    /// <summary>Unique identifier for the object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_UniqueId"/>
    /// <remarks>Column <c>UniqueId</c>: nvarchar(255), null.</remarks>
    public virtual string UniqueId { get; set; }
    /// <summary>1=all software is allowed on PC for profiles</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_bSwAllAllowed"/>
    /// <remarks>Column <c>bSwAllAllowed</c>: bit, not null.</remarks>
    public virtual bool bSwAllAllowed { get; set; }
    /// <summary>
    /// 1=object represents the last computer to respond to ping, 0=computer did not respond, NULL=ping not applied
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_bolComputerStateOn"/>
    /// <remarks>Column <c>bolComputerStateOn</c>: bit, null.</remarks>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <summary>Object id</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_intNodeId"/>
    /// <remarks>Column <c>intNodeId</c>: int, not null.</remarks>
    [Key]
    public virtual int intNodeId { get; set; }
    /// <summary>
    /// bit field: 1 = Recycle Bin object 2 = the object is protected against deletion 4 = Object Template object 8 =
    /// object cannot obe moved 0x10 = hidden object 0x20 = object template 0x40 = property list tabs 0x80 = history is
    /// not kept for the object 0x100 = folder &quot;Computer found in network&quot;
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_intState"/>
    /// <remarks>Column <c>intState</c>: int, null.</remarks>
    public virtual int? intState { get; set; }
    /// <summary>which SW profile does the computer use</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_liSwProfileId"/>
    /// <remarks>Column <c>liSwProfileId</c>: int, null. References <see cref="tSwProfile"/>.</remarks>
    public virtual int? liSwProfileId { get; set; }
    /// <summary>object type - tblClass</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_lintClassId"/>
    /// <remarks>Column <c>lintClassId</c>: int, not null. References <see cref="tblClass"/>.</remarks>
    public virtual int lintClassId { get; set; }
    /// <summary>icon - tblIcon</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_lintIconId"/>
    /// <remarks>Column <c>lintIconId</c>: int, null. References <see cref="tblIcon"/>.</remarks>
    public virtual int? lintIconId { get; set; }
    /// <summary>Id of parent object, foreign key to tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_lintParentId"/>
    /// <remarks>Column <c>lintParentId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintParentId { get; set; }
    /// <summary>object name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), null.</remarks>
    public virtual string txtName { get; set; }
    /// <summary>path to object in tree, e.g., &quot;Contoso/Prague/Sales Department&quot;</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNode.html#Alvao_API_Common_Model_Database_tblNode_txtPath"/>
    /// <remarks>Column <c>txtPath</c>: nvarchar(1024), null.</remarks>
    public virtual string txtPath { get; set; }
}
