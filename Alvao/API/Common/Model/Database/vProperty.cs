using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// View of the properties of objects, including calculated value ​​for the "User" type property.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vProperty.htm"/>
[TableAttribute("dbo.vProperty")]
public class vProperty
{
    public virtual bool bolInheritable { get; set; }
    public virtual int? intNameOrder { get; set; }
    public virtual int intPropertyId { get; set; }
    public virtual int? intState { get; set; }
    public virtual int? KindDataTypeId { get; set; }
    public virtual int lintKindId { get; set; }
    public virtual int lintNodeId { get; set; }
    public virtual int? NodeIdValue { get; set; }
    public virtual int? ParentNodeId { get; set; }
    public virtual string txtValue { get; set; }

    public vProperty() { }
}
