using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - properties.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProperty.htm"/>
[TableAttribute("dbo.tblProperty")]
public class tblProperty
{
    /// <summary>1=property is inherited into the child objects</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_bolInheritable.htm"/>
    public virtual bool bolInheritable { get; set; }
    /// <summary>property value order in object name; If the object name is not created from the property value, the value is 0 or NULL</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_intNameOrder.htm"/>
    public virtual int? intNameOrder { get; set; }
    /// <summary>primary key</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_intPropertyId.htm"/>
    [KeyAttribute]
    public virtual int intPropertyId { get; set; }
    /// <summary>bite field:2 = property locked against deletion</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_intState.htm"/>
    public virtual int? intState { get; set; }
    /// <summary>property type - tblKind</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_lintKindId.htm"/>
    public virtual int lintKindId { get; set; }
    /// <summary>object - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_lintNodeId.htm"/>
    public virtual int lintNodeId { get; set; }
    /// <summary>Object ID - property value for the "User" type property.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_NodeIdValue.htm"/>
    public virtual int? NodeIdValue { get; set; }
    /// <summary>ID of the parent object from which the property is inherited.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_ParentNodeId.htm"/>
    public virtual int? ParentNodeId { get; set; }
    /// <summary>property value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProperty_txtValue.htm"/>
    public virtual string txtValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblProperty__ctor.htm"/>
    public tblProperty() { }
}
