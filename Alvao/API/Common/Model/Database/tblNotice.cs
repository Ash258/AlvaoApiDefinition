using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Notes.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblNotice.htm"/>
[TableAttribute("dbo.tblNotice")]
public class tblNotice {
    /// <summary>date and time the note was created</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_dteDateTime.htm"/>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_intNoticeId.htm"/>
    [KeyAttribute]
    public virtual int intNoticeId { get; set; }
    /// <summary>object - tblNodeId</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_lintNodeId.htm"/>
    public virtual int lintNodeId { get; set; }
    /// <summary>author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_RemovedByPersonId.htm"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_RemovedDate.htm"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>text</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }
    /// <summary>subject</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNotice_txtSubject.htm"/>
    public virtual string txtSubject { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblNotice__ctor.htm"/>
    public tblNotice() { }
}
