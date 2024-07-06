using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Properties of objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyKind.htm"/>
[TableAttribute("dbo.vPropertyKind")]
public class vPropertyKind
{
    public virtual bool? bCanModify { get; set; }
    public virtual bool? bDetected { get; set; }
    public virtual bool? bFromAD { get; set; }
    public virtual bool bolInheritable { get; set; }
    public virtual int? intKindCode { get; set; }
    public virtual int? intNameOrder { get; set; }
    public virtual int intPropertyId { get; set; }
    public virtual int? intState { get; set; }
    public virtual int lintKindId { get; set; }
    public virtual int lintNodeId { get; set; }
    public virtual int? NodeIdValue { get; set; }
    public virtual string txtKind { get; set; }
    public virtual string txtValue { get; set; }

    public vPropertyKind() { }
}
