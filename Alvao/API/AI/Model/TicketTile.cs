namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html"/>
public class TicketTile : SimilarEntity, ISimilarEntity {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_ActId"/>
    public int? ActId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_Requester"/>
    public string Requester { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_RequesterPortraitHash"/>
    public string RequesterPortraitHash { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_Resolved"/>
    public bool Resolved { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_SectionName"/>
    public string SectionName { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_ServiceIconId"/>
    public int? ServiceIconId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_ServiceName"/>
    public string ServiceName { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_ServiceTileBackgroundColor"/>
    public int? ServiceTileBackgroundColor { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_ServiceTileType"/>
    public int? ServiceTileType { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_Solver"/>
    public string Solver { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_SolverAccount"/>
    public string SolverAccount { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_State"/>
    public string State { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_TicketUserId"/>
    public int? TicketUserId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_sHdTicket"/>
    public string sHdTicket { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.TicketTile.html#Alvao_API_AI_Model_TicketTile_sHdTicketMessageTag"/>
    public string sHdTicketMessageTag { get; set; }

}
