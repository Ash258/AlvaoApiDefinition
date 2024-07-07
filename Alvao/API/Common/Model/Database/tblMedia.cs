using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Media.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblMedia.htm"/>
[TableAttribute("dbo.tblMedia")]
public class tblMedia
{
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Identification number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_IdNumber.htm"/>
    public virtual string IdNumber { get; set; }
    /// <summary>Type - tblMediaTypeId</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_lintMediaTypeId.htm"/>
    public virtual int lintMediaTypeId { get; set; }
    /// <summary>Author</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_txtAuthor.htm"/>
    public virtual string txtAuthor { get; set; }
    /// <summary>Location</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_txtLocation.htm"/>
    public virtual string txtLocation { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMedia_txtTitle.htm"/>
    public virtual string txtTitle { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblMedia__ctor.htm"/>
    public tblMedia() { }
}
