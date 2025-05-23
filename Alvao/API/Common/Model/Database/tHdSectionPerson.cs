using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Setting of notifications from the services to individual persons.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdSectionPerson.htm"/>
[TableAttribute("dbo.tHdSectionPerson")]
public class tHdSectionPerson {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketCreated.htm"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged.htm"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketOpen.htm"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketPassed.htm"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketPassed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnNewMessageReceived.htm"/>
    public virtual bool? bHdSectionPersonNotifySolverOnNewMessageReceived { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketCreated.htm"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged.htm"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketResolved.htm"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketSolverOpen.htm"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketSolverOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_bNotifySolverOnHdTicketReturnedToOperators.htm"/>
    public virtual bool? bNotifySolverOnHdTicketReturnedToOperators { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_iHdSectionPersonId.htm"/>
    [KeyAttribute]
    public virtual int iHdSectionPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_liHdSectionPersonHdSectionId.htm"/>
    public virtual int? liHdSectionPersonHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionPerson_liHdSectionPersonPersonId.htm"/>
    public virtual int? liHdSectionPersonPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tHdSectionPerson__ctor.htm"/>
    public tHdSectionPerson() { }
}
