using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html"/>
[Table("dbo.ReturnedAsset")]
public class ReturnedAsset {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_AuthorPersonId"/>
    public virtual int AuthorPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_ChangeDate"/>
    public virtual DateTime ChangeDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_FromPersonId"/>
    public virtual int FromPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_NodeId"/>
    public virtual int NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_id"/>
    [Key]
    public virtual int id { get; set; }
}
