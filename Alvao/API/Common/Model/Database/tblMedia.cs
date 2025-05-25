using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Media.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html"/>
[Table("dbo.tblMedia")]
public class tblMedia {
    /// <summary>Identification number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_IdNumber"/>
    public virtual string IdNumber { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <summary>Type - tblMediaTypeId</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_lintMediaTypeId"/>
    public virtual int lintMediaTypeId { get; set; }
    /// <summary>Author</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtAuthor"/>
    public virtual string txtAuthor { get; set; }
    /// <summary>Location</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtLocation"/>
    public virtual string txtLocation { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtMemo"/>
    public virtual string txtMemo { get; set; }
    /// <summary>Name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtTitle"/>
    public virtual string txtTitle { get; set; }
}
