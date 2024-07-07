namespace Alvao.API.SD.Model;

/// <summary>Model representing act costs.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_CostModel.htm"/>
public class CostModel
{
    /// <summary>Exclude from invoice</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CostModel_DontCharge.htm"/>
    public bool DontCharge { get; set; }
    /// <summary>Distance</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CostModel_TravelDistance.htm"/>
    public double? TravelDistance { get; set; }
    /// <summary>Time traveled.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CostModel_TravelTime.htm"/>
    public TimeSpan? TravelTime { get; set; }
    /// <summary>Work</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_CostModel_WorkTime.htm"/>
    public TimeSpan? WorkTime { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_CostModel__ctor.htm"/>
    public CostModel() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_CostModel_Equals.htm"/>
    ///
    /// <param name="obj"> </param>
    public override bool Equals(
        Object obj
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_CostModel_GetHashCode.htm"/>
    public override int GetHashCode() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_CostModel_ToString.htm"/>
    public override string ToString() { throw new System.NotImplementedException(); }
}
