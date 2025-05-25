using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping properties to system functions.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html"/>
[Table("dbo.tblPropertyMap")]
public class tblPropertyMap {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_intPropertyMapId"/>
    [Key]
    public virtual int intPropertyMapId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintKindId"/>
    public virtual int? lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintMapKindId"/>
    public virtual int? lintMapKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintMapObjClassId"/>
    public virtual int? lintMapObjClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintMapObjKindId"/>
    public virtual int? lintMapObjKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintObjClassId"/>
    public virtual int? lintObjClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintObjKindId"/>
    public virtual int? lintObjKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblPropertyMap.html#Alvao_API_Common_Model_Database_tblPropertyMap_lintPropertyMapTypeId"/>
    public virtual int? lintPropertyMapTypeId { get; set; }
}
