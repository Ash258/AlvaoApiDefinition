using Alvao.API.AM.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>
/// Facade class grouping object property methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_ObjectProperty.htm"/>
public static class ObjectProperty
{

    /// <summary>Adds property to object template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectProperty_Add.htm"/>
    ///
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="kindId">Property kind id (tblKind.intKindId)</param>
    /// <param name="value">New property value</param>
    /// <param name="order">Order in object name</param>
    /// <param name="inheritable">Inherit property into child objects</param>
    public static int Add(
        int objectId,
        int kindId,
        string value,
        int? order,
        bool inheritable
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Return possible values for property</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectProperty_GetPosibleValues.htm"/>
    ///
    /// <param name="property">Groups properties connected to property.</param>
    public static IEnumerable<tblKindValue> GetPosibleValues(
        Property property
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Return template properties for specific object kind.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectProperty_GetTemplateProperties.htm"/>
    ///
    /// <param name="classCode">Object (template) class (tblClass.intClassId)</param>
    public static IEnumerable<tblKind> GetTemplateProperties(
        tblClass.ClassCode classCode
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether object template contains specific property</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectProperty_TemplateContains.htm"/>
    ///
    /// <param name="classId">Object (template) class (tblClass.intClassId)</param>
    /// <param name="kindCode">Property kind code (tblKind.intKindCode)</param>
    public static bool TemplateContains(
        int classId,
        tblKind.KindCode kindCode
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Updates value of one property on specific object</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectProperty_Update.htm"/>
    ///
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="kindCode">Property kind code (tblKind.intKindCode)</param>
    /// <param name="value">New property value</param>
    /// <param name="callCustomAction">If true, object property auto actions are triggered. Default value is true.</param>
    public static void Update(
        int objectId,
        tblKind.KindCode kindCode,
        string value,
        bool callCustomAction = true
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Updates object properties.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectProperty_Update_1.htm"/>
    ///
    /// <param name="personId">Person ID (who updates properties) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="properties">Object properties to update</param>
    /// <param name="callCustomAction">If true, object property auto actions are triggered. Default value is true.</param>
    public static void Update(
        int personId,
        int objectId,
        IDictionary<string, string> properties,
        bool callCustomAction = true
    )
    { throw new System.NotImplementedException(); }
}
