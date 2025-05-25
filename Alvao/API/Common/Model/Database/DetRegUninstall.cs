using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected registry entries. The table contains records which may differ in various computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html"/>
[Table("dbo.DetRegUninstall")]
public class DetRegUninstall {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_ALC_ProductPath"/>
    public virtual string ALC_ProductPath { get; set; }
    /// <summary>Detected activation key.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_CD_KEY"/>
    public virtual string CD_KEY { get; set; }
    /// <summary>ID detection.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_DetectId"/>
    public virtual int DetectId { get; set; }
    /// <summary>Detected product key.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_DigitalProductId"/>
    public virtual string DigitalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_EstimatedSize"/>
    public virtual int? EstimatedSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_InstallDate"/>
    public virtual string InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_InstallLocation"/>
    public virtual string InstallLocation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_InstallSource"/>
    public virtual string InstallSource { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_LogFile"/>
    public virtual string LogFile { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_ModifyPath"/>
    public virtual string ModifyPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_NoModify"/>
    public virtual int? NoModify { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_NoRemove"/>
    public virtual int? NoRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_NoRepair"/>
    public virtual int? NoRepair { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_PIDKey"/>
    public virtual string PIDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_ProductID"/>
    public virtual string ProductID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_Readme"/>
    public virtual string Readme { get; set; }
    /// <summary>ID of the unique registry key.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_RegUninstallId"/>
    public virtual int RegUninstallId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_UninstallString"/>
    public virtual string UninstallString { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_id"/>
    [Key]
    public virtual int id { get; set; }
}
