using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective settings of notifications sent from the services to individual persons.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionPerson.htm"/>
[TableAttribute("dbo.vHdSectionPerson")]
public class vHdSectionPerson
{
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketCreated { get; set; }
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged { get; set; }
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketOpen { get; set; }
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketPassed { get; set; }
    public virtual bool bHdSectionPersonNotifySolverOnNewMessageReceived { get; set; }
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketCreated { get; set; }
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged { get; set; }
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketResolved { get; set; }
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketSolverOpen { get; set; }
    public virtual int? bNotifySolverOnHdTicketReturnedToOperators { get; set; }
    public virtual int liHdSectionPersonHdSectionId { get; set; }
    public virtual int liHdSectionPersonPersonId { get; set; }

    public vHdSectionPerson() { }
}
