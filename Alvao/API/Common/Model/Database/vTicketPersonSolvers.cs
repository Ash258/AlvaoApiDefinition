using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketPersonSolvers.html"/>
[Table("dbo.vTicketPersonSolvers")]
public class vTicketPersonSolvers {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketPersonSolvers.html#Alvao_API_Common_Model_Database_vTicketPersonSolvers_Operator"/>
    public virtual int? Operator { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketPersonSolvers.html#Alvao_API_Common_Model_Database_vTicketPersonSolvers_Solver"/>
    public virtual int? Solver { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketPersonSolvers.html#Alvao_API_Common_Model_Database_vTicketPersonSolvers_SolverTeam"/>
    public virtual int? SolverTeam { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketPersonSolvers.html#Alvao_API_Common_Model_Database_vTicketPersonSolvers_liHdTicketId"/>
    public virtual int? liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketPersonSolvers.html#Alvao_API_Common_Model_Database_vTicketPersonSolvers_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
