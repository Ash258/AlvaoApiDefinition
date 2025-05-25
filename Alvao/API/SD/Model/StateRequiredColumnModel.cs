using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.StateRequiredColumnModel.html"/>
public class StateRequiredColumnModel : vColumnLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.StateRequiredColumnModel.html#Alvao_API_SD_Model_StateRequiredColumnModel_AreObjects"/>
    public bool AreObjects { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.StateRequiredColumnModel.html#Alvao_API_SD_Model_StateRequiredColumnModel_IsDeadline"/>
    public bool IsDeadline { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.StateRequiredColumnModel.html#Alvao_API_SD_Model_StateRequiredColumnModel_IsSystem"/>
    public bool IsSystem { get; set; }
    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.StateRequiredColumnModel.html#Alvao_API_SD_Model_StateRequiredColumnModel_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new System.NotImplementedException(); }
}
