using System.Xml;
using System.Xml.XPath;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanProcessor.html"/>
public class ScanProcessor : XmlDocument, System.Collections.IEnumerable, ICloneable, IXPathNavigable {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanProcessor.html#Alvao_API_AM_Model_Detection_ScanProcessor_SwLibComputerName"/>
    public static string SwLibComputerName;

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanProcessor.html#Alvao_API_AM_Model_Detection_ScanProcessor_IsSwLibDetection"/>
    public bool IsSwLibDetection { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanProcessor.html#Alvao_API_AM_Model_Detection_ScanProcessor_PersonId"/>
    public int PersonId { get; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanProcessor.html#Alvao_API_AM_Model_Detection_ScanProcessor_LoadJson_System_IO_Stream_Alvao_API_AM_Model_Detection_ScanLoadSettings_System_Threading_CancellationToken_"/>
    public DetectionInfo LoadJson(Stream stream, ScanLoadSettings loadSettings, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanProcessor.html#Alvao_API_AM_Model_Detection_ScanProcessor_LoadXml_System_IO_MemoryStream_Alvao_API_AM_Model_Detection_ScanLoadSettings_System_Threading_CancellationToken_"/>
    public DetectionInfo LoadXml(MemoryStream xmlStream, ScanLoadSettings loadSettings, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <summary>
    /// !!!CAUTION: This member of ICloneable is not documented. It was generated as empty, to make the project
    /// compilable
    /// </summary>
    public object Clone() { throw new NotImplementedException(); }
    /// <summary>
    /// !!!CAUTION: This member of IXPathNavigable is not documented. It was generated as empty, to make the project
    /// compilable
    /// </summary>
    public System.Xml.XPath.XPathNavigator? CreateNavigator() { throw new NotImplementedException(); }
}
