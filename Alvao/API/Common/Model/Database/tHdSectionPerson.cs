using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Setting of notifications from the services to individual persons.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html"/>
[Table("dbo.tHdSectionPerson")]
public class tHdSectionPerson {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketCreated"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketOpen"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketPassed"/>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketPassed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnNewMessageReceived"/>
    public virtual bool? bHdSectionPersonNotifySolverOnNewMessageReceived { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketCreated"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketResolved"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketSolverOpen"/>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketSolverOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bNotifySolverOnHdTicketReturnedToOperators"/>
    public virtual bool? bNotifySolverOnHdTicketReturnedToOperators { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_iHdSectionPersonId"/>
    [Key]
    public virtual int iHdSectionPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_liHdSectionPersonHdSectionId"/>
    public virtual int? liHdSectionPersonHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_liHdSectionPersonPersonId"/>
    public virtual int? liHdSectionPersonPersonId { get; set; }
}
