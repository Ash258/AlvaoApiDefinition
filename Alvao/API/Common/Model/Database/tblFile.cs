using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files on the computer (SW detection).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html"/>
[Table("dbo.tblFile")]
public class tblFile {
    /// <summary>The date of the library according to which the file has been recognized.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_EvalSwLibDate"/>
    /// <remarks>Column <c>EvalSwLibDate</c>: datetime, null.</remarks>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <summary>Recognized based on the rule.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_FileImageId"/>
    /// <remarks>Column <c>FileImageId</c>: int, null. References <see cref="tblFileImage"/>.</remarks>
    public virtual int? FileImageId { get; set; }
    /// <summary>File signature.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_Hash"/>
    /// <remarks>Column <c>Hash</c>: varbinary, not null.</remarks>
    public virtual byte[] Hash { get; set; }
    /// <summary>Original recognized product</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_OriginalProductId"/>
    /// <remarks>Column <c>OriginalProductId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? OriginalProductId { get; set; }
    /// <summary>Recognized product.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_ProductId"/>
    /// <remarks>Column <c>ProductId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_iInsertSourceRecordAuxId"/>
    /// <remarks>Column <c>iInsertSourceRecordAuxId</c>: int, null.</remarks>
    public virtual int? iInsertSourceRecordAuxId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_intFileId"/>
    /// <remarks>Column <c>intFileId</c>: int, not null.</remarks>
    [Key]
    public virtual int intFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_intSize"/>
    /// <remarks>Column <c>intSize</c>: int, null.</remarks>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_txtExt"/>
    /// <remarks>Column <c>txtExt</c>: nvarchar(255), null.</remarks>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), null.</remarks>
    public virtual string txtName { get; set; }
}
