namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_SectionInheritanceModel.htm"/>
public class SectionInheritanceModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SectionInheritanceModel_iHdSectionId.htm"/>
    public int iHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SectionInheritanceModel_SlaRightsSectionId.htm"/>
    public int SlaRightsSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_SectionInheritanceModel_TargetHdSectionId.htm"/>
    public int? TargetHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/F_Alvao_API_SD_Model_SectionInheritanceModel_Lvl.htm"/>
    public int Lvl;

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_SectionInheritanceModel__ctor.htm"/>
    public SectionInheritanceModel() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_SectionInheritanceModel__ctor_1.htm"/>
    public SectionInheritanceModel(
        int iHdSectionId,
        int? TargetHdSectionId,
        int SlaRightsSectionId,
        int Lvl
    )
    { }
}
