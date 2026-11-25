using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on items lent and returned in the media library.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html"/>
[Table("dbo.MediaLend")]
public class MediaLend {
    /// <summary>Media (tblMedia.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_MediaId"/>
    /// <remarks>Column <c>MediaId</c>: int, not null. References <see cref="tblMedia"/>.</remarks>
    [ExplicitKey]
    public virtual int MediaId { get; set; }
    /// <summary>Date lended</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_dteLended"/>
    /// <remarks>Column <c>dteLended</c>: datetime, null.</remarks>
    public virtual DateTime? dteLended { get; set; }
    /// <summary>Date returned</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_dteReturned"/>
    /// <remarks>Column <c>dteReturned</c>: datetime, null.</remarks>
    public virtual DateTime? dteReturned { get; set; }
    /// <summary>Taken over by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_liAcceptingPersonId"/>
    /// <remarks>Column <c>liAcceptingPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liAcceptingPersonId { get; set; }
    /// <summary>Lended by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_liLendingPersonId"/>
    /// <remarks>Column <c>liLendingPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liLendingPersonId { get; set; }
    /// <summary>Lended to person in tree - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_lintPersonNodeId"/>
    /// <remarks>Column <c>lintPersonNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintPersonNodeId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_txtNote"/>
    /// <remarks>Column <c>txtNote</c>: nvarchar(max), null.</remarks>
    public virtual string txtNote { get; set; }
    /// <summary>Lended to</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MediaLend.html#Alvao_API_Common_Model_Database_MediaLend_txtPerson"/>
    /// <remarks>Column <c>txtPerson</c>: nvarchar(255), null.</remarks>
    public virtual string txtPerson { get; set; }
}
