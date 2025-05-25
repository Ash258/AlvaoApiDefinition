using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files on the computer (SW detection).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html"/>
[Table("dbo.tblFile")]
public class tblFile {
    /// <summary>The date of the library according to which the file has been recognized.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_EvalSwLibDate"/>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <summary>Recognized based on the rule.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_FileImageId"/>
    public virtual int? FileImageId { get; set; }
    /// <summary>File signature.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_Hash"/>
    public virtual byte[] Hash { get; set; }
    /// <summary>Original recognized product</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_OriginalProductId"/>
    public virtual int? OriginalProductId { get; set; }
    /// <summary>Recognized product.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_ProductId"/>
    public virtual int? ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_iInsertSourceRecordAuxId"/>
    public virtual int? iInsertSourceRecordAuxId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_intFileId"/>
    [Key]
    public virtual int intFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_intSize"/>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_txtExt"/>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFile.html#Alvao_API_Common_Model_Database_tblFile_txtName"/>
    public virtual string txtName { get; set; }
}
