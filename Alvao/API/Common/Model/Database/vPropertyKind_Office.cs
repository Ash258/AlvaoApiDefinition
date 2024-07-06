using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Properties of objects - Office.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyKind_Office.htm"/>
[TableAttribute("dbo.vPropertyKind_Office")]
public class vPropertyKind_Office
{
    public virtual bool bolInheritable { get; set; }
    public virtual int? intNameOrder { get; set; }
    public virtual int intPropertyId { get; set; }
    public virtual int? intState { get; set; }
    public virtual int lintKindId { get; set; }
    public virtual int lintNodeId { get; set; }
    public virtual string txtKind { get; set; }
    public virtual string txtValue { get; set; }

    public vPropertyKind_Office() { }
}
