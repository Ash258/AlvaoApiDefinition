using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Properties of objects - Name.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyKind_Name.htm"/>
[TableAttribute("dbo.vPropertyKind_Name")]
public class vPropertyKind_Name
{
    public virtual bool bolInheritable { get; set; }
    public virtual int? intNameOrder { get; set; }
    public virtual int intPropertyId { get; set; }
    public virtual int? intState { get; set; }
    public virtual int lintKindId { get; set; }
    public virtual int lintNodeId { get; set; }
    public virtual string txtKind { get; set; }
    public virtual string txtValue { get; set; }

    public vPropertyKind_Name() { }
}
