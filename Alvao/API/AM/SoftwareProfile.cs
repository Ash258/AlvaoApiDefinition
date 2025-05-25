using Alvao.API.AM.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SoftwareProfile.html"/>
public static class SoftwareProfile {
    /// <summary>Gets software profile DB model by its ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SoftwareProfile.html#Alvao_API_AM_SoftwareProfile_GetById_System_Int32_"/>
    /// <param name="id">Software profile ID (tSwProfile.iSwProfileId)</param>
    public static tSwProfile GetById(int id) { throw new System.NotImplementedException(); }
    /// <summary>Gets software profile exceptions for a list of object IDs</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SoftwareProfile.html#Alvao_API_AM_SoftwareProfile_GetObjectsExceptions_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="objectIds">List of object IDs (tblNode.intNodeId)</param>
    public static IEnumerable<ObjectSoftwareProfileException> GetObjectsExceptions(IEnumerable<int> objectIds) { throw new System.NotImplementedException(); }
    /// <summary>Sets software profile settings to objects</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SoftwareProfile.html#Alvao_API_AM_SoftwareProfile_Set_System_Collections_Generic_IEnumerable_System_Int32__System_Boolean_System_Nullable_System_Int32__System_Collections_Generic_IEnumerable_Alvao_API_AM_Model_SoftwareProfileException__"/>
    /// <param name="objectIds">List of object IDs (tblNode.intNodeId)</param>
    /// <param name="allowAllSoftware">If true, allows all software and software profile will be ignored</param>
    /// <param name="profileId">Software profile ID (tSwProfile.iSwProfileId)</param>
    /// <param name="exceptions">List of exceptions</param>
    public static void Set(IEnumerable<int> objectIds, bool allowAllSoftware, int? profileId, IEnumerable<SoftwareProfileException> exceptions) { throw new System.NotImplementedException(); }
}
