namespace Alvao.API.AI.Model;

public class IncidentEntity
{
    public double BadHealthPercent { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    public double MajorIncidentScore { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public IncidentEntity() { }
}
