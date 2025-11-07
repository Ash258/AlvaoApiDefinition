namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html"/>
public class SwLibrary {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.ObjectType.html#fields"/>
    public enum ObjectType {
        None = 0,
        Company = 1,
        Product = 2,
        ProductPack = 3,
        RegImage = 4,
        FileImage = 5,
    }

    /// <summary>Certification autority</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_CA"/>
    public const string CA = "__ALC__";
    /// <summary>&quot;EPSWLIB002&quot; je unicode verze knihovny, starsi nebudeme podporovat</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_LibraryHeader"/>
    public const string LibraryHeader = "EPSWLIB002";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_SubstituteMark"/>
    public const string SubstituteMark = "-SUBSTITUTE-";

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary__ctor_Alvao_API_Utils_ArchiveStream_Alvao_API_AM_Repository_ISwLibRepository_"/>
    public SwLibrary(ArchiveStream archiveStream, ISwLibRepository swLibRepository) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_Load_System_Threading_CancellationToken_"/>
    public void Load(CancellationToken token) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_UpgradeAsync_System_DateTime_System_Threading_CancellationToken_"/>
    public Task<bool> UpgradeAsync(DateTime newSwLibDate, CancellationToken token) { throw new NotImplementedException(); }
}
