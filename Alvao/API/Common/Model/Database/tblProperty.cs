using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects in the tree - properties.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProperty.htm"/>
[TableAttribute("dbo.tblProperty")]
public class tblProperty
{
    /// <summary>1=property is inherited into the child objects</summary>
    public virtual bool bolInheritable { get; set; }
    /// <summary>property value order in object name; If the object name is not created from the property value, the value is 0 or NULL</summary>
    public virtual int? intNameOrder { get; set; }
    /// <summary>primary key</summary>
    [KeyAttribute]
    public virtual int intPropertyId { get; set; }
    /// <summary>bite field:2 = property locked against deletion</summary>
    public virtual int? intState { get; set; }
    /// <summary>property type - tblKind</summary>
    public virtual int lintKindId { get; set; }
    /// <summary>object - tblNode</summary>
    public virtual int lintNodeId { get; set; }
    /// <summary>Object ID - property value for the "User" type property.</summary>
    public virtual int? NodeIdValue { get; set; }
    /// <summary>ID of the parent object from which the property is inherited.</summary>
    public virtual int? ParentNodeId { get; set; }
    /// <summary>property value</summary>
    public virtual string txtValue { get; set; }

    public tblProperty() { }
}
