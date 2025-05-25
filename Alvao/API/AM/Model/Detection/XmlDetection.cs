using System.Collections;
using System.Xml;
using System.Xml.XPath;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.XmlDetection.html"/>
public class XmlDetection : XmlDocument, IEnumerable, ICloneable, IXPathNavigable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.XmlDetection.html#Alvao_API_AM_Model_Detection_XmlDetection_PersonId"/>
    public int PersonId { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.XmlDetection.html#Alvao_API_AM_Model_Detection_XmlDetection_ElementStringValue_System_Xml_XmlDocument_System_String_"/>
    public static string ElementStringValue(XmlDocument xml, string xpath) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.XmlDetection.html#Alvao_API_AM_Model_Detection_XmlDetection_EncodeInvalidXmlChars_System_IO_MemoryStream_"/>
    public static string EncodeInvalidXmlChars(MemoryStream xmlStream) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.XmlDetection.html#Alvao_API_AM_Model_Detection_XmlDetection_Load_System_IO_MemoryStream_Alvao_API_AM_Model_Detection_ScanLoadSettings_System_Threading_CancellationToken_"/>
    public DetectionInfo Load(MemoryStream xmlStream, ScanLoadSettings loadSettings, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <summary>!!!CAUTION: This method is not document. It was generated as empty, to make the project compilable</summary>
    public object Clone() { throw new NotImplementedException(); }
}
