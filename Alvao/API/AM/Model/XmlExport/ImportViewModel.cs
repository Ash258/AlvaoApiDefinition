namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html"/>
public class ImportViewModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_Action"/>
    public ImportAction Action { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_ErrorMessage"/>
    public string ErrorMessage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_FileName"/>
    public string FileName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_HtmlInfo"/>
    public string HtmlInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_ImportPrintModel"/>
    public List<ImportPrintModel> ImportPrintModel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_IsTemplates"/>
    public bool IsTemplates { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_IsValid"/>
    public bool IsValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_ParentTemplateId"/>
    public int? ParentTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_XmlGuid"/>
    public string XmlGuid { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel__ctor"/>
    public ImportViewModel() { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_AddItem_System_String_Alvao_API_AM_Model_XmlExport_PrintType_"/>
    public void AddItem(string value, PrintType type) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportViewModel.html#Alvao_API_AM_Model_XmlExport_ImportViewModel_BuildHtml_System_Boolean_"/>
    public void BuildHtml(bool import) { throw new NotImplementedException(); }
}
