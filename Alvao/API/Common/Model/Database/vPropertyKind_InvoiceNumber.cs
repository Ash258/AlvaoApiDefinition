using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Packing slip number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InvoiceNumber.html"/>
[Table("dbo.vPropertyKind_InvoiceNumber")]
public class vPropertyKind_InvoiceNumber {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InvoiceNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InvoiceNumber_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InvoiceNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InvoiceNumber_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InvoiceNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InvoiceNumber_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InvoiceNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InvoiceNumber_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_InvoiceNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_InvoiceNumber_txtValue"/>
    public virtual string txtValue { get; set; }
}
