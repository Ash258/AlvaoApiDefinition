using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Vendor.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Vendor.html"/>
[Table("dbo.vPropertyKind_Vendor")]
public class vPropertyKind_Vendor {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Vendor.html#Alvao_API_Common_Model_Database_vPropertyKind_Vendor_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Vendor.html#Alvao_API_Common_Model_Database_vPropertyKind_Vendor_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Vendor.html#Alvao_API_Common_Model_Database_vPropertyKind_Vendor_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Vendor.html#Alvao_API_Common_Model_Database_vPropertyKind_Vendor_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Vendor.html#Alvao_API_Common_Model_Database_vPropertyKind_Vendor_txtValue"/>
    public virtual string txtValue { get; set; }
}
