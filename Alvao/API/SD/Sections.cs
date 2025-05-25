namespace Alvao.API.SD;

/// <summary>Facade class grouping requests methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html"/>
public static class Sections {
    /// <summary>Export sections into xml file.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html#Alvao_API_SD_Sections_Export_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="sectionId">Root section id ((tHdSection.iHdSectionId)) to export. Null for all sections.</param>
    /// <param name="includeSubtree">True if whole tree should be exported</param>
    /// <returns>Memory stream with xml</returns>
    public static MemoryStream Export(int? sectionId, bool includeSubtree) { throw new NotImplementedException(); }
    /// <summary>Export sections into xml file. ExportSections is deprecated, please use Export instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html#Alvao_API_SD_Sections_ExportSections_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="sectionId">Root section id ((tHdSection.iHdSectionId)) to export. Null for all sections.</param>
    /// <param name="includeSubtree">True if whole tree should be exported</param>
    /// <returns>Memory stream with xml</returns>
    [Obsolete("ExportSections is deprecated, please use Export instead.")]
    public static MemoryStream ExportSections(int? sectionId, bool includeSubtree) { throw new NotImplementedException(); }
    /// <summary>Imports sections into db.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html#Alvao_API_SD_Sections_Import_System_Nullable_System_Int32__Alvao_API_SD_Model_XmlExport_AlvaoConfigurationXmlModel_System_Int32_"/>
    /// <param name="sectionId">Id ((tHdSection.iHdSectionId)) of parent section to import sections. Null if import is into tree root.</param>
    /// <param name="sections">Model of exported xml file</param>
    /// <param name="personId">Person id who imports sections</param>
    /// <returns>Memory stream with xml</returns>
    public static ImportViewModel Import(int? sectionId, AlvaoConfigurationXmlModel sections, int personId) { throw new NotImplementedException(); }
    /// <summary>Imports sections into db. ImportSections is deprecated, please use Import instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html#Alvao_API_SD_Sections_ImportSections_System_Nullable_System_Int32__Alvao_API_SD_Model_XmlExport_AlvaoConfigurationXmlModel_System_Int32_"/>
    /// <param name="sectionId">Id ((tHdSection.iHdSectionId)) of parent section to import sections. Null if import is into tree root.</param>
    /// <param name="sections">Model of exported xml file</param>
    /// <param name="personId">Person id who imports sections</param>
    /// <returns>Memory stream with xml</returns>
    [Obsolete("ImportSections is deprecated, please use Import instead.")]
    public static ImportViewModel ImportSections(int? sectionId, AlvaoConfigurationXmlModel sections, int personId) { throw new NotImplementedException(); }
    /// <summary>Validates sections model before import.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html#Alvao_API_SD_Sections_ValidateBeforeImport_System_Nullable_System_Int32__Alvao_API_SD_Model_XmlExport_AlvaoConfigurationXmlModel_System_Int32_"/>
    /// <param name="sectionId">Id ((tHdSection.iHdSectionId)) of parent section to import sections. Null if import is into tree root.</param>
    /// <param name="sections">Model of exported xml file</param>
    /// <param name="personId">Person id who imports sections</param>
    /// <returns>Memory stream with xml</returns>
    public static ImportViewModel ValidateBeforeImport(int? sectionId, AlvaoConfigurationXmlModel sections, int personId) { throw new NotImplementedException(); }
    /// <summary>Validates sections model before import. ValidateSectionsBeforeImport is deprecated, please use ValidateBeforeImport instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Sections.html#Alvao_API_SD_Sections_ValidateSectionsBeforeImport_System_Nullable_System_Int32__Alvao_API_SD_Model_XmlExport_AlvaoConfigurationXmlModel_System_Int32_"/>
    /// <param name="sectionId">Id ((tHdSection.iHdSectionId)) of parent section to import sections. Null if import is into tree root.</param>
    /// <param name="sections">Model of exported xml file</param>
    /// <param name="personId">Person id who imports sections</param>
    /// <returns>Memory stream with xml</returns>
    [Obsolete("ValidateSectionsBeforeImport is deprecated, please use ValidateBeforeImport instead.")]
    public static ImportViewModel ValidateSectionsBeforeImport(int? sectionId, AlvaoConfigurationXmlModel sections, int personId) { throw new NotImplementedException(); }
}
