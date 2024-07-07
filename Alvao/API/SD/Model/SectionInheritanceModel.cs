namespace Alvao.API.SD.Model;

public class SectionInheritanceModel
{
    public int iHdSectionId { get; set; }
    public int SlaRightsSectionId { get; set; }
    public int? TargetHdSectionId { get; set; }
    public int Lvl;

    public SectionInheritanceModel() { }
    public SectionInheritanceModel(
        int iHdSectionId,
        int? TargetHdSectionId,
        int SlaRightsSectionId,
        int Lvl
    )
    { }
}
