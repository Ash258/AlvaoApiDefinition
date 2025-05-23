namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html"/>
public class SwLibBase {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_CertifiedBy"/>
    public string CertifiedBy { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_Flags"/>
    public int? Flags { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_IsValid"/>
    public bool IsValid { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_TimeStamp"/>
    public DateTime TimeStamp { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_UID"/>
    public int UID { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase__ctor"/>
    public SwLibBase() { }
}
