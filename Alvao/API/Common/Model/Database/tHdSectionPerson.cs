using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Setting of notifications from the services to individual persons.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html"/>
[Table("dbo.tHdSectionPerson")]
public class tHdSectionPerson {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketCreated"/>
    /// <remarks>Column <c>bHdSectionPersonNotifySolverOnHdTicketCreated</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged"/>
    /// <remarks>Column <c>bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketHdSectionChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketOpen"/>
    /// <remarks>Column <c>bHdSectionPersonNotifySolverOnHdTicketOpen</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnHdTicketPassed"/>
    /// <remarks>Column <c>bHdSectionPersonNotifySolverOnHdTicketPassed</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifySolverOnHdTicketPassed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifySolverOnNewMessageReceived"/>
    /// <remarks>Column <c>bHdSectionPersonNotifySolverOnNewMessageReceived</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifySolverOnNewMessageReceived { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketCreated"/>
    /// <remarks>Column <c>bHdSectionPersonNotifyUserOnHdTicketCreated</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged"/>
    /// <remarks>Column <c>bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketDeadlineChanged { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketResolved"/>
    /// <remarks>Column <c>bHdSectionPersonNotifyUserOnHdTicketResolved</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bHdSectionPersonNotifyUserOnHdTicketSolverOpen"/>
    /// <remarks>Column <c>bHdSectionPersonNotifyUserOnHdTicketSolverOpen</c>: bit, null.</remarks>
    public virtual bool? bHdSectionPersonNotifyUserOnHdTicketSolverOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_bNotifySolverOnHdTicketReturnedToOperators"/>
    /// <remarks>Column <c>bNotifySolverOnHdTicketReturnedToOperators</c>: bit, null.</remarks>
    public virtual bool? bNotifySolverOnHdTicketReturnedToOperators { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_iHdSectionPersonId"/>
    /// <remarks>Column <c>iHdSectionPersonId</c>: int, not null.</remarks>
    [Key]
    public virtual int iHdSectionPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_liHdSectionPersonHdSectionId"/>
    /// <remarks>Column <c>liHdSectionPersonHdSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? liHdSectionPersonHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionPerson.html#Alvao_API_Common_Model_Database_tHdSectionPerson_liHdSectionPersonPersonId"/>
    /// <remarks>Column <c>liHdSectionPersonPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liHdSectionPersonPersonId { get; set; }
}
