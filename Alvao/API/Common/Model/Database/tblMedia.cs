using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Media.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html"/>
[Table("dbo.tblMedia")]
public class tblMedia {
    /// <summary>Identification number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_IdNumber"/>
    /// <remarks>Column <c>IdNumber</c>: nvarchar(255), null.</remarks>
    public virtual string IdNumber { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
    /// <summary>Type - tblMediaTypeId</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_lintMediaTypeId"/>
    /// <remarks>Column <c>lintMediaTypeId</c>: int, not null. References <see cref="tblMediaType"/>.</remarks>
    public virtual int lintMediaTypeId { get; set; }
    /// <summary>Author</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtAuthor"/>
    /// <remarks>Column <c>txtAuthor</c>: nvarchar(255), null.</remarks>
    public virtual string txtAuthor { get; set; }
    /// <summary>Location</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtLocation"/>
    /// <remarks>Column <c>txtLocation</c>: nvarchar(255), null.</remarks>
    public virtual string txtLocation { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtMemo"/>
    /// <remarks>Column <c>txtMemo</c>: nvarchar(max), null.</remarks>
    public virtual string txtMemo { get; set; }
    /// <summary>Name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMedia.html#Alvao_API_Common_Model_Database_tblMedia_txtTitle"/>
    /// <remarks>Column <c>txtTitle</c>: nvarchar(255), null.</remarks>
    public virtual string txtTitle { get; set; }
}
