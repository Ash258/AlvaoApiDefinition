using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Software products library - recognition rules for records from the register.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblRegImage.htm"/>
[TableAttribute("dbo.tblRegImage")]
public class tblRegImage
{
    public virtual bool bolProductKey { get; set; }
    public virtual bool bolValid { get; set; }
    public virtual DateTime dteTimeStamp { get; set; }
    public virtual int? intFlags { get; set; }
    public virtual int? intLanguage { get; set; }
    public virtual int? intOrder { get; set; }
    [KeyAttribute]
    public virtual int intRegImageId { get; set; }
    public virtual int intRegImageUID { get; set; }
    public virtual int? intVersionMajorHi { get; set; }
    public virtual int? intVersionMajorLo { get; set; }
    public virtual int? intVersionMinorHi { get; set; }
    public virtual int? intVersionMinorLo { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual string txtCertifiedBy { get; set; }
    public virtual string txtComments { get; set; }
    public virtual string txtDisplayName { get; set; }
    public virtual string txtDisplayVersion { get; set; }
    public virtual string txtPath { get; set; }
    public virtual string txtPublisher { get; set; }

    public tblRegImage() { }
}
