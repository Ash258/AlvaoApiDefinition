using Alvao.API.Common.Model.Database;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of the names and descriptions of custom fields in all languages ââused.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html"/>
[Table("dbo.vColumnLoc")]
public class vColumnLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_ColumnLocaleId"/>
    public virtual int ColumnLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_Localize"/>
    public virtual bool Localize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_LocalizedDescription"/>
    public virtual string LocalizedDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_LocalizedTitle"/>
    public virtual string LocalizedTitle { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_MaxLength"/>
    public virtual int? MaxLength { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_Multiline"/>
    public virtual bool Multiline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_Precision"/>
    public virtual int? Precision { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_Type"/>
    public virtual string Type { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_bUseColumnValue"/>
    public virtual bool bUseColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_iColumnId"/>
    public virtual int iColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_mDescription"/>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_nOrder"/>
    public virtual double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_sColumn"/>
    public virtual string sColumn { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_sTable"/>
    public virtual string sTable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vColumnLoc.html#Alvao_API_Common_Model_Database_vColumnLoc_sTitle"/>
    public virtual string sTitle { get; set; }
}
