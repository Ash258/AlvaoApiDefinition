using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files on the computers (SW detection).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html"/>
[Table("dbo.tblDetFile")]
public class tblDetFile {
    /// <summary>The date the file was last run.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_LastRun"/>
    public virtual DateTime? LastRun { get; set; }
    /// <summary>Total number of files running</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_RunCount"/>
    public virtual int? RunCount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_dteAccessed"/>
    public virtual DateTime? dteAccessed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_dteCreated"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_dteModified"/>
    public virtual DateTime? dteModified { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_intAttribs"/>
    public virtual int? intAttribs { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_intDetFileId"/>
    [Key]
    public virtual int intDetFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_lintDetectId"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_lintFileId"/>
    public virtual int? lintFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_txtFolderPath"/>
    public virtual string txtFolderPath { get; set; }
}
