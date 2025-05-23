namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_ResolvedTicketRelationsModel.htm"/>
public class ResolvedTicketRelationsModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_BeginTicketId.htm"/>
    public int BeginTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_EndTicketId.htm"/>
    public int EndTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_RelatedTicketMessageTag.htm"/>
    public string RelatedTicketMessageTag { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_RelatedTicketName.htm"/>
    public string RelatedTicketName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_RelationTypeId.htm"/>
    public int RelationTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_ResolvedTicketMessageTag.htm"/>
    public string ResolvedTicketMessageTag { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ResolvedTicketRelationsModel_ResolvedTicketName.htm"/>
    public string ResolvedTicketName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_ResolvedTicketRelationsModel__ctor.htm"/>
    public ResolvedTicketRelationsModel() { }
}
