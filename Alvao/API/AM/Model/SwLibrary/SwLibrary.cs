using System.Text.Json;
using Alvao.API.AM.Repository.Interfaces;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html"/>
public class SwLibrary {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.ObjectType.html#fields"/>
    public enum ObjectType {
        None = 0,
        Company = 1,
        Product = 2,
        ProductPack = 3,
        RegImage = 4,
        FileImage = 5,
    }

    /// <summary>Certification autority</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_AlvaoCertificator"/>
    public const string AlvaoCertificator = "__ALC__";
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_CabFileName"/>
    public const string CabFileName = "swlib2.swl";
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_JsonFileExtenstion"/>
    public const string JsonFileExtenstion = ".bin";
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_JsonFileName"/>
    public const string JsonFileName = "swlib.bin";
    /// <summary>"EPSWLIB002" je unicode verze knihovny, starsi nebudeme podporovat</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_LibraryHeader"/>
    public const string LibraryHeader = "EPSWLIB002";
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_SubstituteMark"/>
    public const string SubstituteMark = "-SUBSTITUTE-";

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary__ctor_Alvao_API_AM_Repository_Interfaces_ISwLibRepository_"/>
    public SwLibrary(ISwLibRepository swLibRepository) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_GetJsonSerializerOptions"/>
    public static JsonSerializerOptions GetJsonSerializerOptions() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_Load_System_IO_Stream_System_Threading_CancellationToken_"/>
    public void Load(Stream stream, CancellationToken token) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibrary.html#Alvao_API_AM_Model_SwLibrary_SwLibrary_UpgradeAsync_System_IO_Stream_System_DateTime_System_Threading_CancellationToken_"/>
    public Task<bool> UpgradeAsync(Stream stream, DateTime newSwLibDate, CancellationToken token) { throw new NotImplementedException(); }
}
