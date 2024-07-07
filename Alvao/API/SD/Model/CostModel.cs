namespace Alvao.API.SD.Model;

/// <summary>
/// Model representing act costs.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_CostModel.htm"/>
public class CostModel
{
    /// <summary>Exclude from invoice</summary>
    public bool DontCharge { get; set; }
    /// <summary>Distance</summary>
    public double? TravelDistance { get; set; }
    /// <summary>Time traveled.</summary>
    public TimeSpan? TravelTime { get; set; }
    /// <summary>Work</summary>
    public TimeSpan? WorkTime { get; set; }

    public CostModel() { }

    /// <param name="obj"> </param>
    public override bool Equals(
        Object obj
    )
    { throw new System.NotImplementedException(); }

    public override int GetHashCode() { throw new System.NotImplementedException(); }

    public override string ToString() { throw new System.NotImplementedException(); }
}
