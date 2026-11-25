using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping properties to system functions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html"/>
[Table("dbo.tblPropertyMap")]
public class tblPropertyMap {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_intPropertyMapId"/>
    /// <remarks>Column <c>intPropertyMapId</c>: int, not null.</remarks>
    [Key]
    public virtual int intPropertyMapId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintKindId"/>
    /// <remarks>Column <c>lintKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintMapKindId"/>
    /// <remarks>Column <c>lintMapKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? lintMapKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintMapObjClassId"/>
    /// <remarks>Column <c>lintMapObjClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? lintMapObjClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintMapObjKindId"/>
    /// <remarks>Column <c>lintMapObjKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? lintMapObjKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintObjClassId"/>
    /// <remarks>Column <c>lintObjClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? lintObjClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintObjKindId"/>
    /// <remarks>Column <c>lintObjKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? lintObjKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintPropertyMapTypeId"/>
    /// <remarks>Column <c>lintPropertyMapTypeId</c>: int, null.</remarks>
    public virtual int? lintPropertyMapTypeId { get; set; }
}
