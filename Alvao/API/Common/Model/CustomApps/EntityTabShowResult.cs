namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html"/>
public class EntityTabShowResult {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_Id"/>
    public string Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_Show"/>
    public bool Show { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_Url"/>
    public string Url { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult__ctor"/>
    public EntityTabShowResult() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult__ctor_System_Boolean_System_String_System_String_"/>
    public EntityTabShowResult(bool show, string name, string url) { }

    /// <summary>Determines whether the specified object is equal to the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_Equals_System_Object_"/>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj) { throw new System.NotImplementedException(); }
    /// <summary>Serves as the default hash function.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_GetHashCode"/>
    /// <returns>A hash code for the current object.</returns>
    public override int GetHashCode() { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.EntityTabShowResult.html#Alvao_API_Common_Model_CustomApps_EntityTabShowResult_ViewDescToShowTab_Alvao_API_Common_Model_CustomApps_CustomViewDesc_"/>
    public static EntityTabShowResult ViewDescToShowTab(CustomViewDesc x) { throw new System.NotImplementedException(); }
}
