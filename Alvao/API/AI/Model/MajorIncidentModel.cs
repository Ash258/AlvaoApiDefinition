namespace Alvao.API.AI.Model;

public class MajorIncidentModel
{
    public List<SimilarEntity> BadHealthServices { get; set; }
    public List<IncidentEntity> CriticalServiceNodes { get; set; }
    public IncidentEntity CriticalServiceSection { get; set; }
    public string Formula { get; set; }
    public List<SimilarEntity> RecentChanges { get; set; }
    public double RecentIncidentHours { get; set; }
    public List<SimilarEntity> RecentIncidents { get; set; }
    public double Score { get; set; }
    public List<SimilarEntity> SimilarIncidents { get; set; }

    public MajorIncidentModel() { }
}
