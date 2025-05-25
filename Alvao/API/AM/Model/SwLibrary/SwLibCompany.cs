namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html"/>
public class SwLibCompany : SwLibBase {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Address1"/>
    public string Address1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Address2"/>
    public string Address2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_City"/>
    public string City { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_IsPrint"/>
    public bool IsPrint { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_IsProducer"/>
    public bool IsProducer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_IsReseller"/>
    public bool IsReseller { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Phone"/>
    public string Phone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_State"/>
    public string State { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Web"/>
    public string Web { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany_Zip"/>
    public string Zip { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany__ctor"/>
    public SwLibCompany() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibCompany.html#Alvao_API_AM_Model_SwLibrary_SwLibCompany__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibCompany(ArchiveStream ar) { }
}
