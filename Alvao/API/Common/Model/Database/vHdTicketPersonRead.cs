using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective authorization of users to tickets.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdTicketPersonRead.htm"/>
[TableAttribute("dbo.vHdTicketPersonRead")]
public class vHdTicketPersonRead
{
    /// <summary>Ticket ID, see tHdTicket.iHdTicketId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_liHdTicketId.htm"/>
    public virtual int? liHdTicketId { get; set; }
    /// <summary>User ID, see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }
    /// <summary>1 = the user only has the right to see the ticket (with regard to groups of requesters) and is not a member of the ticket solver team. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_OnlyReader.htm"/>
    public virtual int OnlyReader { get; set; }
    /// <summary>1 = the user is the requester of the ticket and has no other roles. 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_OnlyRequester.htm"/>
    public virtual int? OnlyRequester { get; set; }
    /// <summary>1 = the user is the main service solver of the ticket in question (with regard to groups of requesters). 0 = other.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_Operator.htm"/>
    public virtual int? Operator { get; set; }
    /// <summary>1 = the user is a service solver of the given ticket (with regard to groups of requesters). 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_Solver.htm"/>
    public virtual int? Solver { get; set; }
    /// <summary>1 = the user is a member of the service team of the given ticket (with regard to groups of requesters). 0 = otherwise.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicketPersonRead_SolverTeam.htm"/>
    public virtual int? SolverTeam { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdTicketPersonRead__ctor.htm"/>
    public vHdTicketPersonRead() { }
}
