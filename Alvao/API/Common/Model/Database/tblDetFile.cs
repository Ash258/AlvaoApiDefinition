using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files on the computers (SW detection).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html"/>
[Table("dbo.tblDetFile")]
public class tblDetFile {
    /// <summary>The date the file was last run.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_LastRun"/>
    /// <remarks>Column <c>LastRun</c>: datetime, null.</remarks>
    public virtual DateTime? LastRun { get; set; }
    /// <summary>Total number of files running</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_RunCount"/>
    /// <remarks>Column <c>RunCount</c>: int, null.</remarks>
    public virtual int? RunCount { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_dteAccessed"/>
    /// <remarks>Column <c>dteAccessed</c>: datetime, null.</remarks>
    public virtual DateTime? dteAccessed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_dteCreated"/>
    /// <remarks>Column <c>dteCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_dteModified"/>
    /// <remarks>Column <c>dteModified</c>: datetime, null.</remarks>
    public virtual DateTime? dteModified { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_intAttribs"/>
    /// <remarks>Column <c>intAttribs</c>: int, null.</remarks>
    public virtual int? intAttribs { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_intDetFileId"/>
    /// <remarks>Column <c>intDetFileId</c>: bigint, not null.</remarks>
    [Key]
    public virtual long intDetFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, null. References <see cref="tblDetect"/>.</remarks>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_lintFileId"/>
    /// <remarks>Column <c>lintFileId</c>: int, null. References <see cref="tblFile"/>.</remarks>
    public virtual int? lintFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetFile.html#Alvao_API_Common_Model_Database_tblDetFile_txtFolderPath"/>
    /// <remarks>Column <c>txtFolderPath</c>: nvarchar(255), null.</remarks>
    public virtual string txtFolderPath { get; set; }
}
