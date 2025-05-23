using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_RelatedTicketRuleModel.htm"/>
public class RelatedTicketRuleModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_RelatedTicketRuleModel_RelatedTicketRule.htm"/>
    public RelatedTicketRule RelatedTicketRule { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_RelatedTicketRuleModel_TicketTemplate.htm"/>
    public TicketTemplate TicketTemplate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_RelatedTicketRuleModel__ctor.htm"/>
    public RelatedTicketRuleModel() { }
}
