using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on items lent and returned in the media library.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_MediaLend.htm"/>
[TableAttribute("dbo.MediaLend")]
public class MediaLend
{
    /// <summary>Date lended</summary>
    public virtual DateTime? dteLended { get; set; }
    /// <summary>Date returned</summary>
    public virtual DateTime? dteReturned { get; set; }
    /// <summary>Taken over by - tPerson</summary>
    public virtual int? liAcceptingPersonId { get; set; }
    /// <summary>Lended by - tPerson</summary>
    public virtual int liLendingPersonId { get; set; }
    /// <summary>Lended to person in tree - tblNode</summary>
    public virtual int? lintPersonNodeId { get; set; }
    /// <summary>Media (tblMedia.id)</summary>
    [ExplicitKeyAttribute]
    public virtual int MediaId { get; set; }
    /// <summary>Note</summary>
    public virtual string txtNote { get; set; }
    /// <summary>Lended to</summary>
    public virtual string txtPerson { get; set; }

    public MediaLend() { }
}
