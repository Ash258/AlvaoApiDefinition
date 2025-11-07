using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the Objects Tree. Differentiation between system objects and discarded assets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html"/>
[Table("dbo.vNodeClass")]
public class vNodeClass {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_AdGuid"/>
    public virtual string AdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_IsActive"/>
    public virtual bool? IsActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_IsDiscarded"/>
    public virtual bool IsDiscarded { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_IsHidden"/>
    public virtual bool? IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_LastAgentWSContact"/>
    public virtual DateTime? LastAgentWSContact { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_RequiredPropertyAlert"/>
    public virtual bool RequiredPropertyAlert { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_bComputer"/>
    public virtual bool bComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_bSwAllAllowed"/>
    public virtual bool bSwAllAllowed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_bolComputerStateOn"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_intNodeId"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_intState"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_liSwProfileId"/>
    public virtual int? liSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_lintIconId"/>
    public virtual int? lintIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_lintParentId"/>
    public virtual int? lintParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_txtClass"/>
    public virtual string txtClass { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeClass.html#Alvao_API_Common_Model_Database_vNodeClass_txtPath"/>
    public virtual string txtPath { get; set; }
}
