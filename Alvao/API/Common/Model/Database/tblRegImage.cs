using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software products library - recognition rules for records from the register.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html"/>
[Table("dbo.tblRegImage")]
public class tblRegImage {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_bolProductKey"/>
    public virtual bool bolProductKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_bolValid"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_dteTimeStamp"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intLanguage"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intOrder"/>
    public virtual int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intRegImageId"/>
    [Key]
    public virtual int intRegImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intRegImageUID"/>
    public virtual int intRegImageUID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMajorHi"/>
    public virtual int? intVersionMajorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMajorLo"/>
    public virtual int? intVersionMajorLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMinorHi"/>
    public virtual int? intVersionMinorHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_intVersionMinorLo"/>
    public virtual int? intVersionMinorLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtCertifiedBy"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtComments"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtDisplayName"/>
    public virtual string txtDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtDisplayVersion"/>
    public virtual string txtDisplayVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtPath"/>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblRegImage.html#Alvao_API_Common_Model_Database_tblRegImage_txtPublisher"/>
    public virtual string txtPublisher { get; set; }
}
