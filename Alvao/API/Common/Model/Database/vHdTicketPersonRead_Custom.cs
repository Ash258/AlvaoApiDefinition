using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Custom extension of user permissions to see tickets. You can customize this view to include users and requests that those users should see in the application.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html"/>
[Table("dbo.vHdTicketPersonRead_Custom")]
public class vHdTicketPersonRead_Custom {
    /// <summary>1 = the user is the main service solver of the ticket in question (with regard to groups of requesters). 0 = other.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_Operator"/>
    public virtual int? Operator { get; set; }
    /// <summary>User ID, see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>1 = the user has permission to see the ticket. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_Read"/>
    public virtual int? Read { get; set; }
    /// <summary>1 = the user is the requester of the ticket or has the same permissions as the requester. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_Requester"/>
    public virtual int? Requester { get; set; }
    /// <summary>1 = the user is a service solver of the given ticket (with regard to groups of requesters). 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_Solver"/>
    public virtual int? Solver { get; set; }
    /// <summary>1 = the user is a member of the service team of the given ticket (with regard to groups of requesters). 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_SolverTeam"/>
    public virtual int? SolverTeam { get; set; }
    /// <summary>Ticket ID, see tHdTicket.iHdTicketId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketPersonRead_Custom.html#Alvao_API_Common_Model_Database_vHdTicketPersonRead_Custom_TicketId"/>
    public virtual int? TicketId { get; set; }
}
