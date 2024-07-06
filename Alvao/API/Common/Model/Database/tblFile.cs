using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected files on the computer (SW detection).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFile.htm"/>
[TableAttribute("dbo.tblFile")]
public class tblFile
{
    /// <summary>The date of the library according to which the file has been recognized.</summary>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <summary>Recognized based on the rule.</summary>
    public virtual int? FileImageId { get; set; }
    /// <summary>File signature.</summary>
    public virtual byte[] Hash { get; set; }
    public virtual int? iInsertSourceRecordAuxId { get; set; }
    [KeyAttribute]
    public virtual int intFileId { get; set; }
    public virtual int? intSize { get; set; }
    /// <summary>Original recognized product</summary>
    public virtual int? OriginalProductId { get; set; }
    /// <summary>Recognized product.</summary>
    public virtual int? ProductId { get; set; }
    public virtual string txtExt { get; set; }
    public virtual string txtName { get; set; }

    public tblFile() { }
}
