using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software product library - recognition rules for records from the register.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html"/>
[Table("dbo.tblRegImage")]
public class tblRegImage {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_bolProductKey"/>
    /// <remarks>Column <c>bolProductKey</c>: bit, not null.</remarks>
    public virtual bool bolProductKey { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_bolValid"/>
    /// <remarks>Column <c>bolValid</c>: bit, not null.</remarks>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_dteTimeStamp"/>
    /// <remarks>Column <c>dteTimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intFlags"/>
    /// <remarks>Column <c>intFlags</c>: int, null.</remarks>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intLanguage"/>
    /// <remarks>Column <c>intLanguage</c>: int, null.</remarks>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intOrder"/>
    /// <remarks>Column <c>intOrder</c>: int, null.</remarks>
    public virtual int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intRegImageId"/>
    /// <remarks>Column <c>intRegImageId</c>: int, not null.</remarks>
    [Key]
    public virtual int intRegImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intRegImageUID"/>
    /// <remarks>Column <c>intRegImageUID</c>: int, not null.</remarks>
    public virtual int intRegImageUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMajorHi"/>
    /// <remarks>Column <c>intVersionMajorHi</c>: int, null.</remarks>
    public virtual int? intVersionMajorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMajorLo"/>
    /// <remarks>Column <c>intVersionMajorLo</c>: int, null.</remarks>
    public virtual int? intVersionMajorLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMinorHi"/>
    /// <remarks>Column <c>intVersionMinorHi</c>: int, null.</remarks>
    public virtual int? intVersionMinorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMinorLo"/>
    /// <remarks>Column <c>intVersionMinorLo</c>: int, null.</remarks>
    public virtual int? intVersionMinorLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtCertifiedBy"/>
    /// <remarks>Column <c>txtCertifiedBy</c>: nvarchar(255), null.</remarks>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtComments"/>
    /// <remarks>Column <c>txtComments</c>: nvarchar(255), null.</remarks>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtDisplayName"/>
    /// <remarks>Column <c>txtDisplayName</c>: nvarchar(255), null.</remarks>
    public virtual string txtDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtDisplayVersion"/>
    /// <remarks>Column <c>txtDisplayVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtDisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtPath"/>
    /// <remarks>Column <c>txtPath</c>: nvarchar(255), null.</remarks>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtPublisher"/>
    /// <remarks>Column <c>txtPublisher</c>: nvarchar(255), null.</remarks>
    public virtual string txtPublisher { get; set; }
}
