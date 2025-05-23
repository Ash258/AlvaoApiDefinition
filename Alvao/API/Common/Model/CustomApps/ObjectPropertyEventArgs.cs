namespace Alvao.API.Common.Model.CustomApps;

/// <summary>Object Property Modify auto action event parameters</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html"/>
public class ObjectPropertyEventArgs {
    /// <summary>New value of property</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs_NewValue"/>
    public object NewValue { get; set; }

    /// <summary>Object ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs_ObjectId"/>
    public int ObjectId { get; set; }

    /// <summary>Person ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs_PersonId"/>
    public int PersonId { get; set; }

    /// <summary>ID of Property Kind</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs_PropertyKindId"/>
    public int PropertyKindId { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs__ctor"/>
    public ObjectPropertyEventArgs() { }
    /// <param name="objectId"></param>
    /// <param name="propertyKindId"></param>
    /// <param name="personId"></param>
    /// <param name="newValue"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs__ctor_System_Int32_System_Int32_System_Int32_System_Object_"/>
    public ObjectPropertyEventArgs(int objectId, int propertyKindId, int personId, object newValue) { }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.ObjectPropertyEventArgs.html#Alvao_API_Common_Model_CustomApps_ObjectPropertyEventArgs_ToString"/>
    public override string ToString() { throw new System.NotImplementedException(); }

}
