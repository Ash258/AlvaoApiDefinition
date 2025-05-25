namespace Alvao.API.SD.Model;

/// <summary>Model representing act costs.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html"/>
public class CostModel {
    /// <summary>Exclude from invoice</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_DontCharge"/>
    public bool DontCharge { get; set; }
    /// <summary>Distance</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_TravelDistance"/>
    public double? TravelDistance { get; set; }
    /// <summary>Time traveled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_TravelTime"/>
    public TimeSpan? TravelTime { get; set; }
    /// <summary>Work</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_WorkTime"/>
    public TimeSpan? WorkTime { get; set; }
    /// <summary>Determines whether the specified object is equal to the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_Equals_System_Object_"/>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj) { throw new NotImplementedException(); }
    /// <summary>Serves as the default hash function.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_GetHashCode"/>
    /// <returns>A hash code for the current object.</returns>
    public override int GetHashCode() { throw new NotImplementedException(); }
    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.CostModel.html#Alvao_API_SD_Model_CostModel_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new NotImplementedException(); }
}
