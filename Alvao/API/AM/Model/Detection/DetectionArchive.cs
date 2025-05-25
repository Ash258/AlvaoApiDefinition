using System.Xml;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html"/>
public class DetectionArchive : ArchiveStream, IAsyncDisposable, IDisposable {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.ObjectType.html#fields"/>
    public enum ObjectType {
        None = 0,
        OsVersionInfo = 1,
        RegValue = 2,
        Folder = 3,
        File = 4,
        FileVerInfo = 5,
        FileStringInfo = 6,
        OsVersionInfoEx = 7,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.Version.html#fields"/>
    public enum Version {
        OldAnsi = 0,
        Unicode = 1,
        UnicodeWithDuration = 2,
        UnicodeWithSwUsage = 3,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html#Alvao_API_AM_Model_Detection_DetectionArchive_ArchiveVersions"/>
    public static Dictionary<string, DetectionArchive.Version> ArchiveVersions;

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html#Alvao_API_AM_Model_Detection_DetectionArchive_ArchiveVersion"/>
    public DetectionArchive.Version ArchiveVersion { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html#Alvao_API_AM_Model_Detection_DetectionArchive_IsUnicode"/>
    public override bool IsUnicode { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html#Alvao_API_AM_Model_Detection_DetectionArchive_UnicodeArchiveHeader"/>
    public static string UnicodeArchiveHeader { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html#Alvao_API_AM_Model_Detection_DetectionArchive__ctor_System_Xml_XmlNode_"/>
    public DetectionArchive(XmlNode xmlDataNode) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionArchive.html#Alvao_API_AM_Model_Detection_DetectionArchive_ReadObjectType"/>
    public DetectionArchive.ObjectType ReadObjectType() { throw new System.NotImplementedException(); }
    /// <summary>!!!CAUTION: This method is not document. It was generated as empty, to make the project compilable</summary>
    public void Dispose() { throw new System.NotImplementedException(); }
    /// <summary>!!!CAUTION: This method is not document. It was generated as empty, to make the project compilable</summary>
    public System.Threading.Tasks.ValueTask DisposeAsync() { throw new System.NotImplementedException(); }
}
