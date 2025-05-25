using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective authorization of users to tickets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html"/>
[Table("dbo.vHdTicketPersonRead")]
public class vHdTicketPersonRead {
    /// <summary>1 = the user only has the right to see the ticket (with regard to groups of requesters) and is not a member of the ticket solver team. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_OnlyReader"/>
    public virtual int OnlyReader { get; set; }
    /// <summary>1 = the user is the requester of the ticket and has no other roles. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_OnlyRequester"/>
    public virtual int? OnlyRequester { get; set; }
    /// <summary>1 = the user is the main service solver of the ticket in question (with regard to groups of requesters). 0 = other.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Operator"/>
    public virtual int? Operator { get; set; }
    /// <summary>1 = the user is a service solver of the given ticket (with regard to groups of requesters). 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Solver"/>
    public virtual int? Solver { get; set; }
    /// <summary>1 = the user is a member of the service team of the given ticket (with regard to groups of requesters). 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_SolverTeam"/>
    public virtual int? SolverTeam { get; set; }
    /// <summary>Ticket ID, see tHdTicket.iHdTicketId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_liHdTicketId"/>
    public virtual int? liHdTicketId { get; set; }
    /// <summary>User ID, see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
