using Alvao.API.Common.Model.Database;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of custom fields values in all languages ââused.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html"/>
[Table("dbo.vColumnValueLoc")]
public class vColumnValueLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_ColumnValueLocaleId"/>
    public virtual int ColumnValueLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_ColumnValueShort"/>
    public virtual string ColumnValueShort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_LocalizedColumnValue"/>
    public virtual string LocalizedColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_LocalizedColumnValueShort"/>
    public virtual string LocalizedColumnValueShort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_ParentValue"/>
    public virtual int? ParentValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_iColumnValueId"/>
    public virtual int iColumnValueId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_liColumnId"/>
    public virtual int liColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_liHdSectionId"/>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_mColumnValue"/>
    public virtual string mColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_nOrder"/>
    public virtual double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnValueLoc.html#Alvao_API_Common_Model_Database_vColumnValueLoc_sExtra1"/>
    public virtual string sExtra1 { get; set; }
}
