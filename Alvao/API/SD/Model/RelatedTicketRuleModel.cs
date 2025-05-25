using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.RelatedTicketRuleModel.html"/>
public class RelatedTicketRuleModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.RelatedTicketRuleModel.html#Alvao_API_SD_Model_RelatedTicketRuleModel_RelatedTicketRule"/>
    public RelatedTicketRule RelatedTicketRule { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.RelatedTicketRuleModel.html#Alvao_API_SD_Model_RelatedTicketRuleModel_TicketTemplate"/>
    public TicketTemplate TicketTemplate { get; set; }
}
