using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected files.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDetFiles.htm"/>
[TableAttribute("dbo.vDetFiles")]
public class vDetFiles
{
    public virtual DateTime? dteAccessed { get; set; }
    public virtual DateTime? dteCreated { get; set; }
    public virtual DateTime? dteModified { get; set; }
    public virtual int? intAttribs { get; set; }
    public virtual int? intCodePage { get; set; }
    public virtual int intDetFileId { get; set; }
    public virtual int? intFileDateLS { get; set; }
    public virtual int? intFileDateMS { get; set; }
    public virtual int? intFileFlags { get; set; }
    public virtual int? intFileFlagsMask { get; set; }
    public virtual int intFileId { get; set; }
    public virtual int? intFileOS { get; set; }
    public virtual int? intFileSubtype { get; set; }
    public virtual int? intFileType { get; set; }
    public virtual int? intFileVersionLS { get; set; }
    public virtual int? intFileVersionMS { get; set; }
    public virtual int? intLanguage { get; set; }
    public virtual int? intProductVersionLS { get; set; }
    public virtual int? intProductVersionMS { get; set; }
    public virtual int? intSize { get; set; }
    public virtual DateTime? LastRun { get; set; }
    public virtual int? lintDetectId { get; set; }
    public virtual int? lintDetFileFileId { get; set; }
    public virtual int? lintFileImageId { get; set; }
    public virtual int? lintFileStringInfoFileId { get; set; }
    public virtual int? lintFileVerInfoFileId { get; set; }
    public virtual int? lintOriginalProductId { get; set; }
    public virtual int? lintProductId { get; set; }
    public virtual int? RunCount { get; set; }
    public virtual string txtComments { get; set; }
    public virtual string txtCompanyName { get; set; }
    public virtual string txtExt { get; set; }
    public virtual string txtFileDescription { get; set; }
    public virtual string txtFileName { get; set; }
    public virtual string txtFileVersion { get; set; }
    public virtual string txtFolderPath { get; set; }
    public virtual string txtInternalName { get; set; }
    public virtual string txtLegalCopyright { get; set; }
    public virtual string txtLegalTrademarks { get; set; }
    public virtual string txtOriginalFilename { get; set; }
    public virtual string txtPrivateBuild { get; set; }
    public virtual string txtProductName { get; set; }
    public virtual string txtProductVersion { get; set; }
    public virtual string txtSpecialBuild { get; set; }

    public vDetFiles() { }
}
