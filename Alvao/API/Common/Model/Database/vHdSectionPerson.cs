using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective settings of notifications sent from the services to individual persons.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionPerson.htm"/>
[TableAttribute("dbo.vHdSectionPerson")]
public class vHdSectionPerson
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketCreated.htm"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged.htm"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketOpen.htm"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketPassed.htm"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketPassed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnNewMessageReceived.htm"/>
    public virtual bool bHdSectionPersonNotifySolverOnNewMessageReceived { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketCreated.htm"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged.htm"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketResolved.htm"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketSolverOpen.htm"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketSolverOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_bNotifySolverOnHdTicketReturnedToOperators.htm"/>
    public virtual int? bNotifySolverOnHdTicketReturnedToOperators { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_liHdSectionPersonHdSectionId.htm"/>
    public virtual int liHdSectionPersonHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionPerson_liHdSectionPersonPersonId.htm"/>
    public virtual int liHdSectionPersonPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdSectionPerson__ctor.htm"/>
    public vHdSectionPerson() { }
}
