using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected files on the computer (SW detection).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFile.htm"/>
[TableAttribute("dbo.tblFile")]
public class tblFile {
    /// <summary>The date of the library according to which the file has been recognized.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_EvalSwLibDate.htm"/>
    public virtual DateTime? EvalSwLibDate { get; set; }
    /// <summary>Recognized based on the rule.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_FileImageId.htm"/>
    public virtual int? FileImageId { get; set; }
    /// <summary>File signature.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_Hash.htm"/>
    public virtual byte[] Hash { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_iInsertSourceRecordAuxId.htm"/>
    public virtual int? iInsertSourceRecordAuxId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_intFileId.htm"/>
    [KeyAttribute]
    public virtual int intFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_intSize.htm"/>
    public virtual int? intSize { get; set; }
    /// <summary>Original recognized product</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_OriginalProductId.htm"/>
    public virtual int? OriginalProductId { get; set; }
    /// <summary>Recognized product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_ProductId.htm"/>
    public virtual int? ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_txtExt.htm"/>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFile_txtName.htm"/>
    public virtual string txtName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblFile__ctor.htm"/>
    public tblFile() { }
}
