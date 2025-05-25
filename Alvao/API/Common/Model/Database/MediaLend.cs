using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on items lent and returned in the media library.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html"/>
[Table("dbo.MediaLend")]
public class MediaLend {
    /// <summary>Media (tblMedia.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_MediaId"/>
    [ExplicitKey]
    public virtual int MediaId { get; set; }
    /// <summary>Date lended</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_dteLended"/>
    public virtual DateTime? dteLended { get; set; }
    /// <summary>Date returned</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_dteReturned"/>
    public virtual DateTime? dteReturned { get; set; }
    /// <summary>Taken over by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_liAcceptingPersonId"/>
    public virtual int? liAcceptingPersonId { get; set; }
    /// <summary>Lended by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_liLendingPersonId"/>
    public virtual int liLendingPersonId { get; set; }
    /// <summary>Lended to person in tree - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_lintPersonNodeId"/>
    public virtual int? lintPersonNodeId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_txtNote"/>
    public virtual string txtNote { get; set; }
    /// <summary>Lended to</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_txtPerson"/>
    public virtual string txtPerson { get; set; }
}
