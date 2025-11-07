using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html"/>
[Table("dbo.vComputer")]
public class vComputer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_AdGuid"/>
    public virtual string AdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_IsActive"/>
    public virtual bool? IsActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_IsDiscarded"/>
    public virtual bool IsDiscarded { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_IsHidden"/>
    public virtual bool? IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_bSwAllAllowed"/>
    public virtual bool bSwAllAllowed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_bolComputerStateOn"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_intNodeId"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_intState"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_liSwProfileId"/>
    public virtual int? liSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_lintIconId"/>
    public virtual int? lintIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_lintParentId"/>
    public virtual int? lintParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_txtComputerName"/>
    public virtual string txtComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_txtDomain"/>
    public virtual string txtDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_txtFullComputerName"/>
    public virtual string txtFullComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_txtIPAddress"/>
    public virtual string txtIPAddress { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputer.html#Alvao_API_Common_Model_Database_vComputer_txtPath"/>
    public virtual string txtPath { get; set; }
}
