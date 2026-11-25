using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Alvao.API.Utils;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html"/>
[DataContract]
public class SwLibCompany : SwLibBase {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Address1"/>
    [DataMember(Name = "address1")]
    public string Address1 { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Address2"/>
    [DataMember(Name = "address2")]
    public string Address2 { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_City"/>
    [DataMember(Name = "city")]
    public string City { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Description"/>
    [DataMember(Name = "description")]
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_IsPrint"/>
    [DataMember(Name = "isPrint")]
    public bool? IsPrint { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_IsProducer"/>
    [DataMember(Name = "isProducer")]
    public bool? IsProducer { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_IsReseller"/>
    [DataMember(Name = "isReseller")]
    public bool? IsReseller { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Name"/>
    [DataMember(Name = "name")]
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Phone"/>
    [DataMember(Name = "phone")]
    public string Phone { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_State"/>
    [DataMember(Name = "state")]
    public string State { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_VendorCpe"/>
    [DataMember(Name = "cpe")]
    [JsonPropertyName("cpe")]
    public string VendorCpe { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Web"/>
    [DataMember(Name = "web")]
    public string Web { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Zip"/>
    [DataMember(Name = "zip")]
    public string Zip { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany__ctor"/>
    public SwLibCompany() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibCompany(ArchiveStream ar) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_WriteToArchive_Alvao_API_Utils_ArchiveStream_"/>
    public override void WriteToArchive(ArchiveStream archiveStream) { throw new NotImplementedException(); }
}
