using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected registry entries. The table contains records which may differ in various computers.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html"/>
[Table("dbo.DetRegUninstall")]
public class DetRegUninstall {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_ALC_ProductPath"/>
    /// <remarks>Column <c>ALC_ProductPath</c>: nvarchar(255), null.</remarks>
    public virtual string ALC_ProductPath { get; set; }
    /// <summary>Detected activation key.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_CD_KEY"/>
    /// <remarks>Column <c>CD_KEY</c>: nvarchar(255), null.</remarks>
    public virtual string CD_KEY { get; set; }
    /// <summary>ID detection.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_DetectId"/>
    /// <remarks>Column <c>DetectId</c>: int, not null. References <see cref="tblDetect"/>.</remarks>
    public virtual int DetectId { get; set; }
    /// <summary>Detected product key.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_DigitalProductId"/>
    /// <remarks>Column <c>DigitalProductId</c>: nvarchar(255), null.</remarks>
    public virtual string DigitalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_EstimatedSize"/>
    /// <remarks>Column <c>EstimatedSize</c>: int, null.</remarks>
    public virtual int? EstimatedSize { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_InstallDate"/>
    /// <remarks>Column <c>InstallDate</c>: nvarchar(255), null.</remarks>
    public virtual string InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_InstallLocation"/>
    /// <remarks>Column <c>InstallLocation</c>: nvarchar(255), null.</remarks>
    public virtual string InstallLocation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_InstallSource"/>
    /// <remarks>Column <c>InstallSource</c>: nvarchar(255), null.</remarks>
    public virtual string InstallSource { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_LogFile"/>
    /// <remarks>Column <c>LogFile</c>: nvarchar(255), null.</remarks>
    public virtual string LogFile { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_ModifyPath"/>
    /// <remarks>Column <c>ModifyPath</c>: nvarchar(255), null.</remarks>
    public virtual string ModifyPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_NoModify"/>
    /// <remarks>Column <c>NoModify</c>: int, null.</remarks>
    public virtual int? NoModify { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_NoRemove"/>
    /// <remarks>Column <c>NoRemove</c>: int, null.</remarks>
    public virtual int? NoRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_NoRepair"/>
    /// <remarks>Column <c>NoRepair</c>: int, null.</remarks>
    public virtual int? NoRepair { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_PIDKey"/>
    /// <remarks>Column <c>PIDKey</c>: nvarchar(255), null.</remarks>
    public virtual string PIDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_ProductID"/>
    /// <remarks>Column <c>ProductID</c>: nvarchar(255), null.</remarks>
    public virtual string ProductID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_Readme"/>
    /// <remarks>Column <c>Readme</c>: nvarchar(255), null.</remarks>
    public virtual string Readme { get; set; }
    /// <summary>ID of the unique registry key.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_RegUninstallId"/>
    /// <remarks>Column <c>RegUninstallId</c>: int, not null. References <see cref="tblRegUninstall"/>.</remarks>
    public virtual int RegUninstallId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_UninstallString"/>
    /// <remarks>Column <c>UninstallString</c>: nvarchar(255), null.</remarks>
    public virtual string UninstallString { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetRegUninstall.html#Alvao_API_Common_Model_Database_DetRegUninstall_id"/>
    /// <remarks>Column <c>id</c>: bigint, not null.</remarks>
    [Key]
    public virtual long id { get; set; }
}
