using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of localizations for sections on ticket status transition forms.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html"/>
[Table("dbo.vTicketStatusTransitionFormSectionLoc")]
public class vTicketStatusTransitionFormSectionLoc {
    /// <summary>
    /// 1 = when the form for transition to status is displayed, the section will be expanded. 0 = the section will be
    /// collapsed.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormSectionLoc_Expand"/>
    public virtual bool Expand { get; set; }
    /// <summary>Entity ID (TicketStatusTransitionFormSection.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormSectionLoc_Id"/>
    public virtual int Id { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormSectionLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized section name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormSectionLoc_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Row on which the section is displayed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormSectionLoc_Order"/>
    public virtual int Order { get; set; }
    /// <summary>Ticket status ID (TicketState.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormSectionLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormSectionLoc_StatusId"/>
    public virtual int StatusId { get; set; }
}
