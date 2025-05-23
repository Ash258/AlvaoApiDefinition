namespace Alvao.API.SD;

/// <summary>Facade class grouping requests methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Sections.htm"/>
public static class Sections {

    /// <summary>Export sections into xml file.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Sections_Export.htm"/>
    ///
    /// <param name="sectionId">Root section id ((tHdSection.iHdSectionId)) to export. Null for all sections.</param>
    /// <param name="includeSubtree">True if whole tree should be exported</param>
    public static MemoryStream Export(
        int? sectionId,
        bool includeSubtree
    ) { throw new System.NotImplementedException(); }
}
