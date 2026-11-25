using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html"/>
[Table("dbo.ReturnedAsset")]
public class ReturnedAsset {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_AuthorPersonId"/>
    /// <remarks>Column <c>AuthorPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int AuthorPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_ChangeDate"/>
    /// <remarks>Column <c>ChangeDate</c>: datetime, not null.</remarks>
    public virtual DateTime ChangeDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_FromPersonId"/>
    /// <remarks>Column <c>FromPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int FromPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReturnedAsset.html#Alvao_API_Common_Model_Database_ReturnedAsset_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
