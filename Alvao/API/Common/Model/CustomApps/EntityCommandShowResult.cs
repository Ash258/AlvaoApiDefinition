namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html"/>
public class EntityCommandShowResult {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Entity"/>
    public Entity Entity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Icon"/>
    public string Icon { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Id"/>
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Position"/>
    public int Position { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Show"/>
    public bool Show { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult__ctor"/>
    public EntityCommandShowResult() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult__ctor_System_Boolean_System_String_System_String_System_Int32_"/>
    public EntityCommandShowResult(bool show, string name, string icon, int position) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_CommandDescToShowResult_Alvao_API_Common_Model_CustomApps_CommandDesc_"/>
    public static EntityCommandShowResult CommandDescToShowResult(CommandDesc commandDesc) { throw new NotImplementedException(); }
    /// <summary>Determines whether the specified object is equal to the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_Equals_System_Object_"/>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj) { throw new NotImplementedException(); }
    /// <summary>Serves as the default hash function.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityCommandShowResult.html#Alvao_API_Common_Model_CustomApps_EntityCommandShowResult_GetHashCode"/>
    /// <returns>A hash code for the current object.</returns>
    public override int GetHashCode() { throw new NotImplementedException(); }
}
