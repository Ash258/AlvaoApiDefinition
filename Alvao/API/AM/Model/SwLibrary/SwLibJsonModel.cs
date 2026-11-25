using System.Runtime.Serialization;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html"/>
[DataContract]
public class SwLibJsonModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_Certificator"/>
    [DataMember(Name = "certificator")]
    public string Certificator { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_Companies"/>
    [DataMember(Name = "companies")]
    public List<SwLibCompany> Companies { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_Date"/>
    [DataMember(Name = "date")]
    public DateTime Date { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_FileImages"/>
    [DataMember(Name = "fileImages")]
    public List<SwLibFileImage> FileImages { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_FormatVersion"/>
    [DataMember(Name = "formatVersion")]
    public int FormatVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_ProductPacks"/>
    [DataMember(Name = "productPacks")]
    public List<SwLibProductPack> ProductPacks { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_Products"/>
    [DataMember(Name = "products")]
    public List<SwLibProduct> Products { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibJsonModel.html#Alvao_API_AM_Model_SwLibrary_SwLibJsonModel_RegImages"/>
    [DataMember(Name = "regImages")]
    public List<SwLibRegImage> RegImages { get; set; }
}
