using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected registry entries. The table contains records which may differ in various computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DetRegUninstall.htm"/>
[TableAttribute("dbo.DetRegUninstall")]
public class DetRegUninstall
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_ALC_ProductPath.htm"/>
    public virtual string ALC_ProductPath { get; set; }
    /// <summary>Detected activation key.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_CD_KEY.htm"/>
    public virtual string CD_KEY { get; set; }
    /// <summary>ID detection.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_DetectId.htm"/>
    public virtual int DetectId { get; set; }
    /// <summary>Detected product key.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_DigitalProductId.htm"/>
    public virtual string DigitalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_EstimatedSize.htm"/>
    public virtual int? EstimatedSize { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_InstallDate.htm"/>
    public virtual string InstallDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_InstallLocation.htm"/>
    public virtual string InstallLocation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_InstallSource.htm"/>
    public virtual string InstallSource { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_LogFile.htm"/>
    public virtual string LogFile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_ModifyPath.htm"/>
    public virtual string ModifyPath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_NoModify.htm"/>
    public virtual int? NoModify { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_NoRemove.htm"/>
    public virtual int? NoRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_NoRepair.htm"/>
    public virtual int? NoRepair { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_PIDKey.htm"/>
    public virtual string PIDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_ProductID.htm"/>
    public virtual string ProductID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_Readme.htm"/>
    public virtual string Readme { get; set; }
    /// <summary>ID of the unique registry key.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_RegUninstallId.htm"/>
    public virtual int RegUninstallId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetRegUninstall_UninstallString.htm"/>
    public virtual string UninstallString { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DetRegUninstall__ctor.htm"/>
    public DetRegUninstall() { }
}
