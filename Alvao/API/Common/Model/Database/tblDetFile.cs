using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected files on the computers (SW detection).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetFile.htm"/>
[TableAttribute("dbo.tblDetFile")]
public class tblDetFile
{
    public virtual DateTime? dteAccessed { get; set; }
    public virtual DateTime? dteCreated { get; set; }
    public virtual DateTime? dteModified { get; set; }
    public virtual int? intAttribs { get; set; }
    [KeyAttribute]
    public virtual int intDetFileId { get; set; }
    /// <summary>The date the file was last run.</summary>
    public virtual DateTime? LastRun { get; set; }
    public virtual int? lintDetectId { get; set; }
    public virtual int? lintFileId { get; set; }
    /// <summary>Total number of files running</summary>
    public virtual int? RunCount { get; set; }
    public virtual string txtFolderPath { get; set; }

    public tblDetFile() { }
}
