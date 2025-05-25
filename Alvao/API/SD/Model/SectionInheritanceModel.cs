namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html"/>
public class SectionInheritanceModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html#Alvao_API_SD_Model_SectionInheritanceModel_Lvl"/>
    public int Lvl;

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html#Alvao_API_SD_Model_SectionInheritanceModel_SectionId"/>
    public int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html#Alvao_API_SD_Model_SectionInheritanceModel_SlaRightsSectionId"/>
    public int SlaRightsSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html#Alvao_API_SD_Model_SectionInheritanceModel_TargetHdSectionId"/>
    public int? TargetHdSectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html#Alvao_API_SD_Model_SectionInheritanceModel__ctor"/>
    public SectionInheritanceModel() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.SectionInheritanceModel.html#Alvao_API_SD_Model_SectionInheritanceModel__ctor_System_Int32_System_Nullable_System_Int32__System_Int32_System_Int32_"/>
    public SectionInheritanceModel(int sectionId, int? targetHdSectionId, int slaRightsSectionId, int lvl) { }
}
