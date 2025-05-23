using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDetFiles.htm"/>
[TableAttribute("dbo.vDetFiles")]
public class vDetFiles {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_dteAccessed.htm"/>
    public virtual DateTime? dteAccessed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_dteModified.htm"/>
    public virtual DateTime? dteModified { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intAttribs.htm"/>
    public virtual int? intAttribs { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intCodePage.htm"/>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intDetFileId.htm"/>
    public virtual int intDetFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileDateLS.htm"/>
    public virtual int? intFileDateLS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileDateMS.htm"/>
    public virtual int? intFileDateMS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileFlags.htm"/>
    public virtual int? intFileFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileFlagsMask.htm"/>
    public virtual int? intFileFlagsMask { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileId.htm"/>
    public virtual int intFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileOS.htm"/>
    public virtual int? intFileOS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileSubtype.htm"/>
    public virtual int? intFileSubtype { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileType.htm"/>
    public virtual int? intFileType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileVersionLS.htm"/>
    public virtual int? intFileVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intFileVersionMS.htm"/>
    public virtual int? intFileVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intLanguage.htm"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intProductVersionLS.htm"/>
    public virtual int? intProductVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intProductVersionMS.htm"/>
    public virtual int? intProductVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_intSize.htm"/>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_LastRun.htm"/>
    public virtual DateTime? LastRun { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintDetectId.htm"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintDetFileFileId.htm"/>
    public virtual int? lintDetFileFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintFileImageId.htm"/>
    public virtual int? lintFileImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintFileStringInfoFileId.htm"/>
    public virtual int? lintFileStringInfoFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintFileVerInfoFileId.htm"/>
    public virtual int? lintFileVerInfoFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintOriginalProductId.htm"/>
    public virtual int? lintOriginalProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_lintProductId.htm"/>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_RunCount.htm"/>
    public virtual int? RunCount { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtComments.htm"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtCompanyName.htm"/>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtExt.htm"/>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtFileDescription.htm"/>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtFileName.htm"/>
    public virtual string txtFileName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtFileVersion.htm"/>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtFolderPath.htm"/>
    public virtual string txtFolderPath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtInternalName.htm"/>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtLegalCopyright.htm"/>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtLegalTrademarks.htm"/>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtOriginalFilename.htm"/>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtPrivateBuild.htm"/>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtProductName.htm"/>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtProductVersion.htm"/>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetFiles_txtSpecialBuild.htm"/>
    public virtual string txtSpecialBuild { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vDetFiles__ctor.htm"/>
    public vDetFiles() { }
}
