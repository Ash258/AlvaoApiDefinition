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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_dteLended.htm"/>
    public virtual DateTime? dteLended { get; set; }
    /// <summary>Date returned</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_dteReturned.htm"/>
    public virtual DateTime? dteReturned { get; set; }
    /// <summary>Taken over by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_liAcceptingPersonId.htm"/>
    public virtual int? liAcceptingPersonId { get; set; }
    /// <summary>Lended by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_liLendingPersonId.htm"/>
    public virtual int liLendingPersonId { get; set; }
    /// <summary>Lended to person in tree - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_lintPersonNodeId.htm"/>
    public virtual int? lintPersonNodeId { get; set; }
    /// <summary>Media (tblMedia.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_MediaId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int MediaId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_txtNote.htm"/>
    public virtual string txtNote { get; set; }
    /// <summary>Lended to</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MediaLend_txtPerson.htm"/>
    public virtual string txtPerson { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_MediaLend__ctor.htm"/>
    public MediaLend() { }
}
