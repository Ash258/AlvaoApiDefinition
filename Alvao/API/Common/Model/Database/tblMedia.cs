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
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Identification number</summary>
    public virtual string IdNumber { get; set; }
    /// <summary>Type - tblMediaTypeId</summary>
    public virtual int lintMediaTypeId { get; set; }
    /// <summary>Author</summary>
    public virtual string txtAuthor { get; set; }
    /// <summary>Location</summary>
    public virtual string txtLocation { get; set; }
    /// <summary>Note</summary>
    public virtual string txtMemo { get; set; }
    /// <summary>Name</summary>
    public virtual string txtTitle { get; set; }

    public tblMedia() { }
}
