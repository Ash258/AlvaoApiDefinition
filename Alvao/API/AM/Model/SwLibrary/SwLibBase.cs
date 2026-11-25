using System.Runtime.Serialization;
using Alvao.API.Utils;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html"/>
[DataContract]
public class SwLibBase {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_CertifiedBy"/>
    [IgnoreDataMember]
    public string CertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_Flags"/>
    [DataMember(Name = "flags")]
    public int? Flags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_IsValid"/>
    [DataMember(Name = "isValid")]
    public bool? IsValid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_TimeStamp"/>
    [DataMember(Name = "timeStamp")]
    public DateTime TimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_UID"/>
    [DataMember(Name = "uid")]
    public int UID { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase__ctor"/>
    public SwLibBase() { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibBase.html#Alvao_API_AM_Model_SwLibrary_SwLibBase_WriteToArchive_Alvao_API_Utils_ArchiveStream_"/>
    public virtual void WriteToArchive(ArchiveStream archiveStream) { throw new NotImplementedException(); }
}
