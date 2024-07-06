using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected registry entries. The table contains records which may differ in various computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DetRegUninstall.htm"/>
[TableAttribute("dbo.DetRegUninstall")]
public class DetRegUninstall
{
    public virtual string ALC_ProductPath { get; set; }
    /// <summary>Detected activation key.</summary>
    public virtual string CD_KEY { get; set; }
    /// <summary>ID detection.</summary>
    public virtual int DetectId { get; set; }
    /// <summary>Detected product key.</summary>
    public virtual string DigitalProductId { get; set; }
    public virtual int? EstimatedSize { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual string InstallDate { get; set; }
    public virtual string InstallLocation { get; set; }
    public virtual string InstallSource { get; set; }
    public virtual string LogFile { get; set; }
    public virtual string ModifyPath { get; set; }
    public virtual int? NoModify { get; set; }
    public virtual int? NoRemove { get; set; }
    public virtual int? NoRepair { get; set; }
    public virtual string PIDKey { get; set; }
    public virtual string ProductID { get; set; }
    public virtual string Readme { get; set; }
    /// <summary>ID of the unique registry key.</summary>
    public virtual int RegUninstallId { get; set; }
    public virtual string UninstallString { get; set; }

    public DetRegUninstall() { }
}
