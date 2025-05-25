using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of media.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html"/>
[Table("dbo.vMediaList")]
public class vMediaList {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_IdNumber"/>
    public virtual string IdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_id"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_lintMediaTypeId"/>
    public virtual int lintMediaTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_txtAuthor"/>
    public virtual string txtAuthor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_txtLocation"/>
    public virtual string txtLocation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_txtMediaType"/>
    public virtual string txtMediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaList.html#Alvao_API_Common_Model_Database_vMediaList_txtTitle"/>
    public virtual string txtTitle { get; set; }
}
