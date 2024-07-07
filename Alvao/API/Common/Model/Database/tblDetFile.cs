using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected files on the computers (SW detection).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetFile.htm"/>
[TableAttribute("dbo.tblDetFile")]
public class tblDetFile
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_dteAccessed.htm"/>
    public virtual DateTime? dteAccessed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_dteModified.htm"/>
    public virtual DateTime? dteModified { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_intAttribs.htm"/>
    public virtual int? intAttribs { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_intDetFileId.htm"/>
    [KeyAttribute]
    public virtual int intDetFileId { get; set; }
    /// <summary>The date the file was last run.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_LastRun.htm"/>
    public virtual DateTime? LastRun { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_lintDetectId.htm"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_lintFileId.htm"/>
    public virtual int? lintFileId { get; set; }
    /// <summary>Total number of files running</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_RunCount.htm"/>
    public virtual int? RunCount { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetFile_txtFolderPath.htm"/>
    public virtual string txtFolderPath { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDetFile__ctor.htm"/>
    public tblDetFile() { }
}
