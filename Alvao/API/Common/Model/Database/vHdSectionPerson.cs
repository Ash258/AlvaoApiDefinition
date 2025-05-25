using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective settings of notifications sent from the services to individual persons.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html"/>
[Table("dbo.vHdSectionPerson")]
public class vHdSectionPerson {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketCreated"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketOpen"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketPassed"/>
    public virtual bool bHdSectionPersonNotifySolverOnHdTicketPassed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifySolverOnNewMessageReceived"/>
    public virtual bool bHdSectionPersonNotifySolverOnNewMessageReceived { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketCreated"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketResolved"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketSolverOpen"/>
    public virtual bool bHdSectionPersonNotifyUserOnHdTicketSolverOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_bNotifySolverOnHdTicketReturnedToOperators"/>
    public virtual int? bNotifySolverOnHdTicketReturnedToOperators { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_liHdSectionPersonHdSectionId"/>
    public virtual int liHdSectionPersonHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionPerson.html#Alvao_API_Common_Model_Database_vHdSectionPerson_liHdSectionPersonPersonId"/>
    public virtual int liHdSectionPersonPersonId { get; set; }
}
