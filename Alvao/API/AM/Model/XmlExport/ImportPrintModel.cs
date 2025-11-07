namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html"/>
public class ImportPrintModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel_Conclusion"/>
    public string Conclusion { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel_Heading"/>
    public string Heading { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel_Import"/>
    public bool Import { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel_Items"/>
    public HashSet<string> Items { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel_PrintType"/>
    public PrintType PrintType { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel__ctor"/>
    public ImportPrintModel() { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ImportPrintModel.html#Alvao_API_AM_Model_XmlExport_ImportPrintModel_GetResourceText_System_String_System_String_System_Boolean_"/>
    public static string GetResourceText(string resourceName, string defaultText = "", bool isImport = false) { throw new NotImplementedException(); }
}
