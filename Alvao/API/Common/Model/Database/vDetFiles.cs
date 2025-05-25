using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html"/>
[Table("dbo.vDetFiles")]
public class vDetFiles {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_LastRun"/>
    public virtual DateTime? LastRun { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_RunCount"/>
    public virtual int? RunCount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_dteAccessed"/>
    public virtual DateTime? dteAccessed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_dteCreated"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_dteModified"/>
    public virtual DateTime? dteModified { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intAttribs"/>
    public virtual int? intAttribs { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intCodePage"/>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intDetFileId"/>
    public virtual int intDetFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileDateLS"/>
    public virtual int? intFileDateLS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileDateMS"/>
    public virtual int? intFileDateMS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileFlags"/>
    public virtual int? intFileFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileFlagsMask"/>
    public virtual int? intFileFlagsMask { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileId"/>
    public virtual int intFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileOS"/>
    public virtual int? intFileOS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileSubtype"/>
    public virtual int? intFileSubtype { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileType"/>
    public virtual int? intFileType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileVersionLS"/>
    public virtual int? intFileVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intFileVersionMS"/>
    public virtual int? intFileVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intLanguage"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intProductVersionLS"/>
    public virtual int? intProductVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intProductVersionMS"/>
    public virtual int? intProductVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_intSize"/>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintDetFileFileId"/>
    public virtual int? lintDetFileFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintDetectId"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintFileImageId"/>
    public virtual int? lintFileImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintFileStringInfoFileId"/>
    public virtual int? lintFileStringInfoFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintFileVerInfoFileId"/>
    public virtual int? lintFileVerInfoFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintOriginalProductId"/>
    public virtual int? lintOriginalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_lintProductId"/>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtComments"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtCompanyName"/>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtExt"/>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtFileDescription"/>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtFileName"/>
    public virtual string txtFileName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtFileVersion"/>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtFolderPath"/>
    public virtual string txtFolderPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtInternalName"/>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtLegalCopyright"/>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtLegalTrademarks"/>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtOriginalFilename"/>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtPrivateBuild"/>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtProductName"/>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtProductVersion"/>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetFiles.html#Alvao_API_Common_Model_Database_vDetFiles_txtSpecialBuild"/>
    public virtual string txtSpecialBuild { get; set; }
}
