using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping labor contracts methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.WorkLoad.html"/>
public static class WorkLoad {
    /// <summary>Creates new labor contract to person.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.WorkLoad.html#Alvao_API_SD_WorkLoad_Add_Alvao_API_Common_Model_Database_tWorkLoad_"/>
    /// <param name="model">Labor contract model.</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when model is null.
    /// </exception>
    public static void Add(tWorkLoad model) { throw new System.NotImplementedException(); }
    /// <summary>Removes user's labor contract.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.WorkLoad.html#Alvao_API_SD_WorkLoad_Delete_System_Int32_"/>
    /// <param name="id">Labor contract ID (tWorkLoad.iWorkLoadId)</param>
    public static void Delete(int id) { throw new System.NotImplementedException(); }
    /// <summary>Updates user's labor contract.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.WorkLoad.html#Alvao_API_SD_WorkLoad_Update_Alvao_API_Common_Model_Database_tWorkLoad_"/>
    /// <param name="model">Labor contract model.</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when model is null.
    /// </exception>
    public static void Update(tWorkLoad model) { throw new System.NotImplementedException(); }
}
