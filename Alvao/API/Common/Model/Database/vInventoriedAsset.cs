using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html"/>
[Table("dbo.vInventoriedAsset")]
public class vInventoriedAsset {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_Created"/>
    public virtual DateTime? Created { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_DetectProfileId"/>
    public virtual int? DetectProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_IsActive"/>
    public virtual bool? IsActive { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_IsDiscarded"/>
    public virtual bool IsDiscarded { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_IsHidden"/>
    public virtual bool? IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_IsRemoved"/>
    public virtual bool IsRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_IsTemplate"/>
    public virtual bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_LastAgentWSContact"/>
    public virtual DateTime? LastAgentWSContact { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_NotNullParentId"/>
    public virtual int NotNullParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_PathLen"/>
    public virtual int? PathLen { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_RequiredPropertyAlert"/>
    public virtual bool RequiredPropertyAlert { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_Search"/>
    public virtual string Search { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_bSwAllAllowed"/>
    public virtual bool bSwAllAllowed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_bolComputerStateOn"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_intNodeId"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_intState"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_liSwProfileId"/>
    public virtual int? liSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_lintClassId"/>
    public virtual int lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_lintIconId"/>
    public virtual int? lintIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_lintParentId"/>
    public virtual int? lintParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vInventoriedAsset.html#Alvao_API_Common_Model_Database_vInventoriedAsset_txtPath"/>
    public virtual string txtPath { get; set; }
}
